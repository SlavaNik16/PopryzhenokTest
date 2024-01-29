using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopryzhenokTest.Contexty.Models
{
    public class Sale
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int AgentId { get; set; }
        public virtual Agent Agent { get; set; }

        public DateTimeOffset Relize { get; set; }

        public int Count { get; set; }
    }
}
