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
  public partial class FormTimeZone : Form
  {
    FormDashboard _owner;
    private string selectedTimeZone = "";
    public FormTimeZone(FormDashboard owner)
    {
      _owner = owner;
      InitializeComponent();
      this.FormClosing += new FormClosingEventHandler(this.FormTimeZone_FormClosing);
    }

    private void FormTimeZone_FormClosing(object sender, FormClosingEventArgs e)
    {
      _owner.ReloadTimeZone();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      Properties.Settings.Default["TimeZone"] = selectedTimeZone;
      Properties.Settings.Default.Save();
      this.Close();
    }

    private void buttonClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void FormTimeZone_Load(object sender, EventArgs e)
    {
      cmbTimeZone.DisplayMember = "Text";
      cmbTimeZone.ValueMember = "Value";
      foreach (TimeZoneInfo z in TimeZoneInfo.GetSystemTimeZones())
      {
        cmbTimeZone.Items.Add(new { Text = z.DisplayName, Value = z.Id });
      }
    }

    private void cmbTimeZone_SelectedIndexChanged(object sender, EventArgs e)
    {
      selectedTimeZone = (cmbTimeZone.SelectedItem as dynamic).Value;
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