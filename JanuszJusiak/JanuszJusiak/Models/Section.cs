using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JanuszJusiak.Models
{
    public class Section
    {
        public int Id { get; set; }
        public int PageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Page Page { get; set; }
    }
}
