using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace TotalRecall
{
    public class Manager
    {
        public List<ProductDTO> GetProducts()
        {
            var products = new List<ProductDTO>();
            using (Northwind context = new Northwind())
            {
                products = context.Products.Select(p => new ProductDTO
                {
                    ProductID = p.ProductID,
                    ProductName = p.ProductName,
                    UnitPrice = p.UnitPrice,
                    Discontinued = p.Discontinued,
                    UnitsInStock = p.UnitsInStock,
                    CategoryID = p.Category.CategoryID,
                    CategoryName = p.Category.CategoryName
                }).ToList();
            }
            return products;
        }

        public List<OrderDTO> GetOrders()
        {
            var orders = new List<OrderDTO>();
            using (Northwind context = new Northwind())
            {
                orders = context.Orders.Select(o => new OrderDTO
                {
                    OrderID = o.OrderID,
                    CustomerID = o.CustomerID,
                    EmployeeID = o.EmployeeID,
                    OrderDate = o.OrderDate,
                    ShipName = o.ShipName,
                    ShipAddress = o.ShipAddress,
                    ShipCity = o.ShipCity,
                    ShipRegion = o.ShipRegion,
                    ShipPostalCode = o.ShipPostalCode,
                    ShipCountry = o.ShipCountry
                }).ToList();
            }
            //Thread.Sleep(10000);
            return orders;
        }

        public void AddOrder()
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder(OrderDTO updatedOrder)
        {
            using (Northwind context = new Northwind())
            {
                var order = context.Orders.FirstOrDefault(o => o.OrderID == updatedOrder.OrderID);

                order.ShipAddress = updatedOrder.ShipAddress;
                order.ShipCity = updatedOrder.ShipCity;
                order.ShipCountry = updatedOrder.ShipCountry;
                order.ShipName = updatedOrder.ShipName;
                order.ShipPostalCode = updatedOrder.ShipPostalCode;
                order.ShipRegion = updatedOrder.ShipRegion;

                context.SaveChanges();
            }
        }

        public List<CustomerDTO> GetCustomers()
        {
            var customers = new List<CustomerDTO>();
            using (Northwind context = new Northwind())
            {
                customers = context.Customers.
                    Select(c => new CustomerDTO
                    {
                        CustomerID = c.CustomerID,
                        CompanyName = c.CompanyName
                    }).ToList();
            }
            return customers;
        }

        public List<EmployeeDTO> GetEmployees()
        {
            var employees = new List<EmployeeDTO>();
            using (Northwind context = new Northwind())
            {
                employees = context.Employees.
                    Select(c => new EmployeeDTO
                    {
                        EmployeeID = c.EmployeeID,
                        Name = c.FirstName + " " + c.LastName
                    }).ToList();
            }
            return employees;
        }

        public OrderDTO GetOrderByID(int orderID)
        {
            var order = new OrderDTO();
            using (Northwind context = new Northwind())
            {
                order = context.Orders.Select(o => new OrderDTO
                {
                    OrderID = o.OrderID,
                    CustomerID = o.CustomerID,
                    EmployeeID = o.EmployeeID,
                    OrderDate = o.OrderDate,
                    ShipName = o.ShipName,
                    ShipAddress = o.ShipAddress,
                    ShipCity = o.ShipCity,
                    ShipRegion = o.ShipRegion,
                    ShipPostalCode = o.ShipPostalCode,
                    ShipCountry = o.ShipCountry,
                    Items = o.Order_Details.Select(od => new OrderDetailsDTO
                    {
                        ProductID = od.ProductID,
                        ProductName = od.Product.ProductName,
                        Quantity = od.Quantity,
                        UnitPrice = od.UnitPrice,
                        Discount = od.Discount
                    }).ToList()
                }).FirstOrDefault(o => o.OrderID == orderID);
            }
            return order;
        }


    }
}
