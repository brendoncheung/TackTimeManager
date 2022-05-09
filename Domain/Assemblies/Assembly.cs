using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TackTimeManager.Domain.Parts;
using TackTimeManager.Domain.Customers;
using TackTimeManager.Domain.Common;

namespace TackTimeManager.Domain.Assemblies
{
    public class Assembly : IEntity
    {
        public int Id { get; set; }
        public Dictionary<Part, double> Parts { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public Customer Customer { get; set; }
        public double OpenPOQuantity { get; set; }
        }
}
