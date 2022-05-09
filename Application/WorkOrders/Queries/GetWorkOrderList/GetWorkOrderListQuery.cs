using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TackTimeManager.Application.Interfaces;
using TackTimeManager.Application.WorkOrders.Queries.GetWorkOrderList;
using TackTimeManager.Domain.WorkOrders;

namespace TackTimeManager.Application.WorkOrders.Queries
{
    public class GetWorkOrderListQuery : IGetWorkOrderListQuery
    {
        private readonly IDatabaseService _database;

        public GetWorkOrderListQuery(IDatabaseService database)
        {
            _database = database;
        }

        public List<WorkOrder> Execute()
        {
            var wo = _database.GetAllWorkOrders();
            return wo;
        }

    }
}
