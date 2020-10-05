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
      StringBuilder sb = new StringBuilder(message);


      try
      {

        if (email.Contains("@"))
        {
          string[] words = email.Split('@');

          string user = words[0];
          string provider = words[1];
          string domc = provider.Split('.')[0];

          if (sb.ToString().Contains("USER"))
          {
            sb.Replace("USER", user); // ambil username dalam email from name
          }
          if (sb.ToString().Contains("DOMC"))
          {
            sb.Replace("DOMC", char.ToUpper(domc[0]) + domc.Substring(1)); //  = ambil domain tanpa . ( doamin ) tapi diawal dipake kapital ( Doamin )
          }
          if (sb.ToString().Contains("DOMs"))
          {
            sb.Replace("DOMs", domc); //  = ambil domain tanpa . domain ( doamin )
          }
          if (sb.ToString().Contains("DOMAIN"))
          {
            sb.Replace("DOMAIN", provider); // DOMAIN = ambil domain sama . nya ( doamin.com )
          }
        }

        if (sb.ToString().Contains("SILENTCODERSHOUR24"))
        {
          sb.Replace("SILENTCODERSHOUR24", helpers.SetDateTime("HH:mm:ss", TimeZoneid)); 
        }
        if (sb.ToString().Contains("SILENTCODERSHOUR12"))
        {
          sb.Replace("SILENTCODERSHOUR12", helpers.SetDateTime("hh:mm:ss", TimeZoneid));
        }
        if (sb.ToString().Contains("SILENTCODERSMINUTE"))
        {
          sb.Replace("SILENTCODERSMINUTE", helpers.SetDateTime("mm", TimeZoneid));
        }
        if (sb.ToString().Contains("SILENTCODERSSECOND"))
        {
          sb.Replace("SILENTCODERSSECOND", helpers.SetDateTime("ss", TimeZoneid)); 
        }
        if (sb.ToString().Contains("SILENTCODERSDAY"))
        {
          sb.Replace("SILENTCODERSDAY", helpers.SetDateTime("dddd", TimeZoneid));
        }
        if (sb.ToString().Contains("SILENTCODERSMONTH"))
        {
          sb.Replace("SILENTCODERSMONTH", helpers.SetDateTime("MMMM", TimeZoneid));
        }
        if (sb.ToString().Contains("SILENTCODERSYEAR"))
        {
          sb.Replace("SILENTCODERSYEAR", helpers.SetDateTime("yyyy", TimeZoneid));
        }
        if (sb.ToString().Contains("SILENTCODERSFULLDATE"))
        {
          sb.Replace("SILENTCODERSFULLDATE", helpers.SetDateTime("MMMM dd, yyyy, HH:mm:ss tt", TimeZoneid));
        }
        if (sb.ToString().Contains("SILENTCODERS2FULLDATE"))
        {
          sb.Replace("SILENTCODERS2FULLDATE", helpers.SetDateTime("dd/mm/yyyy, HH:mm:ss tt", TimeZoneid));
        }
        if (sb.ToString().Contains("SILENTCODERSDATEONLY1"))
        {
          sb.Replace("SILENTCODERSDATEONLY1", helpers.SetDateTime("ddd, mm dd, yyyy", TimeZoneid));  //Mon, July 13, 2020
        }
        if (sb.ToString().Contains("SILENTCODERSDATEONLY2"))
        {
          sb.Replace("SILENTCODERSDATEONLY2", helpers.SetDateTime("dd/mm/yyyy", TimeZoneid));  // = 7/13/2020
        }
        if (sb.ToString().Contains("SILENTCODERSEMAIL"))
        {
          sb.Replace("SILENTCODERSEMAIL", email); //  replace email
        }
        if (sb.ToString().Contains("SILENTCODERSLIMAHURUF"))
        {
          sb.Replace("SILENTCODERSLIMAHURUF", helpers.RandomAlphabet(5)); //  generate 5 alphabetic
        }
        if (sb.ToString().Contains("SILENTCODERSBANYAKHURUF"))
        {
          sb.Replace("SILENTCODERSBANYAKHURUF", helpers.RandomAlphabet(50)); //  generate 50 alphabetic
        }
        if (sb.ToString().Contains("EMAILURLSILENTC0DERS"))
        {
          sb.Replace("EMAILURLSILENTC0DERS", Helpers.Base64Encode(email)); // Replace email to base64
        }
        if (sb.ToString().Contains("EMAILURLSILENTCODERS"))
        {
          sb.Replace("EMAILURLSILENTCODERS", Helpers.Base64Encode(email)); // Replace email to base64
        }

      }
      catch (Exception)
      {

      }
      return sb.ToString();
    }
  }
}
