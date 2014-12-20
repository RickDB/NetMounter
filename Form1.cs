using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace NetMounter
{
  public partial class Form1 : Form
  {
    private int monitorInterval = 60;
    private bool monitoring = true;
    private delegate ListView.ListViewItemCollection GetItems(ListView lstview);
    public Form1()
    {
      InitializeComponent();
      loadSettings();

      if (cbStartMinimized.Checked)
      {
        this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
        this.WindowState = FormWindowState.Minimized;
        this.Visible = false;
        this.ShowInTaskbar = false;
      }

      Thread t = new Thread(monitorMappings);
      t.IsBackground = true;
      t.Start();
    }
    private void loadSettings()
    {
      monitorInterval = int.Parse(cbReconnectDelay.Text);

      try
      {
        if (File.Exists("settings.xml"))
        {
          using (XmlReader reader = XmlReader.Create("settings.xml"))
          {
            while (reader.Read())
            {
              string shareName = "";
              string driveLetter = "";
              if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "Mapping"))
              {
                reader.ReadToDescendant("ShareName");
                shareName = reader.ReadString();
                reader.ReadToFollowing("DriveLetter");
                driveLetter = reader.ReadString();

                if (string.IsNullOrEmpty(shareName) == false)
                {
                  string[] subItems = { driveLetter };
                  lvMappings.Items.Add(shareName).SubItems.AddRange(subItems);
                }
              }
            }
          }
        }
      }
      catch { };
    }
    private void monitorMappings()
    {
      while (monitoring)
      {
        checkMappings();
        Thread.Sleep(monitorInterval * 1000);
      }
    }
    private ListView.ListViewItemCollection getListViewItems(ListView lstview)
    {
      ListView.ListViewItemCollection temp = new ListView.ListViewItemCollection(new ListView());
      if (!lstview.InvokeRequired)
      {
        foreach (ListViewItem item in lstview.Items)
          temp.Add((ListViewItem)item.Clone());
        return temp;
      }
      else
        return (ListView.ListViewItemCollection)this.Invoke(new GetItems(getListViewItems), new object[] { lstview });
    }

    private void checkMappings()
    {
      foreach (ListViewItem mapping in getListViewItems(lvMappings))
      {
        try
        {
          string drive = Path.GetPathRoot(mapping.SubItems[1].Text);   // e.g. K:\

          if (!Directory.Exists(drive))
          {
            string parameters = "/c net use " + mapping.SubItems[1].Text + " \"" + mapping.Text + "\"";

            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd";
            ps.Arguments = parameters;
            ps.UseShellExecute = false;
            ps.CreateNoWindow = true;
            Process.Start(ps);
          }
        }
        catch { };
      }
    }
    private void saveSettings()
    {
      Properties.Settings.Default.Save();

      XmlWriterSettings settings = new XmlWriterSettings();
      settings.Indent = true;
      settings.IndentChars = "  ";
      settings.NewLineOnAttributes = true;

      using (XmlWriter writer = XmlWriter.Create("settings.xml", settings))
      {
        writer.WriteStartDocument();
        writer.WriteStartElement("Settings");
        writer.WriteStartElement("Mappings");

        foreach (ListViewItem mapping in lvMappings.Items)
        {
          if (string.IsNullOrEmpty(mapping.Text) == false)
          {
            writer.WriteStartElement("Mapping");
            try
            {
              writer.WriteElementString("ShareName", mapping.Text);
              writer.WriteElementString("DriveLetter", mapping.SubItems[1].Text);
            }
            catch { };

            writer.WriteEndElement();
          }
        }
        writer.WriteEndElement();


        writer.WriteEndElement();
        writer.WriteEndDocument();
      }
    }
    private void btnAddMapping_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(tbShareName.Text) == false && cbDriveLetter.Text.Length == 2)
      {
        string[] subItems = { cbDriveLetter.Text };

        lvMappings.Items.Add(tbShareName.Text).SubItems.AddRange(subItems);
        saveSettings();
      }
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      monitoring = false;
      saveSettings();
    }

    private void btnRemoveMapping_Click(object sender, EventArgs e)
    {
      lvMappings.Items.Cast<ListViewItem>().Where(T => T.Selected)
    .Select(T => T.Index).ToList().ForEach(T => lvMappings.Items.RemoveAt(T));

    }

    private void cbReconnectDelay_TextUpdate(object sender, EventArgs e)
    {
      try
      {
        monitorInterval = int.Parse(cbReconnectDelay.Text);
      }
      catch { };
    }
    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Show();
      this.WindowState = FormWindowState.Normal;
    }
    private void closeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void Form1_Resize(object sender, EventArgs e)
    {
      if (cbStartMinimized.Checked)
      {
        if (FormWindowState.Minimized == this.WindowState)
        {
          this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
          notifyIcon1.Visible = true;
          this.Hide();
        }
        else if (FormWindowState.Normal == this.WindowState)
        {
          this.FormBorderStyle = FormBorderStyle.FixedSingle;
          notifyIcon1.Visible = false;
        }
      }
    }
    private void notifyIcon1_DoubleClick(object sender, EventArgs e)
    {
      this.Show();
      this.WindowState = FormWindowState.Normal;
    }
  }
}
