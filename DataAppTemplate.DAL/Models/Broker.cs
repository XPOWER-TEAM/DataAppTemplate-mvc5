using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAppTemplate.DAL.Models
{
    public class Broker
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool IsDeactivated { get; set; }
        public DateTime AddedOn { get; set; }
        
    }
}
