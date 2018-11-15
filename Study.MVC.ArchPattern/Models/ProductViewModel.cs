using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Study.MVC.ArchPattern.Models
{
    public class ProductViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
