using AnonSender.Controller;
using AnonSender.Helper;
using AnonSender.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnonSender.View
{
  public partial class FormSmtp : Form
  {
    Smtp smtp = new Smtp();
    FormDashboard _owner;
    public FormSmtp(FormDashboard owner)
    {
      _owner = owner;
      InitializeComponent();
      this.FormClosing += new FormClosingEventHandler(this.FormSmtp_FormClosing);
    }

    private void FormSmtp_FormClosing(object sender, FormClosingEventArgs e)
    {
      _owner.reloadSmtpGrid();
    }

    private void buttonClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void FormSmtp_Load(object sender, EventArgs e)
    {
      this.ActiveControl = txtSetting;
      if (FormDashboard.selectedSender != null)
      {
        formEdit();
      }
      else
      {
        formAdd();
      }
    }

    private void formAdd()
    {
      txtUsername.ReadOnly = true;
      txtPass.ReadOnly = true;
      txtHost.Text = "";
      txtPass.Text = "";
      txtPort.Text = "";
      txtUsername.Text = "";
      txtSenderName.Text = "";
      txtSenderEmail.Text = "";
      chkSsl.Checked = false;
    }

    private void formEdit()
    {
      string username = FormDashboard.selectedSender;
      SmtpData smtpData = smtp.getSmtp(username);
      txtHost.Text = smtpData.host;
      txtPass.Text = smtpData.password;
      txtPort.Text = smtpData.port.ToString();
      txtUsername.Text = smtpData.username;
      txtSenderEmail.Text = smtpData.senderEmail;
      txtSenderName.Text = smtpData.senderName;
      chkSsl.Checked = smtpData.isSecure;
      txtId.Text = smtpData.id;
      txtSetting.Text = smtpData.settingName;
      chkCredentials.Checked = (!String.IsNullOrEmpty(smtpData.username)) ? true : false;
      if (!chkCredentials.Checked)
      {
        txtUsername.ReadOnly = true;
        txtPass.ReadOnly = true;
      }

      btnSave.Text = "Update";
    }

    private async void btnSave_Click(object sender, EventArgs e)
    {
      var regex = new Regex(@"^-*[0-9,\.]+$");

      if (String.IsNullOrEmpty(txtHost.Text) || String.IsNullOrEmpty(txtPort.Text) || String.IsNullOrEmpty(txtSetting.Text))
      {
        MessageBox.Show("Please, Check Your Field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      if (!regex.IsMatch(txtPort.Text))
      {
        MessageBox.Show("Port is numeric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      SmtpData data = new SmtpData();

      data.id = (btnSave.Text == "Save") ? Helpers.RandomString(10) : txtId.Text;
      data.host = txtHost.Text;
      data.port = Convert.ToInt32(txtPort.Text);
      if (chkCredentials.Checked)
      {
        data.username = txtUsername.Text;
        data.password = txtPass.Text;
      }
      else
      {
        data.username = null;
        data.password = null;
      }
      data.settingName = txtSetting.Text;
      data.senderName = txtSenderName.Text;
      data.senderEmail = txtSenderEmail.Text;
      data.isSecure = (chkSsl.Checked) ? true : false;

      btnSave.Enabled = false;
      bool checkConnect;
      Proxy proxy = new Proxy();
      ProxyData proxyData = proxy.ReadProxy();
      if (proxyData.isActive)
      {
        checkConnect = await smtp.DoConnect(data, proxyData);
      }
      else
      {
        checkConnect = await smtp.DoConnect(data);
      }

      if (checkConnect)
      {
        smtp.SaveSmtp(data);
        //MessageBox.Show("Success Connect to SMTP.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
      }
      else
      {
        MessageBox.Show("Failed Connect to SMTP.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      btnSave.Enabled = true;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void chkCredentials_CheckedChanged(object sender, EventArgs e)
    {
      if (chkCredentials.Checked)
      {
        txtUsername.ReadOnly = false;
        txtPass.ReadOnly = false;
      }
      else
      {
        txtUsername.ReadOnly = true;
        txtPass.ReadOnly = true;
      }
    }

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        Drag.ReleaseCapture();
        Drag.SendMessage(Handle, Drag.WM_NCLBUTTONDOWN, Drag.HT_CAPTION, 0);
      }
    }
  }
}
