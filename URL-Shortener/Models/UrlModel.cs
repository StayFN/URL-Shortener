using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace URL_Shortener.Models
{
    public class UrlModel
    {
        
        public string TokenId { get; set; }
        public string OriginalUrl { get; set; }
    }
}
