using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JanuszJusiak.Models
{
    public class Content
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public Element Element { get; set; }
    }
}
