using System.Collections.Generic;

namespace PopryzhenokTest.Contexty.Models
{
    public class Agent
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public AgentTypes Type { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Logotip { get; set; }

        public string Address { get; set; }

        public int Prioritet { get; set; }

        public string DirectorName { get; set; }

        public string INN { get; set; }

        public string KPP { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
