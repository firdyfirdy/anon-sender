using AnonSender.Helper;
using AnonSender.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonSender.Controller
{
  public class Proxy
  {
    public bool SaveProxy(ProxyData proxy)
    {
      try
      {
        Properties.Settings.Default["ProxyHost"] = proxy.host;
        Properties.Settings.Default["ProxyPort"] = proxy.port;
        Properties.Settings.Default["ProxyIsActive"] = proxy.isActive;
        Properties.Settings.Default["ProxyIsSocks5"] = proxy.isSocks5;
        Properties.Settings.Default["ProxyUsername"] = proxy.username;
        Properties.Settings.Default["ProxyPassword"] = proxy.password;
        Properties.Settings.Default.Save();

        return true;
      }
      catch (Exception e)
      {
        Console.WriteLine($"Error: {e.Message}");
        return false;
      }
    }

    public ProxyData ReadProxy()
    {
      ProxyData proxy = new ProxyData();
      string proxyHost = Properties.Settings.Default["ProxyHost"].ToString();
      string proxyUsername = Properties.Settings.Default["ProxyUsername"].ToString();
      string proxyPassword = Properties.Settings.Default["ProxyPassword"].ToString();
      int proxyPort = Convert.ToInt32(Properties.Settings.Default["ProxyPort"]);
      bool proxyIsActive = Convert.ToBoolean(Properties.Settings.Default["ProxyIsActive"]);
      bool ProxyIsSocks5 = Convert.ToBoolean(Properties.Settings.Default["ProxyIsSocks5"]);
      proxy.isActive = proxyIsActive;

      if (!String.IsNullOrEmpty(proxyHost) && proxyPort != 0)
      {
        proxy.host = proxyHost;
        proxy.port = proxyPort;
        proxy.username = proxyUsername;
        proxy.password = proxyPassword;
        proxy.isSocks5 = ProxyIsSocks5;
      }
      else
      {
        proxy.port = 0;
        proxy.host = "";
      }
      return proxy;
    }
  }
}
