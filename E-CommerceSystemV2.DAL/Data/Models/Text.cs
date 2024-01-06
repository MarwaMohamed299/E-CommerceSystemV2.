using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceSystemV2.DAL.Data.Models
{
    public class Text
    {
        public Guid Id { get; set; }
        public string TextKey { get; set; } = string.Empty;
        public string EnglishText { get; set; } = string.Empty;
        public string ArabicText { get; set; } = string.Empty;
    }
}
    
   