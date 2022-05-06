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
        public Guid Id { get; set; }
        public Dictionary<Assembly, double> Assemblies { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public double HoursUsed { get; set; }

        public WorkOrder(Guid id, Dictionary<Assembly, double> assemblies, DateTime dueDate, DateTime createdDate, double hoursUsed)
        {
            Id = id;
            Assemblies = assemblies;
            DueDate = dueDate;
            CreatedDate = createdDate;
            HoursUsed = hoursUsed;
        }

    } 
}
