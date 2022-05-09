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
using TackTimeManager.Persistence.Common;
using NDbfReader;

namespace TackTimeManager.Persistence
{
    public class DatabaseService : IDatabaseService
    {
        public List<Assembly> GetAllAssemblies()
        {
            throw new NotImplementedException();
        }

        public List<WorkOrder> GetAllWorkOrders()
        {
            List<WorkOrder> results = new List<WorkOrder>();
            using (var table = Table.Open($"Z:\\pcmrpw\\{TableName.SALES}"))
            {

            }

            return results;
        }

        public List<Part> GetWorkOrderByNumber(string number)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }

    public void Save()
        {
            throw new NotImplementedException();
        }

      
    }
}
