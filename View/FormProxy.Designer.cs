namespace AnonSender.View
{
  partial class FormProxy
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProxy));
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.buttonClose = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.txtPort = new System.Windows.Forms.TextBox();
      this.txtHost = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.chkProxy = new System.Windows.Forms.CheckBox();
      this.chkSocks5 = new System.Windows.Forms.RadioButton();
      this.chkHttp = new System.Windows.Forms.RadioButton();
      this.panelProxy = new System.Windows.Forms.Panel();
      this.panelCredentials = new System.Windows.Forms.Panel();
      this.txtUsername = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.chkCredentials = new System.Windows.Forms.CheckBox();
      this.panel1.SuspendLayout();
      this.panelProxy.SuspendLayout();
      this.panelCredentials.SuspendLayout();
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
      this.panel1.TabIndex = 1;
      this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 4);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(120, 21);
      this.label1.TabIndex = 3;
      this.label1.Text = "Proxy Settings";
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
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(212, 31);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(28, 13);
      this.label4.TabIndex = 10;
      this.label4.Text = "Port";
      // 
      // txtPort
      // 
      this.txtPort.Location = new System.Drawing.Point(215, 47);
      this.txtPort.Name = "txtPort";
      this.txtPort.Size = new System.Drawing.Size(80, 22);
      this.txtPort.TabIndex = 9;
      // 
      // txtHost
      // 
      this.txtHost.Location = new System.Drawing.Point(7, 47);
      this.txtHost.Name = "txtHost";
      this.txtHost.Size = new System.Drawing.Size(202, 22);
      this.txtHost.TabIndex = 7;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(4, 31);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(72, 13);
      this.label2.TabIndex = 8;
      this.label2.Text = "Host / Server";
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.FlatAppearance.BorderSize = 0;
      this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancel.Image = global::AnonSender.Properties.Resources.btn_close;
      this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnCancel.Location = new System.Drawing.Point(207, 268);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(100, 47);
      this.btnCancel.TabIndex = 12;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnSave
      // 
      this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSave.FlatAppearance.BorderSize = 0;
      this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSave.Image = global::AnonSender.Properties.Resources.save;
      this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSave.Location = new System.Drawing.Point(19, 268);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(100, 47);
      this.btnSave.TabIndex = 11;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // chkProxy
      // 
      this.chkProxy.AutoSize = true;
      this.chkProxy.Location = new System.Drawing.Point(16, 41);
      this.chkProxy.Name = "chkProxy";
      this.chkProxy.Size = new System.Drawing.Size(75, 17);
      this.chkProxy.TabIndex = 13;
      this.chkProxy.Text = "Use Proxy";
      this.chkProxy.UseVisualStyleBackColor = true;
      this.chkProxy.CheckedChanged += new System.EventHandler(this.chkProxy_CheckedChanged);
      // 
      // chkSocks5
      // 
      this.chkSocks5.AutoSize = true;
      this.chkSocks5.Location = new System.Drawing.Point(7, 3);
      this.chkSocks5.Name = "chkSocks5";
      this.chkSocks5.Size = new System.Drawing.Size(68, 17);
      this.chkSocks5.TabIndex = 14;
      this.chkSocks5.TabStop = true;
      this.chkSocks5.Text = "SOCKS 5";
      this.chkSocks5.UseVisualStyleBackColor = true;
      // 
      // chkHttp
      // 
      this.chkHttp.AutoSize = true;
      this.chkHttp.Location = new System.Drawing.Point(95, 3);
      this.chkHttp.Name = "chkHttp";
      this.chkHttp.Size = new System.Drawing.Size(51, 17);
      this.chkHttp.TabIndex = 15;
      this.chkHttp.TabStop = true;
      this.chkHttp.Text = "HTTP";
      this.chkHttp.UseVisualStyleBackColor = true;
      // 
      // panelProxy
      // 
      this.panelProxy.Controls.Add(this.chkCredentials);
      this.panelProxy.Controls.Add(this.panelCredentials);
      this.panelProxy.Controls.Add(this.chkHttp);
      this.panelProxy.Controls.Add(this.chkSocks5);
      this.panelProxy.Controls.Add(this.label4);
      this.panelProxy.Controls.Add(this.txtPort);
      this.panelProxy.Controls.Add(this.txtHost);
      this.panelProxy.Controls.Add(this.label2);
      this.panelProxy.Location = new System.Drawing.Point(9, 63);
      this.panelProxy.Name = "panelProxy";
      this.panelProxy.Size = new System.Drawing.Size(306, 199);
      this.panelProxy.TabIndex = 16;
      // 
      // panelCredentials
      // 
      this.panelCredentials.Controls.Add(this.txtPassword);
      this.panelCredentials.Controls.Add(this.label5);
      this.panelCredentials.Controls.Add(this.txtUsername);
      this.panelCredentials.Controls.Add(this.label3);
      this.panelCredentials.Location = new System.Drawing.Point(3, 94);
      this.panelCredentials.Name = "panelCredentials";
      this.panelCredentials.Size = new System.Drawing.Size(300, 102);
      this.panelCredentials.TabIndex = 16;
      // 
      // txtUsername
      // 
      this.txtUsername.Location = new System.Drawing.Point(4, 23);
      this.txtUsername.Name = "txtUsername";
      this.txtUsername.Size = new System.Drawing.Size(288, 22);
      this.txtUsername.TabIndex = 15;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(1, 7);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(58, 13);
      this.label3.TabIndex = 16;
      this.label3.Text = "Username";
      // 
      // txtPassword
      // 
      this.txtPassword.Location = new System.Drawing.Point(4, 72);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new System.Drawing.Size(288, 22);
      this.txtPassword.TabIndex = 17;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(1, 56);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(56, 13);
      this.label5.TabIndex = 18;
      this.label5.Text = "Password";
      // 
      // chkCredentials
      // 
      this.chkCredentials.AutoSize = true;
      this.chkCredentials.Location = new System.Drawing.Point(7, 75);
      this.chkCredentials.Name = "chkCredentials";
      this.chkCredentials.Size = new System.Drawing.Size(84, 17);
      this.chkCredentials.TabIndex = 18;
      this.chkCredentials.Text = "Credentials";
      this.chkCredentials.UseVisualStyleBackColor = true;
      this.chkCredentials.CheckedChanged += new System.EventHandler(this.chkCredentials_CheckedChanged_1);
      // 
      // FormProxy
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(327, 327);
      this.Controls.Add(this.panelProxy);
      this.Controls.Add(this.chkProxy);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.panel1);
      this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FormProxy";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FormProxy";
      this.Load += new System.EventHandler(this.FormProxy_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panelProxy.ResumeLayout(false);
      this.panelProxy.PerformLayout();
      this.panelCredentials.ResumeLayout(false);
      this.panelCredentials.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkProxy;
        private System.Windows.Forms.RadioButton chkSocks5;
        private System.Windows.Forms.RadioButton chkHttp;
        private System.Windows.Forms.Panel panelProxy;
        private System.Windows.Forms.Panel panelCredentials;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkCredentials;
    }
}