using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShopApi.DataContext;
using CoffeeShopApi.Model;

namespace CoffeeShopApi.Queries
{
    public class AllOrdersQueryHandler: IQueryHandler<AllOrdersQuery, IEnumerable<Order>>
    {
        // Should this not be using the AllOrdersQuery model somehow
        public IEnumerable<Order> Get()
        {
            return DemoOrderContext.Orders;
        }
    }
}
