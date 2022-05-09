using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TackTimeManager.Application.Interfaces;
using TackTimeManager.Domain.Assemblies;
using TackTimeManager.Domain.Parts;
using TackTimeManager.Domain.WorkOrders;

namespace TackTimeManager.Persistence
{
    public class DatabaseService : IDatabaseService
    {
        public IDbSet<WorkOrder> WorkOrders { get; set; }
        public IDbSet<Part> Parts { get; set ; }
        public IDbSet<Assembly> Assemblies { get; set; }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
