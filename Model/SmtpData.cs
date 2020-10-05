using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonSender.Model
{
  public class SmtpData
  {
    public string id { get; set; }
    public string settingName { get; set; }
    public string host { get; set; }
    public int port { get; set; }
    public string senderEmail { get; set; }
    public string senderName { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public bool isSecure { get; set; }
  }
}
