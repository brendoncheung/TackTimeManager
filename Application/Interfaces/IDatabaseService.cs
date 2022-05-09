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
        List<WorkOrder> GetAllWorkOrders();
        List<Part> GetWorkOrderByNumber(string number);
        List<Assembly> GetAllAssemblies();
        
        void Save(); 
    }
}
