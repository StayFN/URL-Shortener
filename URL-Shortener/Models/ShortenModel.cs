using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace URL_Shortener.Models
{
    public class ShortenModel
    {
        public bool IsCustom { get; set; }
        public string OriginalUrl { get; set; }
        public string Token { get; set; }
    }
}
