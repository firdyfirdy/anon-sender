namespace AnonSender.View
{
  partial class FormLetter
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLetter));
      this.panel1 = new System.Windows.Forms.Panel();
      this.buttonRestoreDown = new System.Windows.Forms.Button();
      this.labelHeader = new System.Windows.Forms.Label();
      this.buttonClose = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.txtSubject = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtBody = new System.Windows.Forms.RichTextBox();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.dataAttachment = new System.Windows.Forms.DataGridView();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.openFile = new System.Windows.Forms.OpenFileDialog();
      this.chkIsHtml = new System.Windows.Forms.CheckBox();
      this.txtId = new System.Windows.Forms.Label();
      this.panelAttachment = new System.Windows.Forms.Panel();
      this.htmlBody = new System.Windows.Forms.WebBrowser();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataAttachment)).BeginInit();
      this.panelAttachment.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
      this.panel1.Controls.Add(this.buttonRestoreDown);
      this.panel1.Controls.Add(this.labelHeader);
      this.panel1.Controls.Add(this.buttonClose);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(804, 32);
      this.panel1.TabIndex = 1;
      this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
      // 
      // buttonRestoreDown
      // 
      this.buttonRestoreDown.Dock = System.Windows.Forms.DockStyle.Right;
      this.buttonRestoreDown.FlatAppearance.BorderSize = 0;
      this.buttonRestoreDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonRestoreDown.Image = global::AnonSender.Properties.Resources.restore;
      this.buttonRestoreDown.Location = new System.Drawing.Point(704, 0);
      this.buttonRestoreDown.Name = "buttonRestoreDown";
      this.buttonRestoreDown.Size = new System.Drawing.Size(50, 32);
      this.buttonRestoreDown.TabIndex = 4;
      this.buttonRestoreDown.UseVisualStyleBackColor = true;
      this.buttonRestoreDown.Click += new System.EventHandler(this.buttonRestoreDown_Click);
      // 
      // labelHeader
      // 
      this.labelHeader.AutoSize = true;
      this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelHeader.Location = new System.Drawing.Point(12, 4);
      this.labelHeader.Name = "labelHeader";
      this.labelHeader.Size = new System.Drawing.Size(120, 21);
      this.labelHeader.TabIndex = 3;
      this.labelHeader.Text = "Letter Settings";
      // 
      // buttonClose
      // 
      this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
      this.buttonClose.FlatAppearance.BorderSize = 0;
      this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonClose.Image = global::AnonSender.Properties.Resources.close;
      this.buttonClose.Location = new System.Drawing.Point(754, 0);
      this.buttonClose.Name = "buttonClose";
      this.buttonClose.Size = new System.Drawing.Size(50, 32);
      this.buttonClose.TabIndex = 1;
      this.buttonClose.UseVisualStyleBackColor = true;
      this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 45);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(45, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Subject";
      // 
      // txtSubject
      // 
      this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtSubject.Location = new System.Drawing.Point(16, 61);
      this.txtSubject.Name = "txtSubject";
      this.txtSubject.Size = new System.Drawing.Size(772, 22);
      this.txtSubject.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(13, 91);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(66, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Text / HTML";
      // 
      // txtBody
      // 
      this.txtBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtBody.Location = new System.Drawing.Point(16, 107);
      this.txtBody.Name = "txtBody";
      this.txtBody.Size = new System.Drawing.Size(772, 275);
      this.txtBody.TabIndex = 5;
      this.txtBody.Text = "";
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.FlatAppearance.BorderSize = 0;
      this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancel.Image = global::AnonSender.Properties.Resources.btn_close;
      this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnCancel.Location = new System.Drawing.Point(679, 499);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(108, 47);
      this.btnCancel.TabIndex = 9;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnSave
      // 
      this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSave.FlatAppearance.BorderSize = 0;
      this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSave.Image = global::AnonSender.Properties.Resources.save;
      this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSave.Location = new System.Drawing.Point(573, 499);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(100, 47);
      this.btnSave.TabIndex = 8;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // label4
      // 
      this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(5, 6);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(66, 13);
      this.label4.TabIndex = 10;
      this.label4.Text = "Attachment";
      // 
      // dataAttachment
      // 
      this.dataAttachment.AllowUserToAddRows = false;
      this.dataAttachment.AllowUserToDeleteRows = false;
      this.dataAttachment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataAttachment.BackgroundColor = System.Drawing.Color.White;
      this.dataAttachment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataAttachment.Location = new System.Drawing.Point(8, 22);
      this.dataAttachment.Name = "dataAttachment";
      this.dataAttachment.Size = new System.Drawing.Size(446, 112);
      this.dataAttachment.TabIndex = 11;
      // 
      // btnDelete
      // 
      this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnDelete.Location = new System.Drawing.Point(460, 51);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(64, 23);
      this.btnDelete.TabIndex = 12;
      this.btnDelete.Text = "Delete";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAdd.Location = new System.Drawing.Point(460, 22);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(64, 23);
      this.btnAdd.TabIndex = 13;
      this.btnAdd.Text = "Add";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // openFile
      // 
      this.openFile.FileName = "openFileDialog1";
      // 
      // chkIsHtml
      // 
      this.chkIsHtml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.chkIsHtml.AutoSize = true;
      this.chkIsHtml.Location = new System.Drawing.Point(716, 388);
      this.chkIsHtml.Name = "chkIsHtml";
      this.chkIsHtml.Size = new System.Drawing.Size(71, 17);
      this.chkIsHtml.TabIndex = 14;
      this.chkIsHtml.Text = "Is HTML?";
      this.chkIsHtml.UseVisualStyleBackColor = true;
      // 
      // txtId
      // 
      this.txtId.AutoSize = true;
      this.txtId.Location = new System.Drawing.Point(433, 45);
      this.txtId.Name = "txtId";
      this.txtId.Size = new System.Drawing.Size(18, 13);
      this.txtId.TabIndex = 15;
      this.txtId.Text = "ID";
      // 
      // panelAttachment
      // 
      this.panelAttachment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panelAttachment.Controls.Add(this.btnAdd);
      this.panelAttachment.Controls.Add(this.btnDelete);
      this.panelAttachment.Controls.Add(this.dataAttachment);
      this.panelAttachment.Controls.Add(this.label4);
      this.panelAttachment.Location = new System.Drawing.Point(8, 388);
      this.panelAttachment.Name = "panelAttachment";
      this.panelAttachment.Size = new System.Drawing.Size(535, 146);
      this.panelAttachment.TabIndex = 16;
      // 
      // htmlBody
      // 
      this.htmlBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.htmlBody.Location = new System.Drawing.Point(16, 107);
      this.htmlBody.MinimumSize = new System.Drawing.Size(20, 20);
      this.htmlBody.Name = "htmlBody";
      this.htmlBody.Size = new System.Drawing.Size(772, 275);
      this.htmlBody.TabIndex = 17;
      this.htmlBody.Visible = false;
      // 
      // FormLetter
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.ClientSize = new System.Drawing.Size(804, 558);
      this.Controls.Add(this.panelAttachment);
      this.Controls.Add(this.txtId);
      this.Controls.Add(this.chkIsHtml);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.txtBody);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtSubject);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.htmlBody);
      this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FormLetter";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FormLetter";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLetter_FormClosing);
      this.Load += new System.EventHandler(this.FormLetter_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataAttachment)).EndInit();
      this.panelAttachment.ResumeLayout(false);
      this.panelAttachment.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtBody;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataAttachment;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button buttonRestoreDown;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.CheckBox chkIsHtml;
        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.Panel panelAttachment;
        private System.Windows.Forms.WebBrowser htmlBody;
    }
}