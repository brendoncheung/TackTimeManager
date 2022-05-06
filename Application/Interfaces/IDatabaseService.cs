using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TackTimeManager.Domain.WorkOrders;
using TackTimeManager.Domain.Assemblies;

namespace TackTimeManager.Application.Interfaces
{
    public interface IDatabaseService
    {
        IDbSet<WorkOrder> WorkOrders { get; set; }
        void Save(); 
    }
}
