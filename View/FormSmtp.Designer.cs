namespace AnonSender.View
{
  partial class FormSmtp
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSmtp));
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.buttonClose = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.txtHost = new System.Windows.Forms.TextBox();
      this.txtUsername = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtPort = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtPass = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.chkSsl = new System.Windows.Forms.CheckBox();
      this.labelGarisBawah = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.txtSenderName = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.txtSenderEmail = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.chkCredentials = new System.Windows.Forms.CheckBox();
      this.txtId = new System.Windows.Forms.Label();
      this.txtSetting = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.buttonClose);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(327, 32);
      this.panel1.TabIndex = 0;
      this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 4);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(119, 21);
      this.label1.TabIndex = 3;
      this.label1.Text = "SMTP Settings";
      // 
      // buttonClose
      // 
      this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
      this.buttonClose.FlatAppearance.BorderSize = 0;
      this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonClose.Image = global::AnonSender.Properties.Resources.close;
      this.buttonClose.Location = new System.Drawing.Point(277, 0);
      this.buttonClose.Name = "buttonClose";
      this.buttonClose.Size = new System.Drawing.Size(50, 32);
      this.buttonClose.TabIndex = 1;
      this.buttonClose.UseVisualStyleBackColor = true;
      this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 91);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(72, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Host / Server";
      // 
      // txtHost
      // 
      this.txtHost.Location = new System.Drawing.Point(16, 107);
      this.txtHost.Name = "txtHost";
      this.txtHost.Size = new System.Drawing.Size(202, 22);
      this.txtHost.TabIndex = 2;
      // 
      // txtUsername
      // 
      this.txtUsername.Location = new System.Drawing.Point(16, 174);
      this.txtUsername.Name = "txtUsername";
      this.txtUsername.Size = new System.Drawing.Size(288, 22);
      this.txtUsername.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(13, 158);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(58, 13);
      this.label3.TabIndex = 3;
      this.label3.Text = "Username";
      // 
      // txtPort
      // 
      this.txtPort.Location = new System.Drawing.Point(224, 107);
      this.txtPort.Name = "txtPort";
      this.txtPort.Size = new System.Drawing.Size(80, 22);
      this.txtPort.TabIndex = 3;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(221, 91);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(28, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "Port";
      // 
      // txtPass
      // 
      this.txtPass.Location = new System.Drawing.Point(16, 220);
      this.txtPass.Name = "txtPass";
      this.txtPass.PasswordChar = '*';
      this.txtPass.Size = new System.Drawing.Size(288, 22);
      this.txtPass.TabIndex = 6;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(13, 204);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(56, 13);
      this.label5.TabIndex = 7;
      this.label5.Text = "Password";
      // 
      // chkSsl
      // 
      this.chkSsl.AutoSize = true;
      this.chkSsl.Location = new System.Drawing.Point(16, 348);
      this.chkSsl.Name = "chkSsl";
      this.chkSsl.Size = new System.Drawing.Size(106, 17);
      this.chkSsl.TabIndex = 9;
      this.chkSsl.Text = "SSL Connection";
      this.chkSsl.UseVisualStyleBackColor = true;
      // 
      // labelGarisBawah
      // 
      this.labelGarisBawah.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.labelGarisBawah.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.labelGarisBawah.Location = new System.Drawing.Point(0, 30);
      this.labelGarisBawah.Name = "labelGarisBawah";
      this.labelGarisBawah.Size = new System.Drawing.Size(327, 2);
      this.labelGarisBawah.TabIndex = 10;
      // 
      // btnSave
      // 
      this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSave.FlatAppearance.BorderSize = 0;
      this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSave.Image = global::AnonSender.Properties.Resources.save;
      this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSave.Location = new System.Drawing.Point(16, 373);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(100, 47);
      this.btnSave.TabIndex = 10;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.FlatAppearance.BorderSize = 0;
      this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancel.Image = global::AnonSender.Properties.Resources.btn_close;
      this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnCancel.Location = new System.Drawing.Point(204, 373);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(100, 47);
      this.btnCancel.TabIndex = 11;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // txtSenderName
      // 
      this.txtSenderName.Location = new System.Drawing.Point(16, 265);
      this.txtSenderName.Name = "txtSenderName";
      this.txtSenderName.Size = new System.Drawing.Size(288, 22);
      this.txtSenderName.TabIndex = 7;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(13, 249);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(75, 13);
      this.label6.TabIndex = 12;
      this.label6.Text = "Sender Name";
      // 
      // txtSenderEmail
      // 
      this.txtSenderEmail.Location = new System.Drawing.Point(16, 314);
      this.txtSenderEmail.Name = "txtSenderEmail";
      this.txtSenderEmail.Size = new System.Drawing.Size(288, 22);
      this.txtSenderEmail.TabIndex = 8;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(13, 298);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(73, 13);
      this.label7.TabIndex = 14;
      this.label7.Text = "Sender Email";
      // 
      // chkCredentials
      // 
      this.chkCredentials.AutoSize = true;
      this.chkCredentials.Location = new System.Drawing.Point(16, 135);
      this.chkCredentials.Name = "chkCredentials";
      this.chkCredentials.Size = new System.Drawing.Size(84, 17);
      this.chkCredentials.TabIndex = 4;
      this.chkCredentials.Text = "Credentials";
      this.chkCredentials.UseVisualStyleBackColor = true;
      this.chkCredentials.CheckedChanged += new System.EventHandler(this.chkCredentials_CheckedChanged);
      // 
      // txtId
      // 
      this.txtId.AutoSize = true;
      this.txtId.Location = new System.Drawing.Point(151, 158);
      this.txtId.Name = "txtId";
      this.txtId.Size = new System.Drawing.Size(17, 13);
      this.txtId.TabIndex = 16;
      this.txtId.Text = "Id";
      this.txtId.Visible = false;
      // 
      // txtSetting
      // 
      this.txtSetting.Location = new System.Drawing.Point(16, 56);
      this.txtSetting.Name = "txtSetting";
      this.txtSetting.Size = new System.Drawing.Size(288, 22);
      this.txtSetting.TabIndex = 1;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(13, 40);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(76, 13);
      this.label8.TabIndex = 18;
      this.label8.Text = "Setting Name";
      // 
      // FormSmtp
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.ClientSize = new System.Drawing.Size(327, 432);
      this.Controls.Add(this.txtSetting);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.txtId);
      this.Controls.Add(this.chkCredentials);
      this.Controls.Add(this.txtSenderEmail);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.txtSenderName);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.labelGarisBawah);
      this.Controls.Add(this.chkSsl);
      this.Controls.Add(this.txtPass);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtPort);
      this.Controls.Add(this.txtUsername);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtHost);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.panel1);
      this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FormSmtp";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FormSmtp";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSmtp_FormClosing);
      this.Load += new System.EventHandler(this.FormSmtp_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkSsl;
        private System.Windows.Forms.Label labelGarisBawah;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtSenderName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSenderEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkCredentials;
        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.TextBox txtSetting;
        private System.Windows.Forms.Label label8;
    }
}