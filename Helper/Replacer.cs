using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonSender.Helper
{
  public class Replacer
  {
    private string TimeZoneid = "";
    public Replacer()
    {
      this.TimeZoneid = Properties.Settings.Default["TimeZone"].ToString();
    }
    public string DoReplace(string message, string email)
    {
      Helpers helpers = new Helpers();
      StringBuilder sb = new StringBuilder(Uri.UnescapeDataString(message));

      Console.WriteLine(sb);

      try
      {

        if (email.Contains("@"))
        {
          string[] words = email.Split('@');

          string user = words[0];
          string provider = words[1];
          string domc = provider.Split('.')[0];

          if (sb.ToString().ToLower().Contains("[emailusername]"))
          {
            sb.Replace("[emailusername]", user); // ambil username dalam email from name
          }
          if (sb.ToString().ToLower().Contains("[domainuc]"))
          {
            sb.Replace("[domainuc]", char.ToUpper(domc[0]) + domc.Substring(1)); //  = ambil domain tanpa . ( domain ) tapi diawal dipake kapital ( Domain )
          }
          if (sb.ToString().ToLower().Contains("[domain]"))
          {
            sb.Replace("[domain]", domc); //  = ambil domain tanpa . domain ( domain )
          }
          if (sb.ToString().ToLower().Contains("[dotdomain]"))
          {
            sb.Replace("[dotdomain]", provider); // DOMAIN = ambil domain sama . nya ( domain.com )
          }
        }

        if (sb.ToString().ToLower().Contains("[24hour]"))
        {
          sb.Replace("[24hour]", helpers.SetDateTime("HH:mm:ss", TimeZoneid)); 
        }
        if (sb.ToString().ToLower().Contains("[12hour]"))
        {
          sb.Replace("[12hour]", helpers.SetDateTime("hh:mm:ss", TimeZoneid));
        }
        if (sb.ToString().ToLower().Contains("[minute]"))
        {
          sb.Replace("[minute]", helpers.SetDateTime("mm", TimeZoneid));
        }
        if (sb.ToString().ToLower().Contains("[second]"))
        {
          sb.Replace("[second]", helpers.SetDateTime("ss", TimeZoneid)); 
        }
        if (sb.ToString().ToLower().Contains("[day]"))
        {
          sb.Replace("[day]", helpers.SetDateTime("dddd", TimeZoneid));
        }
        if (sb.ToString().ToLower().Contains("[month]"))
        {
          sb.Replace("[month]", helpers.SetDateTime("MMMM", TimeZoneid));
        }
        if (sb.ToString().ToLower().Contains("[year]"))
        {
          sb.Replace("[year]", helpers.SetDateTime("yyyy", TimeZoneid));
        }
        if (sb.ToString().ToLower().Contains("[fulldatetime]"))
        {
          sb.Replace("[fulldate]", helpers.SetDateTime("MMMM dd, yyyy, HH:mm:ss tt", TimeZoneid));
        }
        if (sb.ToString().ToLower().Contains("[fulldatetime1]"))
        {
          sb.Replace("[fulldate]", helpers.SetDateTime("dd/mm/yyyy, HH:mm:ss tt", TimeZoneid));
        }
        if (sb.ToString().ToLower().Contains("[fulldate]"))
        {
          sb.Replace("[fulldate]", helpers.SetDateTime("ddd, mm dd, yyyy", TimeZoneid));  //Mon, July 13, 2020
        }
        if (sb.ToString().ToLower().Contains("[fulldate1]"))
        {
          sb.Replace("[fulldate1]", helpers.SetDateTime("dd/mm/yyyy", TimeZoneid));  // = 7/13/2020
        }
        if (sb.ToString().ToLower().Contains("[email]"))
        {
          sb.Replace("[email]", email); //  replace email
        }
        if (sb.ToString().ToLower().Contains("[random5]"))
        {
          sb.Replace("[random5]", helpers.RandomAlphabet(5)); //  generate 5 alphabetic
        }
        if (sb.ToString().ToLower().Contains("[random50]"))
        {
          sb.Replace("[random50]", helpers.RandomAlphabet(50)); //  generate 50 alphabetic
        }
        if (sb.ToString().ToLower().Contains("[emailtobase64]"))
        {
          sb.Replace("[emailtobase64]", Helpers.Base64Encode(email)); // Replace email to base64
        }

      }
      catch (Exception)
      {

      }
      return sb.ToString();
    }
  }
}
