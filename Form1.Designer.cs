namespace NetMounter
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.lvMappings = new System.Windows.Forms.ListView();
      this.chHeaderShare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.chDriveLetter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.lblReconnectDelay = new System.Windows.Forms.Label();
      this.cbDriveLetter = new System.Windows.Forms.ComboBox();
      this.tbShareName = new System.Windows.Forms.TextBox();
      this.lblSharePath = new System.Windows.Forms.Label();
      this.btnAddMapping = new System.Windows.Forms.Button();
      this.cbReconnectDelay = new System.Windows.Forms.ComboBox();
      this.cbStartMinimized = new System.Windows.Forms.CheckBox();
      this.btnRemoveMapping = new System.Windows.Forms.Button();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.lblDriveLetter = new System.Windows.Forms.Label();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // lvMappings
      // 
      this.lvMappings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chHeaderShare,
            this.chDriveLetter});
      this.lvMappings.Location = new System.Drawing.Point(12, 52);
      this.lvMappings.Name = "lvMappings";
      this.lvMappings.Size = new System.Drawing.Size(464, 174);
      this.lvMappings.TabIndex = 0;
      this.lvMappings.UseCompatibleStateImageBehavior = false;
      this.lvMappings.View = System.Windows.Forms.View.Details;
      // 
      // chHeaderShare
      // 
      this.chHeaderShare.Text = "Share Name";
      this.chHeaderShare.Width = 361;
      // 
      // chDriveLetter
      // 
      this.chDriveLetter.Text = "Drive Letter";
      this.chDriveLetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.chDriveLetter.Width = 93;
      // 
      // lblReconnectDelay
      // 
      this.lblReconnectDelay.AutoSize = true;
      this.lblReconnectDelay.Location = new System.Drawing.Point(298, 242);
      this.lblReconnectDelay.Name = "lblReconnectDelay";
      this.lblReconnectDelay.Size = new System.Drawing.Size(117, 13);
      this.lblReconnectDelay.TabIndex = 5;
      this.lblReconnectDelay.Text = "Reconnect x seconds: ";
      // 
      // cbDriveLetter
      // 
      this.cbDriveLetter.FormattingEnabled = true;
      this.cbDriveLetter.Items.AddRange(new object[] {
            "A:",
            "B;",
            "D:",
            "E:",
            "F:",
            "G:",
            "H:",
            "I:",
            "J:",
            "K:",
            "M:",
            "N:",
            "O:",
            "P:",
            "Q:",
            "R:",
            "S:",
            "T:",
            "U:",
            "V:",
            "W:",
            "X:",
            "Y:",
            "Z:"});
      this.cbDriveLetter.Location = new System.Drawing.Point(336, 11);
      this.cbDriveLetter.Name = "cbDriveLetter";
      this.cbDriveLetter.Size = new System.Drawing.Size(58, 21);
      this.cbDriveLetter.TabIndex = 2;
      // 
      // tbShareName
      // 
      this.tbShareName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.tbShareName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
      this.tbShareName.Location = new System.Drawing.Point(93, 12);
      this.tbShareName.Name = "tbShareName";
      this.tbShareName.Size = new System.Drawing.Size(203, 20);
      this.tbShareName.TabIndex = 1;
      // 
      // lblSharePath
      // 
      this.lblSharePath.AutoSize = true;
      this.lblSharePath.Location = new System.Drawing.Point(12, 15);
      this.lblSharePath.Name = "lblSharePath";
      this.lblSharePath.Size = new System.Drawing.Size(75, 26);
      this.lblSharePath.TabIndex = 6;
      this.lblSharePath.Text = "Share path\r\n( \\\\host\\path )";
      // 
      // btnAddMapping
      // 
      this.btnAddMapping.Location = new System.Drawing.Point(421, 7);
      this.btnAddMapping.Name = "btnAddMapping";
      this.btnAddMapping.Size = new System.Drawing.Size(55, 34);
      this.btnAddMapping.TabIndex = 3;
      this.btnAddMapping.Text = "Add";
      this.btnAddMapping.UseVisualStyleBackColor = true;
      this.btnAddMapping.Click += new System.EventHandler(this.btnAddMapping_Click);
      // 
      // cbReconnectDelay
      // 
      this.cbReconnectDelay.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NetMounter.Properties.Settings.Default, "ReconnectDelay", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.cbReconnectDelay.FormattingEnabled = true;
      this.cbReconnectDelay.Location = new System.Drawing.Point(421, 239);
      this.cbReconnectDelay.Name = "cbReconnectDelay";
      this.cbReconnectDelay.Size = new System.Drawing.Size(55, 21);
      this.cbReconnectDelay.TabIndex = 6;
      this.cbReconnectDelay.Text = global::NetMounter.Properties.Settings.Default.ReconnectDelay;
      this.cbReconnectDelay.TextUpdate += new System.EventHandler(this.cbReconnectDelay_TextUpdate);
      // 
      // cbStartMinimized
      // 
      this.cbStartMinimized.AutoSize = true;
      this.cbStartMinimized.Checked = global::NetMounter.Properties.Settings.Default.startMinimized;
      this.cbStartMinimized.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::NetMounter.Properties.Settings.Default, "startMinimized", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.cbStartMinimized.Location = new System.Drawing.Point(12, 240);
      this.cbStartMinimized.Name = "cbStartMinimized";
      this.cbStartMinimized.Size = new System.Drawing.Size(94, 17);
      this.cbStartMinimized.TabIndex = 4;
      this.cbStartMinimized.Text = "Start minimzed";
      this.cbStartMinimized.UseVisualStyleBackColor = true;
      // 
      // btnRemoveMapping
      // 
      this.btnRemoveMapping.Location = new System.Drawing.Point(148, 232);
      this.btnRemoveMapping.Name = "btnRemoveMapping";
      this.btnRemoveMapping.Size = new System.Drawing.Size(135, 30);
      this.btnRemoveMapping.TabIndex = 7;
      this.btnRemoveMapping.Text = "Remove mapping";
      this.btnRemoveMapping.UseVisualStyleBackColor = true;
      this.btnRemoveMapping.Click += new System.EventHandler(this.btnRemoveMapping_Click);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(104, 54);
      // 
      // notifyIcon1
      // 
      this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
      this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
      this.notifyIcon1.Text = "notifyIcon1";
      this.notifyIcon1.Visible = true;
      this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
      this.openToolStripMenuItem.Text = "Open";
      this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
      // 
      // closeToolStripMenuItem
      // 
      this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
      this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
      this.closeToolStripMenuItem.Text = "Close";
      this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
      // 
      // lblDriveLetter
      // 
      this.lblDriveLetter.AutoSize = true;
      this.lblDriveLetter.Location = new System.Drawing.Point(298, 15);
      this.lblDriveLetter.Name = "lblDriveLetter";
      this.lblDriveLetter.Size = new System.Drawing.Size(32, 13);
      this.lblDriveLetter.TabIndex = 9;
      this.lblDriveLetter.Text = "Drive";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(488, 272);
      this.Controls.Add(this.lblDriveLetter);
      this.Controls.Add(this.btnRemoveMapping);
      this.Controls.Add(this.btnAddMapping);
      this.Controls.Add(this.lblSharePath);
      this.Controls.Add(this.tbShareName);
      this.Controls.Add(this.cbDriveLetter);
      this.Controls.Add(this.lblReconnectDelay);
      this.Controls.Add(this.cbReconnectDelay);
      this.Controls.Add(this.cbStartMinimized);
      this.Controls.Add(this.lvMappings);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Text = "Net Mounter";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Resize += new System.EventHandler(this.Form1_Resize);
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListView lvMappings;
    private System.Windows.Forms.ColumnHeader chHeaderShare;
    private System.Windows.Forms.ColumnHeader chDriveLetter;
    private System.Windows.Forms.CheckBox cbStartMinimized;
    private System.Windows.Forms.ComboBox cbReconnectDelay;
    private System.Windows.Forms.Label lblReconnectDelay;
    private System.Windows.Forms.ComboBox cbDriveLetter;
    private System.Windows.Forms.TextBox tbShareName;
    private System.Windows.Forms.Label lblSharePath;
    private System.Windows.Forms.Button btnAddMapping;
    private System.Windows.Forms.Button btnRemoveMapping;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.NotifyIcon notifyIcon1;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    private System.Windows.Forms.Label lblDriveLetter;
  }
}

