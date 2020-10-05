using AnonSender.Helper;
using AnonSender.Model;
using MailKit.Net.Proxy;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnonSender.Controller
{
  public class Email
  {
    public int totalRows = 0;
    private SmtpClient client;

    public Email(SmtpClient client)
    {
      this.client = client;
    }

    public void GetFileList(string path)
    {

    }

    public void DoConnect(SmtpData smtp, ProxyData proxy = null)
    {
      var ssl = (smtp.isSecure) ? SecureSocketOptions.Auto : SecureSocketOptions.None;
      client.Timeout = int.MaxValue;
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
      
      client.Connect(smtp.host, smtp.port, ssl);

      client.ServerCertificateValidationCallback = (s, c, h, e) => true;
      if (smtp.username != null && smtp.password != null)
      {
        client.Authenticate(
          smtp.username,
          smtp.password
          );
      }
    }

    public void DoDisconnect()
    {
      client.Disconnect(true);
    }

    public async Task<ResponseData> SendEmail(VictimData victimData, SmtpData senderData, LetterData letter)
    {
      ResponseData response = new ResponseData();
      BodyBuilder bodyBuilder = new BodyBuilder();
      string newAttachment = "";
      try
      {
        MimeMessage message = new MimeMessage();
        message.From.Add(new MailboxAddress(senderData.senderName, senderData.senderEmail));
        message.To.Add(new MailboxAddress(victimData.email));
        message.Subject = letter.subject;
        if (letter.isHtml)
        {
          bodyBuilder.HtmlBody = letter.body;
        }
        else
        {
          bodyBuilder.TextBody = letter.body;
        }

        foreach (var attachment in letter.attachment)
        {
          newAttachment = ReadAndReplaceAttachment(attachment.filePath, victimData.email, attachment.fileName);
          bodyBuilder.Attachments.Add(newAttachment);

          File.Delete(newAttachment);
          Console.WriteLine(newAttachment);
        }

        message.Body = bodyBuilder.ToMessageBody();
        await client.SendAsync(message);


        response.status = true;
        response.messages = "";

        return response;
      }catch(Exception ex)
      {
        response.messages = ex.Message;
        response.status = false;
        return response;
      }
    }

    private string ReadAndReplaceAttachment(string filePath, string email, string newFileName)
    {
      Replacer replacer = new Replacer();
      string tempFile =  Path.Combine(Helpers.tempPath, replacer.DoReplace(newFileName, email));//Path.GetTempPath() + Guid.NewGuid().ToString() + Path.GetExtension(filePath);
      string contentResult = "";

      using (StreamReader sr = File.OpenText(filePath))
      {
        contentResult = sr.ReadToEnd();
        contentResult = replacer.DoReplace(contentResult, email);
        sr.Close();
      }

      using (var tw = new StreamWriter(tempFile, true))
      {
        tw.Write(contentResult);
      }

      return tempFile;
    }

    public void StoreEmailToDataGrid(string filePath, DataGridView dataGridView)
    {
      try
      {
        var baca = File.ReadLines(filePath);
        foreach (var line in baca)
        {
          var rowIndex = dataGridView.Rows.Add();
          dataGridView.Rows[rowIndex].Cells[0].Value = rowIndex+1;
          dataGridView.Rows[rowIndex].Cells[1].Value = line;
        }
        this.totalRows = dataGridView.Rows.Count;
      }
      catch (IOException)
      {

      }
    }

    public void SettingDataGrid(DataGridView dataGridView)
    {
      dataGridView.ColumnCount = 4;
      dataGridView.Columns[0].Name = "No";
      dataGridView.Columns[1].Name = "Email";
      dataGridView.Columns[2].Name = "Status";
      dataGridView.Columns[3].Name = "Message";

      dataGridView.Columns[0].Width = 50;
      dataGridView.Columns[1].Width = 300;
      dataGridView.Columns[2].Width = 100;
      dataGridView.Columns[3].Width = 400;
      dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    }
  }
}
