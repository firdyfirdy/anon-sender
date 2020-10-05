using AnonSender.Controller;
using AnonSender.Helper;
using AnonSender.Model;
using AnonSender.View;
using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnonSender
{
  public partial class FormDashboard : Form
  {
    Email email = new Email(new SmtpClient());
    Helpers helper = new Helpers();
    CancellationTokenSource cts;
    Smtp smtp = new Smtp();
    Letter letter = new Letter();
    Replacer replacer = new Replacer();

    private int state = 0;
    private bool finish = false;
    public static string selectedSender = null;
    public static string selectedLetter = null;
    public static bool isPreview = false;
    public FormDashboard()
    {
      InitializeComponent();
      labelGarisBawah.BringToFront();
      labelGaris.BringToFront();
    }

    private void buttonClose_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void buttonMinimize_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Minimized;
    }

    private void buttonRestoreDown_Click(object sender, EventArgs e)
    {
      WindowState = WindowState == FormWindowState.Maximized
                         ? FormWindowState.Normal
                         : FormWindowState.Maximized;
    }

    private void FormDashboard_Load(object sender, EventArgs e)
    {
      /* Letter */
      ReloadLetterGrid();
      /* Letter */

      email.SettingDataGrid(dataMailist);

      /* Load Data Grid */
      smtp.SettingDataGrid(dataSender);

      /* Load Smtp */
      reloadSmtpGrid();

      /* Set Default TimeZone*/
      string timeZone = Properties.Settings.Default["TimeZone"].ToString();
      if (String.IsNullOrEmpty(timeZone))
      {
        Properties.Settings.Default["TimeZone"] = "Pacific Standard Time";
        Properties.Settings.Default.Save();
      }
      ReloadTimeZone();
    }

    public void ReloadTimeZone()
    {
      labelTimeZone.Text = "Time Zone: " + Properties.Settings.Default["TimeZone"].ToString();
    }

    public void ReloadLetterGrid()
    {
      /* Load Letter */
      dataLetter.DataSource = null;
      dataLetter.Rows.Clear();
      dataLetter.Refresh();

      letter.SettingLetterDashboard(dataLetter);
      letter.StoreLetterToDashboard(dataLetter);
      labelTotalLetter.Text = $"Letter ({dataLetter.Rows.Count})";

    }

    public void reloadSmtpGrid()
    {
      /* Load Smtp */
      dataSender.DataSource = null;
      dataSender.Rows.Clear();
      dataSender.Refresh();
      smtp.StoreSmtpToGrid(dataSender);
      labelSenderHeader.Text = $"Sender Email ({dataSender.Rows.Count})";
    }

    private void buttonImportMailist_Click(object sender, EventArgs e)
    {
      string file = "";
      openFileDialog1.Filter = "Text Files|*.txt";
      openFileDialog1.Title = "Please select some file.";
      openFileDialog1.FileName = file;
      DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
      if (result == DialogResult.OK) // Test result.
      {
        file = openFileDialog1.FileName;
        try
        {
          email.StoreEmailToDataGrid(file, dataMailist);
          LabelTotalMailist.Text = $"Mailist ({email.totalRows})";
        }
        catch (IOException)
        {
          MessageBox.Show(result.ToString());
        }
      }
    }

    private async void buttonStart_Click(object sender, EventArgs e)
    {
      if (dataSender.Rows.Count <= 0)
      {
        MessageBox.Show("Error: Please add new SMTP!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      if (selectedSender == null)
      {
        MessageBox.Show("Error: Please select sender first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      if (selectedLetter == null)
      {
        MessageBox.Show("Error: Please select Letter first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      if (dataMailist.Rows.Count <= 0)
      {
        MessageBox.Show("Error: Mailist is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      dataSender.Enabled = false;
      dataLetter.Enabled = false;
      dataMailist.ReadOnly = true;

      if (buttonStart.Text == "Start")
      {
        buttonStart.Text = "Pause";
        if (finish == true)
        {
          clearStatusGrid();
        }
        finish = false;
        SmtpData smtpData = smtp.getSmtp(selectedSender);

        Proxy proxy = new Proxy();
        ProxyData proxyData = proxy.ReadProxy();
        if (proxyData.isActive)
        {
          email.DoConnect(smtpData, proxyData);
        }
        else
        { 
          email.DoConnect(smtpData);
        }

        VictimData victimData = new VictimData();


        try
        {
          cts = new CancellationTokenSource();
          CancellationToken token = cts.Token;
          int i;
          state = (state == 0) ? 0 : state + 1;

          string replaceBody, replaceSubject, replaceEmail, replaceName;
          for (i = state; i < dataMailist.Rows.Count; i++)
          {

            SmtpData senderData = new SmtpData();
            senderData.senderEmail = smtpData.senderEmail;
            senderData.senderName = smtpData.senderName;

            LetterData letterData = new LetterData();
            letterData = letter.ReadLetterFile(Path.Combine(Helpers.LetterPath, selectedLetter + ".dat"));

            token.ThrowIfCancellationRequested();
            victimData.email = dataMailist.Rows[i].Cells[1].Value.ToString();

            /* Replace Data */
            replaceBody = replacer.DoReplace(letterData.body, victimData.email);
            replaceSubject = replacer.DoReplace(letterData.subject, victimData.email);
            replaceEmail = replacer.DoReplace(senderData.senderEmail, victimData.email);
            replaceName = replacer.DoReplace(senderData.senderName, victimData.email);

            letterData.body = Uri.UnescapeDataString(replaceBody);
            letterData.subject = replaceSubject;
            senderData.senderEmail = replaceEmail;
            senderData.senderName = replaceName;

            ResponseData responseData = await email.SendEmail(victimData, senderData, letterData);
            dataMailist.Rows[i].Cells[2].Value = (responseData.status) ? "Success" : "Failed";
            dataMailist.Rows[i].Cells[3].Value = responseData.messages;
            state = i;
          }
          state = 0;
          email.DoDisconnect();
          buttonStart.Text = "Start";
          finish = true;
          MessageBox.Show("Sent Email Success!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

          dataSender.Enabled = true;
          dataLetter.Enabled = true;
          dataMailist.ReadOnly = false;
          
        }
        catch (OperationCanceledException)
        {
          buttonStart.Text = "Start";
          buttonStart.Enabled = true;
          email.DoDisconnect();

          dataSender.Enabled = true;
          dataLetter.Enabled = true;
          dataMailist.ReadOnly = false;
        }

      }
      else
      {
        buttonStart.Enabled = false;
        cts.Cancel();
      }
    }

    private void buttonSmtpSettings_Click(object sender, EventArgs e)
    {
      selectedSender = null;
      FormSmtp formSmtp = new FormSmtp(this);
      formSmtp.ShowDialog();
    }

    private void clearStatusGrid()
    {
      for (int i = 0; i < dataMailist.Rows.Count; i++)
      {
        dataMailist.Rows[i].Cells[2].Value = "";
      }
    }

    private void dataSender_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        ContextMenu m = new ContextMenu();
        m.MenuItems.Add(new MenuItem("Edit", MenuSenderItemEdit_Click));
        m.MenuItems.Add(new MenuItem("Delete", MenuSenderItemDelete_Click));

        m.Show(dataSender, new Point(e.X, e.Y));
      }
    }

    private void MenuSenderItemEdit_Click(Object sender, EventArgs e)
    {
      if (selectedSender != null)
      {
        FormSmtp formSmtp = new FormSmtp(this);
        formSmtp.ShowDialog();
      }
    }

    private void MenuSenderItemDelete_Click(Object sender, EventArgs e)
    {
      var dialog = MessageBox.Show("Are you sure want to delete this account?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
      if (dialog == DialogResult.Yes)
      {
        smtp.deleteSmtp(selectedSender);
        reloadSmtpGrid();
      }
    }

    private void dataLetter_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        ContextMenu m = new ContextMenu();
        m.MenuItems.Add(new MenuItem("Edit", MenuLetterItemEdit_Click));
        m.MenuItems.Add(new MenuItem("Delete", MenuLetterItemDelete_Click));
        m.MenuItems.Add(new MenuItem("Preview", MenuLetterItemPreview_Click));

        m.Show(dataLetter, new Point(e.X, e.Y));
      }
    }

    private void MenuLetterItemEdit_Click(Object sender, EventArgs e)
    {
      if (selectedLetter != null)
      {
        FormLetter formLetter = new FormLetter(this);
        formLetter.ShowDialog();
        selectedLetter = null;
      }
    }

    private void MenuLetterItemDelete_Click(Object sender, EventArgs e)
    {
      var dialog = MessageBox.Show("Are you sure want to delete this account?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
      if (dialog == DialogResult.Yes)
      {
        letter.DeleteFile(selectedLetter);
        selectedLetter = null;
        ReloadLetterGrid();
      }
    }

    private void MenuLetterItemPreview_Click(Object sender, EventArgs e)
    {
      isPreview = true;
      FormLetter formLetter = new FormLetter(this);
      formLetter.ShowDialog();
      isPreview = false;
    }

    private void dataMailist_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
    {
      LabelTotalMailist.Text = $"Mailist ({dataMailist.Rows.Count})";
      int cct = dataMailist.Rows.Count; //count how many rows in dgv

      int cnt = 0;
      int replace_no = 1;
      while (cnt < cct)
      {
        dataMailist.Rows[cnt].Cells[0].Value = replace_no.ToString(); //replace S No            
        cnt = cnt + 1;
        replace_no = replace_no + 1;
      }
    }

    private void buttonLetter_Click(object sender, EventArgs e)
    {
      selectedLetter = null;
      FormLetter formLetter = new FormLetter(this);
      formLetter.ShowDialog();
    }

    private void labelClearMailist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      dataMailist.Rows.Clear();
    }

    private void dataLetter_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        selectedLetter = dataLetter.Rows[e.RowIndex].Cells[2].Value.ToString();
        lblSelectedLetter.Text = "Letter No: " + (e.RowIndex + 1);
      }
    }

    private void dataSender_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        selectedSender = dataSender.Rows[e.RowIndex].Cells[2].Value.ToString();
        lblSelectedSender.Text = "Sender No: " + (e.RowIndex + 1);
      }
    }

    private void dataSender_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        selectedSender = dataSender.Rows[e.RowIndex].Cells[2].Value.ToString();
        lblSelectedSender.Text = "Sender No: " + (e.RowIndex + 1);
      }
    }

    private void dataLetter_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        selectedLetter = dataLetter.Rows[e.RowIndex].Cells[2].Value.ToString();
        lblSelectedLetter.Text = "Letter No: " + (e.RowIndex + 1);
      }
    }

    private void buttonProxySetting_Click(object sender, EventArgs e)
    {
      FormProxy formProxy = new FormProxy();
      formProxy.ShowDialog();
    }

    private void buttonTimeZone_Click(object sender, EventArgs e)
    {
      FormTimeZone formTimeZone = new FormTimeZone(this);
      formTimeZone.ShowDialog();
    }

    private void panelHeader_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        Drag.ReleaseCapture();
        Drag.SendMessage(Handle, Drag.WM_NCLBUTTONDOWN, Drag.HT_CAPTION, 0);
      }
    }
  }
}
