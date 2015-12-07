using BLL;
using Lesson.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Lesson.App
{
    public class OrdersService
    {
        private readonly Manager _manager;
        public OrdersService()
        {
            _manager = new Manager();
        }

        public IEnumerable<OrderViewModel> GetOrders()
        {
            return _manager.GetOrders().Select(o => new OrderViewModel
            {
                OrderID = o.OrderID,
                OrderDate = o.OrderDate,
                ShipAddress = o.ShipAddress,
                ShipName = o.ShipName
            });
        }

        public OrderViewModel GetOrderById(int id)
        {
            var o = _manager.GetOrderById(id);
            return new OrderViewModel {
                OrderID = o.OrderID,
                OrderDate = o.OrderDate,
                ShipAddress = o.ShipAddress,
                ShipName = o.ShipName
            };
        }
    }
}
