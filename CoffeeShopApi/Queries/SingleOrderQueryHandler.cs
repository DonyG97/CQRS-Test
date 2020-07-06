using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShopApi.DataContext;
using CoffeeShopApi.Model;

namespace CoffeeShopApi.Queries
{
    public class SingleOrderQueryHandler: IQueryHandler<SingleOrderQuery, Order>
    {
        private readonly SingleOrderQuery _query;

        public SingleOrderQueryHandler(SingleOrderQuery query)
        {
            _query = query;
        }

        public Order Get()
        {
            return DemoOrderContext.Orders.FirstOrDefault(x => x.Id == _query.Id);
        }
    }
}
