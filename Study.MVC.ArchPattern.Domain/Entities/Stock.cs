using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Study.MVC.ArchPattern.Domain.Entities
{
    public class Stock
    {
        public long Id { get; set; }
        public Product Product { get; set; }
        public int Count { get; set; }
        public double Value { get; set; }
        public DateTime EnterDate { get; set; }
    }
}
