using PopryzhenokTest.Contexty.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopryzhenokTest.Contexty.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ProductTypes Type { get; set; }

        public string Articul { get; set; }

        public int Count { get; set; }

        public int Number { get; set; }

        public int MinPriceAgent { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
