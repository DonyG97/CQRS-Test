using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShopApi.Model;

namespace CoffeeShopApi.DataContext
{
    public static class DemoOrderContext
    {
        public static IList<Order> Orders;
        public static int OrderId = 4;

        static DemoOrderContext()
        {
            Orders = new List<Order>()
            {
                new Order
                {
                    CoffeeOrder = "Americano",
                    CustomerName = "Tony",
                    Id = 0
                },
                new Order
                {
                    CoffeeOrder = "White coffee",
                    CustomerName = "John",
                    Id = 1
                },
                new Order
                {
                    CoffeeOrder = "Black coffee",
                    CustomerName = "Jon",
                    Id = 2
                },
                new Order
                {
                    CoffeeOrder = "Pumpkin spice latte",
                    CustomerName = "Jan",
                    Id = 3
                }
            };
        }

        public static void AddOrder(Order order)
        {
            order.Id = OrderId++;
            Orders.Add(order);
        }
    }
}
