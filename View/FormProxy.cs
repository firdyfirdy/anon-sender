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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnonSender.View
{
  public partial class FormProxy : Form
  {
    Proxy proxy = new Proxy();
    public FormProxy()
    {
      InitializeComponent();
    }

    private void chkProxy_CheckedChanged(object sender, EventArgs e)
    {
      if (!chkProxy.Checked)
      {
        panelProxy.Enabled = false;
        //txtHost.ReadOnly = true;
        //txtPort.ReadOnly = true;
      }
      else
      {
        panelProxy.Enabled = true;
        /*txtHost.ReadOnly = false;
        txtPort.ReadOnly = false;*/
      }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      if (String.IsNullOrEmpty(txtPort.Text) || String.IsNullOrEmpty(txtHost.Text))
      {
        MessageBox.Show("Error: Host/Port can't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      
      ProxyData proxyData = new ProxyData();
      proxyData.host = txtHost.Text;
      proxyData.port = Convert.ToInt32(txtPort.Text);
      proxyData.isActive = chkProxy.Checked;
      if (chkCredentials.Checked)
      {
        proxyData.username = txtUsername.Text;
        proxyData.password = txtPassword.Text;
      }
      else
      {
        proxyData.username = "";
        proxyData.password = "";
      }
      proxyData.isSocks5 = (chkSocks5.Checked) ? true : false;

      bool statusSave = proxy.SaveProxy(proxyData);
      if (statusSave)
      {
        this.Close();
      }
      else
      {
        MessageBox.Show("Failed save proxy", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void buttonClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void FormProxy_Load(object sender, EventArgs e)
    {
      ProxyData proxyData = proxy.ReadProxy();
      if (proxyData.isActive)
      {
        chkProxy.Checked = true;
        panelProxy.Enabled = true;
      }
      else
      {
        chkProxy.Checked = false;
        panelProxy.Enabled = false;
      }
      chkCredentials.Checked = (String.IsNullOrEmpty(proxyData.username)) ? false : true;
      panelCredentials.Enabled = chkCredentials.Checked;
      chkSocks5.Checked = proxyData.isSocks5;
      chkHttp.Checked = !proxyData.isSocks5;
      txtHost.Text = proxyData.host;
      txtPort.Text = proxyData.port.ToString();
      txtUsername.Text = proxyData.username;
      txtPassword.Text = proxyData.password;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        Drag.ReleaseCapture();
        Drag.SendMessage(Handle, Drag.WM_NCLBUTTONDOWN, Drag.HT_CAPTION, 0);
      }
    }

    private void chkCredentials_CheckedChanged_1(object sender, EventArgs e)
    {
      if (chkCredentials.Checked)
      {
        panelCredentials.Enabled = true;
      }
      else
      {
        panelCredentials.Enabled = false;
      }
    }
  }
}