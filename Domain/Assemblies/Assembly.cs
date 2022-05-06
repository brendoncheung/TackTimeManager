using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TackTimeManager.Domain.Parts;
using TackTimeManager.Domain.Customers;

namespace TackTimeManager.Domain.Assemblies
{
    public class Assembly : IEntity
    {
        private Dictionary<Part, double> parts;
        private string Description;
        private string PartNo;
        private Customer customer;
        private double OpenPOQuantity;
    }
}
