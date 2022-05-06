using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TackTimeManager.Domain.WorkOrders;

namespace TackTimeManager.Application.WorkOrders.Queries.GetWorkOrderList
{
    public interface IGetWorkOrderListQuery
    {
        List<WorkOrder> Execute();
    }
}
