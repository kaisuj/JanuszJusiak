using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JanuszJusiak.Models
{
    public class AbstractElement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string HtmlTag { get; set; }
    }
}
