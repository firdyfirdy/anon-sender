using AnonSender.Helper;
using AnonSender.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnonSender.Controller
{
  public class Letter
  {

    public void StoreAttachmentToGrid(DataGridView dataGrid, string filePath)
    {
      var rowIndex = dataGrid.Rows.Add();
      dataGrid.Rows[rowIndex].Cells[0].Value = dataGrid.Rows.Count;
      dataGrid.Rows[rowIndex].Cells[1].Value = filePath;
    }

    public void StoreLetter(LetterData data)
    {
      string pathFile = Path.Combine(Helpers.LetterPath, data.id + ".dat");
      var result = JsonConvert.SerializeObject(data);
      File.WriteAllText(pathFile, result);
    }

    public void DeleteFile(string id)
    {
      try
      {
        var pathFile = Path.Combine(Helpers.LetterPath, id + ".dat");
        File.Delete(pathFile);
      }
      catch (Exception e)
      {
        Console.WriteLine("Error: " + e.Message);
      }
    }

    public void StoreLetterToDashboard(DataGridView dgv)
    {
      DirectoryInfo d = new DirectoryInfo(Helpers.LetterPath);
      FileInfo[] Files = d.GetFiles("*.dat");
      //List<LetterData> dataFiles = new List<LetterData>();
      LetterData dataLetter = new LetterData();

      foreach (FileInfo file in Files)
      {
        var index = dgv.Rows.Add();
        dataLetter = ReadLetterFile( Path.Combine(Helpers.LetterPath, file.Name));
        dgv.Rows[index].Cells[0].Value = index + 1;
        dgv.Rows[index].Cells[1].Value = dataLetter.subject;
        dgv.Rows[index].Cells[2].Value = dataLetter.id;
        //dgv.Rows[index].Cells[3].Value = false;
        //dataFiles.Add(dataLetter);
      }
    }

    public LetterData ReadLetterFile(string file)
    {
      var data = File.ReadAllText(file);
      var result = JsonConvert.DeserializeObject<LetterData>(data);
      return result;
    }

    public void SettingGridAttachment(DataGridView dataGrid)
    {
      dataGrid.ColumnCount = 3;
      dataGrid.Columns[0].Name = "No";
      dataGrid.Columns[1].Name = "Path File";
      dataGrid.Columns[2].Name = "File Name";

      dataGrid.Columns[0].ReadOnly = true;
      dataGrid.Columns[1].ReadOnly = true;

      dataGrid.Columns[0].Width = 50;
      dataGrid.Columns[1].Width = 150;
      dataGrid.Columns[2].Width = 200;
      dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      dataGrid.AllowUserToDeleteRows = false;
    }

    public void SettingLetterDashboard(DataGridView dataGrid)
    {
      dataGrid.ColumnCount = 3;
      dataGrid.Columns[0].Name = "No";
      dataGrid.Columns[1].Name = "Subject";
      dataGrid.Columns[2].Name = "ID";

      dataGrid.Columns[2].Visible = false;

      dataGrid.Columns[0].Width = 50;
      dataGrid.Columns[1].Width = 400;
      dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      dataGrid.AllowUserToDeleteRows = false;
    }
    public void DisplayHtml(WebBrowser wb, string body)
    {
      wb.Navigate("about:blank");
      if (wb.Document != null)
      {
        wb.Document.Write(string.Empty);
      }
      wb.DocumentText = Uri.UnescapeDataString(body);
    }
  }
}
