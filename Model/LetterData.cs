using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonSender.Model
{
  public class LetterData
  {
    public string id { get; set; }
    public string subject { get; set; }
    public string body { get; set; }
    public bool isHtml { get; set; }
    public List<AttachmentData> attachment { get; set; }
  }

  public class AttachmentData
  {
    public string fileName { get; set; }
    public string filePath { get; set; }
  }
}
