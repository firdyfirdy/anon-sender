namespace AnonSender
{
  partial class FormDashboard
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
      this.panelHeader = new System.Windows.Forms.Panel();
      this.buttonMinimize = new System.Windows.Forms.Button();
      this.buttonRestoreDown = new System.Windows.Forms.Button();
      this.buttonClose = new System.Windows.Forms.Button();
      this.panelKiri = new System.Windows.Forms.Panel();
      this.labelGaris = new System.Windows.Forms.Label();
      this.panelHeaderKiri = new System.Windows.Forms.Panel();
      this.labelSenderHeader = new System.Windows.Forms.Label();
      this.dataSender = new System.Windows.Forms.DataGridView();
      this.panelFooter = new System.Windows.Forms.Panel();
      this.dataLetter = new System.Windows.Forms.DataGridView();
      this.panelHeaderFooter = new System.Windows.Forms.Panel();
      this.labelTotalLetter = new System.Windows.Forms.Label();
      this.panelBody = new System.Windows.Forms.Panel();
      this.panelHeaderBody = new System.Windows.Forms.Panel();
      this.labelClearMailist = new System.Windows.Forms.LinkLabel();
      this.LabelTotalMailist = new System.Windows.Forms.Label();
      this.dataMailist = new System.Windows.Forms.DataGridView();
      this.panelButton = new System.Windows.Forms.Panel();
      this.buttonStart = new System.Windows.Forms.Button();
      this.buttonImportMailist = new System.Windows.Forms.Button();
      this.buttonLetter = new System.Windows.Forms.Button();
      this.labelGarisBawah = new System.Windows.Forms.Label();
      this.buttonSmtpSettings = new System.Windows.Forms.Button();
      this.buttonProxySetting = new System.Windows.Forms.Button();
      this.buttonTimeZone = new System.Windows.Forms.Button();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.panelFooterBawah = new System.Windows.Forms.Panel();
      this.labelTimeZone = new System.Windows.Forms.Label();
      this.lblSelectedLetter = new System.Windows.Forms.Label();
      this.lblSelectedSender = new System.Windows.Forms.Label();
      this.panelHeader.SuspendLayout();
      this.panelKiri.SuspendLayout();
      this.panelHeaderKiri.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataSender)).BeginInit();
      this.panelFooter.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataLetter)).BeginInit();
      this.panelHeaderFooter.SuspendLayout();
      this.panelBody.SuspendLayout();
      this.panelHeaderBody.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataMailist)).BeginInit();
      this.panelButton.SuspendLayout();
      this.panelFooterBawah.SuspendLayout();
      this.SuspendLayout();
      // 
      // panelHeader
      // 
      this.panelHeader.BackColor = System.Drawing.SystemColors.ControlDark;
      this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelHeader.Controls.Add(this.buttonMinimize);
      this.panelHeader.Controls.Add(this.buttonRestoreDown);
      this.panelHeader.Controls.Add(this.buttonClose);
      this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelHeader.Location = new System.Drawing.Point(0, 0);
      this.panelHeader.Name = "panelHeader";
      this.panelHeader.Size = new System.Drawing.Size(909, 32);
      this.panelHeader.TabIndex = 1;
      this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
      // 
      // buttonMinimize
      // 
      this.buttonMinimize.Dock = System.Windows.Forms.DockStyle.Right;
      this.buttonMinimize.FlatAppearance.BorderSize = 0;
      this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonMinimize.Image = global::AnonSender.Properties.Resources.line;
      this.buttonMinimize.Location = new System.Drawing.Point(757, 0);
      this.buttonMinimize.Name = "buttonMinimize";
      this.buttonMinimize.Size = new System.Drawing.Size(50, 30);
      this.buttonMinimize.TabIndex = 1;
      this.buttonMinimize.UseVisualStyleBackColor = true;
      this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
      // 
      // buttonRestoreDown
      // 
      this.buttonRestoreDown.Dock = System.Windows.Forms.DockStyle.Right;
      this.buttonRestoreDown.FlatAppearance.BorderSize = 0;
      this.buttonRestoreDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonRestoreDown.Image = global::AnonSender.Properties.Resources.restore;
      this.buttonRestoreDown.Location = new System.Drawing.Point(807, 0);
      this.buttonRestoreDown.Name = "buttonRestoreDown";
      this.buttonRestoreDown.Size = new System.Drawing.Size(50, 30);
      this.buttonRestoreDown.TabIndex = 2;
      this.buttonRestoreDown.UseVisualStyleBackColor = true;
      this.buttonRestoreDown.Click += new System.EventHandler(this.buttonRestoreDown_Click);
      // 
      // buttonClose
      // 
      this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
      this.buttonClose.FlatAppearance.BorderSize = 0;
      this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonClose.Image = global::AnonSender.Properties.Resources.close;
      this.buttonClose.Location = new System.Drawing.Point(857, 0);
      this.buttonClose.Name = "buttonClose";
      this.buttonClose.Size = new System.Drawing.Size(50, 30);
      this.buttonClose.TabIndex = 0;
      this.buttonClose.UseVisualStyleBackColor = true;
      this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
      // 
      // panelKiri
      // 
      this.panelKiri.Controls.Add(this.labelGaris);
      this.panelKiri.Controls.Add(this.panelHeaderKiri);
      this.panelKiri.Controls.Add(this.dataSender);
      this.panelKiri.Dock = System.Windows.Forms.DockStyle.Left;
      this.panelKiri.Location = new System.Drawing.Point(0, 79);
      this.panelKiri.Name = "panelKiri";
      this.panelKiri.Size = new System.Drawing.Size(255, 399);
      this.panelKiri.TabIndex = 2;
      // 
      // labelGaris
      // 
      this.labelGaris.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.labelGaris.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.labelGaris.Location = new System.Drawing.Point(254, 0);
      this.labelGaris.Name = "labelGaris";
      this.labelGaris.Size = new System.Drawing.Size(2, 399);
      this.labelGaris.TabIndex = 3;
      // 
      // panelHeaderKiri
      // 
      this.panelHeaderKiri.Controls.Add(this.labelSenderHeader);
      this.panelHeaderKiri.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelHeaderKiri.Location = new System.Drawing.Point(0, 0);
      this.panelHeaderKiri.Name = "panelHeaderKiri";
      this.panelHeaderKiri.Size = new System.Drawing.Size(255, 26);
      this.panelHeaderKiri.TabIndex = 1;
      // 
      // labelSenderHeader
      // 
      this.labelSenderHeader.AutoSize = true;
      this.labelSenderHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelSenderHeader.Location = new System.Drawing.Point(12, 4);
      this.labelSenderHeader.Name = "labelSenderHeader";
      this.labelSenderHeader.Size = new System.Drawing.Size(103, 17);
      this.labelSenderHeader.TabIndex = 0;
      this.labelSenderHeader.Text = "Sender Email (0)";
      // 
      // dataSender
      // 
      this.dataSender.AllowUserToAddRows = false;
      this.dataSender.AllowUserToDeleteRows = false;
      this.dataSender.AllowUserToResizeColumns = false;
      this.dataSender.AllowUserToResizeRows = false;
      this.dataSender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataSender.BackgroundColor = System.Drawing.Color.White;
      this.dataSender.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dataSender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataSender.Location = new System.Drawing.Point(0, 26);
      this.dataSender.Name = "dataSender";
      this.dataSender.ReadOnly = true;
      this.dataSender.Size = new System.Drawing.Size(255, 373);
      this.dataSender.TabIndex = 0;
      this.dataSender.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSender_CellClick);
      this.dataSender.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSender_CellContentClick);
      this.dataSender.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataSender_MouseClick);
      // 
      // panelFooter
      // 
      this.panelFooter.Controls.Add(this.dataLetter);
      this.panelFooter.Controls.Add(this.panelHeaderFooter);
      this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panelFooter.Location = new System.Drawing.Point(255, 325);
      this.panelFooter.Name = "panelFooter";
      this.panelFooter.Size = new System.Drawing.Size(654, 153);
      this.panelFooter.TabIndex = 3;
      // 
      // dataLetter
      // 
      this.dataLetter.AllowUserToAddRows = false;
      this.dataLetter.AllowUserToDeleteRows = false;
      this.dataLetter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataLetter.BackgroundColor = System.Drawing.Color.White;
      this.dataLetter.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dataLetter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataLetter.Location = new System.Drawing.Point(0, 24);
      this.dataLetter.Name = "dataLetter";
      this.dataLetter.ReadOnly = true;
      this.dataLetter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataLetter.Size = new System.Drawing.Size(654, 129);
      this.dataLetter.TabIndex = 4;
      this.dataLetter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLetter_CellClick);
      this.dataLetter.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLetter_CellContentClick);
      this.dataLetter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataLetter_MouseClick);
      // 
      // panelHeaderFooter
      // 
      this.panelHeaderFooter.Controls.Add(this.labelTotalLetter);
      this.panelHeaderFooter.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelHeaderFooter.Location = new System.Drawing.Point(0, 0);
      this.panelHeaderFooter.Name = "panelHeaderFooter";
      this.panelHeaderFooter.Size = new System.Drawing.Size(654, 26);
      this.panelHeaderFooter.TabIndex = 3;
      // 
      // labelTotalLetter
      // 
      this.labelTotalLetter.AutoSize = true;
      this.labelTotalLetter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTotalLetter.Location = new System.Drawing.Point(12, 4);
      this.labelTotalLetter.Name = "labelTotalLetter";
      this.labelTotalLetter.Size = new System.Drawing.Size(60, 17);
      this.labelTotalLetter.TabIndex = 0;
      this.labelTotalLetter.Text = "Letter (0)";
      // 
      // panelBody
      // 
      this.panelBody.Controls.Add(this.panelHeaderBody);
      this.panelBody.Controls.Add(this.dataMailist);
      this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelBody.Location = new System.Drawing.Point(255, 79);
      this.panelBody.Name = "panelBody";
      this.panelBody.Size = new System.Drawing.Size(654, 246);
      this.panelBody.TabIndex = 4;
      // 
      // panelHeaderBody
      // 
      this.panelHeaderBody.Controls.Add(this.labelClearMailist);
      this.panelHeaderBody.Controls.Add(this.LabelTotalMailist);
      this.panelHeaderBody.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelHeaderBody.Location = new System.Drawing.Point(0, 0);
      this.panelHeaderBody.Name = "panelHeaderBody";
      this.panelHeaderBody.Size = new System.Drawing.Size(654, 26);
      this.panelHeaderBody.TabIndex = 2;
      // 
      // labelClearMailist
      // 
      this.labelClearMailist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.labelClearMailist.AutoSize = true;
      this.labelClearMailist.Location = new System.Drawing.Point(572, 7);
      this.labelClearMailist.Name = "labelClearMailist";
      this.labelClearMailist.Size = new System.Drawing.Size(70, 13);
      this.labelClearMailist.TabIndex = 1;
      this.labelClearMailist.TabStop = true;
      this.labelClearMailist.Text = "Clear Mailist";
      this.labelClearMailist.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelClearMailist_LinkClicked);
      // 
      // LabelTotalMailist
      // 
      this.LabelTotalMailist.AutoSize = true;
      this.LabelTotalMailist.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LabelTotalMailist.Location = new System.Drawing.Point(12, 4);
      this.LabelTotalMailist.Name = "LabelTotalMailist";
      this.LabelTotalMailist.Size = new System.Drawing.Size(65, 17);
      this.LabelTotalMailist.TabIndex = 0;
      this.LabelTotalMailist.Text = "Mailist (0)";
      // 
      // dataMailist
      // 
      this.dataMailist.AllowUserToAddRows = false;
      this.dataMailist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataMailist.BackgroundColor = System.Drawing.Color.White;
      this.dataMailist.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dataMailist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataMailist.Location = new System.Drawing.Point(0, 26);
      this.dataMailist.Name = "dataMailist";
      this.dataMailist.Size = new System.Drawing.Size(653, 217);
      this.dataMailist.TabIndex = 0;
      this.dataMailist.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataMailist_RowsRemoved);
      // 
      // panelButton
      // 
      this.panelButton.Controls.Add(this.buttonStart);
      this.panelButton.Controls.Add(this.buttonImportMailist);
      this.panelButton.Controls.Add(this.buttonLetter);
      this.panelButton.Controls.Add(this.labelGarisBawah);
      this.panelButton.Controls.Add(this.buttonSmtpSettings);
      this.panelButton.Controls.Add(this.buttonProxySetting);
      this.panelButton.Controls.Add(this.buttonTimeZone);
      this.panelButton.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelButton.Location = new System.Drawing.Point(0, 32);
      this.panelButton.Name = "panelButton";
      this.panelButton.Size = new System.Drawing.Size(909, 47);
      this.panelButton.TabIndex = 5;
      // 
      // buttonStart
      // 
      this.buttonStart.Dock = System.Windows.Forms.DockStyle.Left;
      this.buttonStart.FlatAppearance.BorderSize = 0;
      this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonStart.Image = global::AnonSender.Properties.Resources.play_button;
      this.buttonStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.buttonStart.Location = new System.Drawing.Point(543, 0);
      this.buttonStart.Name = "buttonStart";
      this.buttonStart.Size = new System.Drawing.Size(68, 47);
      this.buttonStart.TabIndex = 7;
      this.buttonStart.Text = "Start";
      this.buttonStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.buttonStart.UseVisualStyleBackColor = true;
      this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
      // 
      // buttonImportMailist
      // 
      this.buttonImportMailist.Dock = System.Windows.Forms.DockStyle.Left;
      this.buttonImportMailist.FlatAppearance.BorderSize = 0;
      this.buttonImportMailist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonImportMailist.Image = global::AnonSender.Properties.Resources.folder;
      this.buttonImportMailist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.buttonImportMailist.Location = new System.Drawing.Point(434, 0);
      this.buttonImportMailist.Name = "buttonImportMailist";
      this.buttonImportMailist.Size = new System.Drawing.Size(109, 47);
      this.buttonImportMailist.TabIndex = 2;
      this.buttonImportMailist.Text = "Import Email";
      this.buttonImportMailist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.buttonImportMailist.UseVisualStyleBackColor = true;
      this.buttonImportMailist.Click += new System.EventHandler(this.buttonImportMailist_Click);
      // 
      // buttonLetter
      // 
      this.buttonLetter.Dock = System.Windows.Forms.DockStyle.Left;
      this.buttonLetter.FlatAppearance.BorderSize = 0;
      this.buttonLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonLetter.Image = global::AnonSender.Properties.Resources.sms;
      this.buttonLetter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.buttonLetter.Location = new System.Drawing.Point(323, 0);
      this.buttonLetter.Name = "buttonLetter";
      this.buttonLetter.Size = new System.Drawing.Size(111, 47);
      this.buttonLetter.TabIndex = 4;
      this.buttonLetter.Text = "Add Message";
      this.buttonLetter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.buttonLetter.UseVisualStyleBackColor = true;
      this.buttonLetter.Click += new System.EventHandler(this.buttonLetter_Click);
      // 
      // labelGarisBawah
      // 
      this.labelGarisBawah.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.labelGarisBawah.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.labelGarisBawah.Location = new System.Drawing.Point(0, 45);
      this.labelGarisBawah.Name = "labelGarisBawah";
      this.labelGarisBawah.Size = new System.Drawing.Size(908, 2);
      this.labelGarisBawah.TabIndex = 3;
      // 
      // buttonSmtpSettings
      // 
      this.buttonSmtpSettings.Dock = System.Windows.Forms.DockStyle.Left;
      this.buttonSmtpSettings.FlatAppearance.BorderSize = 0;
      this.buttonSmtpSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonSmtpSettings.Image = global::AnonSender.Properties.Resources.mail_settings;
      this.buttonSmtpSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.buttonSmtpSettings.Location = new System.Drawing.Point(209, 0);
      this.buttonSmtpSettings.Name = "buttonSmtpSettings";
      this.buttonSmtpSettings.Size = new System.Drawing.Size(114, 47);
      this.buttonSmtpSettings.TabIndex = 5;
      this.buttonSmtpSettings.Text = "SMTP Settings";
      this.buttonSmtpSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.buttonSmtpSettings.UseVisualStyleBackColor = true;
      this.buttonSmtpSettings.Click += new System.EventHandler(this.buttonSmtpSettings_Click);
      // 
      // buttonProxySetting
      // 
      this.buttonProxySetting.Dock = System.Windows.Forms.DockStyle.Left;
      this.buttonProxySetting.FlatAppearance.BorderSize = 0;
      this.buttonProxySetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonProxySetting.Image = global::AnonSender.Properties.Resources.internet;
      this.buttonProxySetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.buttonProxySetting.Location = new System.Drawing.Point(95, 0);
      this.buttonProxySetting.Name = "buttonProxySetting";
      this.buttonProxySetting.Size = new System.Drawing.Size(114, 47);
      this.buttonProxySetting.TabIndex = 6;
      this.buttonProxySetting.Text = "Proxy Settings";
      this.buttonProxySetting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.buttonProxySetting.UseVisualStyleBackColor = true;
      this.buttonProxySetting.Click += new System.EventHandler(this.buttonProxySetting_Click);
      // 
      // buttonTimeZone
      // 
      this.buttonTimeZone.Dock = System.Windows.Forms.DockStyle.Left;
      this.buttonTimeZone.FlatAppearance.BorderSize = 0;
      this.buttonTimeZone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonTimeZone.Image = global::AnonSender.Properties.Resources.time_zone;
      this.buttonTimeZone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.buttonTimeZone.Location = new System.Drawing.Point(0, 0);
      this.buttonTimeZone.Name = "buttonTimeZone";
      this.buttonTimeZone.Size = new System.Drawing.Size(95, 47);
      this.buttonTimeZone.TabIndex = 8;
      this.buttonTimeZone.Text = "Time Zone";
      this.buttonTimeZone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.buttonTimeZone.UseVisualStyleBackColor = true;
      this.buttonTimeZone.Click += new System.EventHandler(this.buttonTimeZone_Click);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // panelFooterBawah
      // 
      this.panelFooterBawah.Controls.Add(this.labelTimeZone);
      this.panelFooterBawah.Controls.Add(this.lblSelectedLetter);
      this.panelFooterBawah.Controls.Add(this.lblSelectedSender);
      this.panelFooterBawah.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panelFooterBawah.Location = new System.Drawing.Point(0, 478);
      this.panelFooterBawah.Name = "panelFooterBawah";
      this.panelFooterBawah.Size = new System.Drawing.Size(909, 21);
      this.panelFooterBawah.TabIndex = 5;
      // 
      // labelTimeZone
      // 
      this.labelTimeZone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.labelTimeZone.AutoSize = true;
      this.labelTimeZone.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTimeZone.Location = new System.Drawing.Point(586, 3);
      this.labelTimeZone.Name = "labelTimeZone";
      this.labelTimeZone.Size = new System.Drawing.Size(60, 13);
      this.labelTimeZone.TabIndex = 3;
      this.labelTimeZone.Text = "TimeZone:";
      // 
      // lblSelectedLetter
      // 
      this.lblSelectedLetter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblSelectedLetter.AutoSize = true;
      this.lblSelectedLetter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblSelectedLetter.Location = new System.Drawing.Point(106, 4);
      this.lblSelectedLetter.Name = "lblSelectedLetter";
      this.lblSelectedLetter.Size = new System.Drawing.Size(60, 13);
      this.lblSelectedLetter.TabIndex = 2;
      this.lblSelectedLetter.Text = "Letter No: ";
      // 
      // lblSelectedSender
      // 
      this.lblSelectedSender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblSelectedSender.AutoSize = true;
      this.lblSelectedSender.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblSelectedSender.Location = new System.Drawing.Point(3, 3);
      this.lblSelectedSender.Name = "lblSelectedSender";
      this.lblSelectedSender.Size = new System.Drawing.Size(67, 13);
      this.lblSelectedSender.TabIndex = 1;
      this.lblSelectedSender.Text = "Sender No: ";
      // 
      // FormDashboard
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(909, 499);
      this.Controls.Add(this.panelBody);
      this.Controls.Add(this.panelFooter);
      this.Controls.Add(this.panelKiri);
      this.Controls.Add(this.panelFooterBawah);
      this.Controls.Add(this.panelButton);
      this.Controls.Add(this.panelHeader);
      this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FormDashboard";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "AnonSender";
      this.Load += new System.EventHandler(this.FormDashboard_Load);
      this.panelHeader.ResumeLayout(false);
      this.panelKiri.ResumeLayout(false);
      this.panelHeaderKiri.ResumeLayout(false);
      this.panelHeaderKiri.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataSender)).EndInit();
      this.panelFooter.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataLetter)).EndInit();
      this.panelHeaderFooter.ResumeLayout(false);
      this.panelHeaderFooter.PerformLayout();
      this.panelBody.ResumeLayout(false);
      this.panelHeaderBody.ResumeLayout(false);
      this.panelHeaderBody.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataMailist)).EndInit();
      this.panelButton.ResumeLayout(false);
      this.panelFooterBawah.ResumeLayout(false);
      this.panelFooterBawah.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonRestoreDown;
        private System.Windows.Forms.Panel panelKiri;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.DataGridView dataSender;
        private System.Windows.Forms.DataGridView dataMailist;
        private System.Windows.Forms.Panel panelHeaderKiri;
        private System.Windows.Forms.Label labelSenderHeader;
        private System.Windows.Forms.Panel panelHeaderBody;
        private System.Windows.Forms.Label LabelTotalMailist;
        private System.Windows.Forms.Panel panelHeaderFooter;
        private System.Windows.Forms.Label labelTotalLetter;
        private System.Windows.Forms.DataGridView dataLetter;
        private System.Windows.Forms.Label labelGaris;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button buttonImportMailist;
        private System.Windows.Forms.Label labelGarisBawah;
        private System.Windows.Forms.Button buttonLetter;
        private System.Windows.Forms.Button buttonSmtpSettings;
        private System.Windows.Forms.Button buttonProxySetting;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panelFooterBawah;
        private System.Windows.Forms.LinkLabel labelClearMailist;
        private System.Windows.Forms.Label lblSelectedSender;
        private System.Windows.Forms.Label lblSelectedLetter;
        private System.Windows.Forms.Label labelTimeZone;
        private System.Windows.Forms.Button buttonTimeZone;
    }
}

