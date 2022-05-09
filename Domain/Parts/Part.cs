using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TackTimeManager.Domain.Assemblies;
using TackTimeManager.Domain.Common;

namespace TackTimeManager.Domain.Parts
{
    public class Part : IEntity
    {
        public string PartNumber { get; set; }
        public string ModelNumber { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public double OnHand { get; set; }
        public double OnOrder { get; set; }
        public double Cost { get; set; }
        public List<Assembly> UsedOn { get; set; }
    }
}
