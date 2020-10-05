using AnonSender.Helper;
using AnonSender.Model;
using MailKit.Net.Proxy;
using MailKit.Net.Smtp;
using MailKit.Security;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnonSender.Controller
{
  public class Smtp
  {
    public void StoreSmtpToGrid(DataGridView dgv)
    {
      List<string> smtpId = GetAllSmtpConfig();
      foreach (var smtp in smtpId)
      {
        var read = getSmtp(smtp);
        var rowIndex = dgv.Rows.Add();
        dgv.Rows[rowIndex].Cells[0].Value = rowIndex + 1;
        dgv.Rows[rowIndex].Cells[1].Value = read.settingName;
        dgv.Rows[rowIndex].Cells[2].Value = read.id;
      }
    }

    public List<string> GetAllSmtpConfig()
    {
      DirectoryInfo d = new DirectoryInfo(Helpers.SmtpPath);
      FileInfo[] Files = d.GetFiles("*.conf");
      List<string> dataFiles = new List<string>();

      foreach (FileInfo file in Files)
      {
        dataFiles.Add(file.Name.Replace(".conf", ""));
      }
      return dataFiles;
    }

    public SmtpData getSmtp(string id)
    {
      SmtpData dataSmtp = new SmtpData();
      var pathFile = Path.Combine(Helpers.SmtpPath, id + ".conf");
      if (File.Exists(pathFile))
      {
        var text = File.ReadAllText(pathFile);
        dataSmtp = JsonConvert.DeserializeObject<SmtpData>(text);
      }
      return dataSmtp;
    }

    public void deleteSmtp(string username)
    {
      var pathFile = Path.Combine(Helpers.SmtpPath, username + ".conf");
      File.Delete(pathFile);
    }

    public void SettingDataGrid(DataGridView dataGrid)
    {
      dataGrid.ColumnCount = 3;
      dataGrid.Columns[0].Name = "No";
      dataGrid.Columns[1].Name = "Name";
      dataGrid.Columns[2].Name = "ID";

      dataGrid.Columns[2].Visible = false;
      dataGrid.Columns[0].Width = 30;
      dataGrid.Columns[1].Width = 155;
      dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    }

    public void SaveSmtp(SmtpData data)
    {
      var dataJson = JsonConvert.SerializeObject(data);
      string resultPath = Path.Combine(Helpers.SmtpPath, $"{data.id}.conf");
      File.WriteAllText(resultPath, dataJson);
    }

    public async Task<bool> DoConnect(SmtpData data, ProxyData proxy = null)
    {
      var cts = new CancellationTokenSource();
      var token = cts.Token;
      try
      {
        using (var client = new SmtpClient())
        {
          var ssl = (data.isSecure) ? SecureSocketOptions.Auto : SecureSocketOptions.None;

          if (proxy != null)
          {
            if (proxy.isSocks5)
            {
              if (String.IsNullOrWhiteSpace(proxy.username))
              {
                var credentials = new NetworkCredential(proxy.username, proxy.password);
                client.ProxyClient = new Socks5Client(proxy.host, proxy.port, credentials);
              }
              else
              {
                client.ProxyClient = new Socks5Client(proxy.host, proxy.port);
              }
            }
            else
            {
              client.ProxyClient = new HttpProxyClient(proxy.host, proxy.port);
            }
          }

          await client.ConnectAsync(data.host, data.port, ssl, token);

          if (!String.IsNullOrWhiteSpace(data.username) && !String.IsNullOrWhiteSpace(data.password))
          {
            client.Authenticate(data.username, data.password);
          }

          if (client.IsConnected)
          {
            client.Disconnect(true);
            return true;
          }

          return false;
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Error: {ex.Message}");
        return false;
      }
    }
  }
}
