using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JanuszJusiak.Models
{
    public class Element
    {
        public int Id { get; set; }
        public int SectionId { get; set; }
        public int SectionOrder { get; set; }
        public string HtmlTag { get; set; }
        public string HtmlAttribute { get; set; }
        public int ContentId { get; set; }

        public Content Content { get; set; }
        public Section Section { get; set; }
    }
}
