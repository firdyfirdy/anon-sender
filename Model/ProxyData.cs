using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonSender.Model
{
  public class ProxyData
  {
    public string host { get; set; }
    public int port { get; set; }
    public bool isSocks5 { get; set; }
    public bool isActive { get; set; }

    public string username { get; set; }
    public string password { get; set; }
  }
}
