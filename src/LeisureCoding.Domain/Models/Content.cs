using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeisureCoding.Domain.Models
{
   public class Content
    {
       public int ContentId { get; set; }
       public string ContentName { get; set; }
       public string ContentSummary { get; set; }
       public string ContentText { get; set; }
       public string Line { get; set; }

    }
}
