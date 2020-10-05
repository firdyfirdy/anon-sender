using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonSender.Helper
{
  public class Helpers
  {
    static Random Random = new Random();
    public const string AppName = "AnonSender";
    public static readonly string LocalPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), AppName);
    public static readonly string SmtpPath = Path.Combine(LocalPath, "smtp");
    public static readonly string LetterPath = Path.Combine(LocalPath, "letter");
    public static readonly string AttachmentPath = Path.Combine(LetterPath, "attachment");
    public static readonly string tempPath = Path.Combine(Path.GetTempPath(), AppName);

    public Helpers()
    {
      /* Create Folder if not exists */
      if (!Directory.Exists(LocalPath))
        Directory.CreateDirectory(LocalPath);
      if (!Directory.Exists(SmtpPath))
        Directory.CreateDirectory(SmtpPath);
      if (!Directory.Exists(LetterPath))
        Directory.CreateDirectory(LetterPath);
      if (!Directory.Exists(AttachmentPath))
        Directory.CreateDirectory(AttachmentPath);
      if (!Directory.Exists(SmtpPath))
        Directory.CreateDirectory(SmtpPath);
      if (!Directory.Exists(tempPath))
        Directory.CreateDirectory(tempPath);
    }

    public static string RandomString(int length = 12)
    {
      const string pool = "abcdefghijklmnopqrstuvwxyz0123456789";
      var chars = Enumerable.Range(0, length)
          .Select(x => pool[Random.Next(0, pool.Length)]);
      return new string(chars.ToArray());
    }
    public string RandomAlphabet(int length = 12)
    {
      const string pool = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
      var chars = Enumerable.Range(0, length)
          .Select(x => pool[Random.Next(0, pool.Length)]);
      return new string(chars.ToArray());
    }

    public string SetDateTime(string format, string TimeZoneId)
    {
      string now = DateTime.Now.ToString("yy/MM/dd h:mm:ss tt");
      DateTime myDate = DateTime.ParseExact(now, "yy/MM/dd h:mm:ss tt", CultureInfo.InvariantCulture);
      var inTimeZone = TimeZoneInfo.FindSystemTimeZoneById(TimeZoneId);
      DateTime inTime = TimeZoneInfo.ConvertTime(Convert.ToDateTime(myDate), TimeZoneInfo.Local, inTimeZone);
      return inTime.ToString(format);
    }
    public static string Base64Encode(string plainText)
    {
      var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
      return Convert.ToBase64String(plainTextBytes);
    }
    public static string Base64Decode(string base64EncodedData)
    {
      var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
      return Encoding.UTF8.GetString(base64EncodedBytes);
    }
  }
}
