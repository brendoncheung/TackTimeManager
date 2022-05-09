using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TackTimeManager.Domain.Common;
using TackTimeManager.Domain.Assemblies;

namespace TackTimeManager.Domain.WorkOrders
{
    public class WorkOrder : IEntity
    {
        public int WorkOrderNumber { get; set; }
        public Dictionary<Assembly, double> Assemblies { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public double HoursUsed { get; set; }

    }
}
