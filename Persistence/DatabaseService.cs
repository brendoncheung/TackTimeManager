using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TackTimeManager.Application.Interfaces;
using TackTimeManager.Domain.WorkOrders;

namespace TackTimeManager.Persistence
{
    public class DatabaseService : IDatabaseService
    {
        public IDbSet<WorkOrder> WorkOrders { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
