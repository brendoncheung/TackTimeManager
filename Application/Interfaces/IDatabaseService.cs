using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TackTimeManager.Domain.WorkOrders;
using TackTimeManager.Domain.Assemblies;
using TackTimeManager.Domain.Parts;

namespace TackTimeManager.Application.Interfaces
{
    public interface IDatabaseService
    {
        IDbSet<WorkOrder> WorkOrders { get; set; }
        IDbSet<Part> Parts { get; set; }
        IDbSet<Assembly> Assemblies { get; set; }
        void Save(); 
    }
}
