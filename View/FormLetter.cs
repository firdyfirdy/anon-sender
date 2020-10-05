using AnonSender.Controller;
using AnonSender.Helper;
using AnonSender.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnonSender.View
{
  public partial class FormLetter : Form
  {
    Letter letter = new Letter();
    FormDashboard _owner;
    Replacer replacer = new Replacer();
    public FormLetter(FormDashboard owner)
    {
      _owner = owner;
      InitializeComponent();
      this.FormClosing += new FormClosingEventHandler(this.FormLetter_FormClosing);
    }

    private void buttonClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void buttonRestoreDown_Click(object sender, EventArgs e)
    {
      WindowState = WindowState == FormWindowState.Maximized
                         ? FormWindowState.Normal
                         : FormWindowState.Maximized;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void FormEdit()
    {
      LetterData letterData = letter.ReadLetterFile(Path.Combine(Helpers.LetterPath, FormDashboard.selectedLetter + ".dat"));
      txtBody.Text = Uri.UnescapeDataString(letterData.body);
      txtId.Text = letterData.id;
      txtSubject.Text = letterData.subject;
      chkIsHtml.Checked = letterData.isHtml;

      loadAttachment(letterData);

      btnSave.Text = "Update";
    }

    private void loadAttachment(LetterData letterData)
    {
      dataAttachment.Rows.Clear();
      foreach (var itemLetter in letterData.attachment)
      {
        var index = dataAttachment.Rows.Add();
        dataAttachment.Rows[index].Cells[0].Value = index + 1;
        dataAttachment.Rows[index].Cells[1].Value = itemLetter.filePath;
        dataAttachment.Rows[index].Cells[2].Value = itemLetter.fileName;
      }
    }

    private void FormAdd()
    {
      txtBody.Text = "";
      txtId.Text = "";
      txtSubject.Text = "";
      chkIsHtml.Checked = false;
      dataAttachment.Rows.Clear();
    }

    private void FormPreview()
    {
      LetterData letterData = letter.ReadLetterFile(Path.Combine(Helpers.LetterPath, FormDashboard.selectedLetter + ".dat"));
      labelHeader.Text = "Letter Preview";
      string body = Uri.UnescapeDataString(letterData.body);
      body = replacer.DoReplace(body, "victim@domain.com");

      txtSubject.ReadOnly = true;
      if (letterData.isHtml)
      {
        txtBody.Visible = false;
        htmlBody.Visible = true;
        letter.DisplayHtml(htmlBody, body);
      }
      else
      {
        txtBody.Text = body;
        txtBody.ReadOnly = true;
      }
      panelAttachment.Visible = false;
      txtId.Text = letterData.id;
      txtSubject.Text = replacer.DoReplace(letterData.subject, "victim@domain.com");
      chkIsHtml.Checked = letterData.isHtml;

      btnSave.Visible = false;
      chkIsHtml.Visible = false;
    }

    private void FormLetter_Load(object sender, EventArgs e)
    {
      txtId.Visible = false;
      letter.SettingGridAttachment(dataAttachment);

      if (FormDashboard.selectedLetter != null)
      {
        if (FormDashboard.isPreview)
        {
          FormPreview();
        }
        else
        {
          FormEdit();
        }
      }
      else
      {
        FormAdd();
      }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      string file = "";
      //openFile.Filter = "Text Files|*.txt|*.html|*.pdf|*";
      openFile.Title = "Please select some file.";
      openFile.FileName = file;
      DialogResult result = openFile.ShowDialog(); // Show the dialog.
      if (result == DialogResult.OK) // Test result.
      {
        file = openFile.FileName;
        try
        {
          letter.StoreAttachmentToGrid(dataAttachment, file);
        }
        catch (IOException)
        {
          MessageBox.Show(result.ToString());
        }
      }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      btnSave.Enabled = false;
      LetterData data = new LetterData();
      List<AttachmentData> attachment = new List<AttachmentData>();
      data.id = (btnSave.Text == "Save") ? Helpers.RandomString(10) : txtId.Text;
      //data.id = Helpers.RandomString(10);
      data.subject = txtSubject.Text;
      data.body = Uri.EscapeDataString(txtBody.Text);
      data.isHtml = chkIsHtml.Checked;
      for (int i = 0; i < dataAttachment.Rows.Count; i++)
      {
        var fileName = dataAttachment.Rows[i].Cells[2].Value;
        string filePath = dataAttachment.Rows[i].Cells[1].Value.ToString();
        
        if (fileName == null)
        {
          fileName = Path.GetFileName(filePath);
        }
        attachment.Add(new AttachmentData() {
          fileName = fileName.ToString(),
          filePath = filePath
        });
      }
      data.attachment = attachment;

      letter.StoreLetter(data);
      //MessageBox.Show("Save Letter Success!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
      btnSave.Enabled = true;
      this.Close();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      DialogResult dialog = MessageBox.Show("Are you sure want to delete this item?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
      if (dialog == DialogResult.Yes)
      {
        foreach (DataGridViewRow item in this.dataAttachment.SelectedRows)
        {
          dataAttachment.Rows.RemoveAt(item.Index);
          Console.WriteLine($"Remove {item.Index}");
        }
      }
    }

    private void FormLetter_FormClosing(object sender, FormClosingEventArgs e)
    {
      _owner.ReloadLetterGrid();
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
