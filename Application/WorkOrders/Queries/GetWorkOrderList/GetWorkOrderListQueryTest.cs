using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMoq;
using NUnit.Framework;
using System.Data.Entity;
using TackTimeManager.Application.Interfaces;
using TackTimeManager.Domain.WorkOrders;
using TackTimeManager.Domain.Assemblies;
using TackTimeManager.Domain.Parts;
using TackTimeManager.Domain.Customers;

namespace TackTimeManager.Application.WorkOrders.Queries.GetWorkOrderList
{
    [TestFixture]
    public class GetWorkOrderListQueryTest
    {
        private GetWorkOrderListQuery _query;
        private AutoMoqer _mocker;
        private WorkOrder _workOrders;

        // mock parts
        public Part _part;
        public string _partNumber = "123456";

        // mock assembly
        public Assembly _assembly;
        public const string _assemblyName = "Assembly 1";
        public const int _quantity = 1;

        // mock customer
        public Customer _customer;
        public string _customerName = "customerName";
           
        // mock work order
        public int _workOrderId = 1;
        public Dictionary<Part, double> _subAssembly = new Dictionary<Part, double>();
        public DateTime _dueDate = DateTime.Now;
        public DateTime _createdDate = DateTime.Now;
        public double _hoursUsed = 1;

        [SetUp]
        public void SetUp()
        {
            _customer = new Customer()
            {
                Name = _customerName,
            };

            _part = new Part()
            {
                PartNumber = _partNumber,
            };

            _subAssembly.Add(_part, _quantity);

            _assembly = new Assembly()
            {
                Parts = _subAssembly,
                Name = _assemblyName,
                Customer = _customer,
            };

            _workOrders = new WorkOrder()
            {
                Id = _workOrderId,
                Assemblies = new Dictionary<Assembly, double>() { { _assembly, 1.0 } },
                DueDate = _dueDate,
                CreatedDate = _createdDate,
                HoursUsed = _hoursUsed
            };

            _mocker = new AutoMoqer();

            _mocker.GetMock<IDatabaseService>()
                .Setup(x => x.WorkOrders)
                .Returns(_mocker.GetMock<IDbSet<WorkOrder>>().Object);


        }
    }
}
