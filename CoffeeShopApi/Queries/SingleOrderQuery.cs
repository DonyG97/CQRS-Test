using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShopApi.Model;

namespace CoffeeShopApi.Queries
{
    public class SingleOrderQuery: IQuery<Order>
    {
        public int Id;

        public SingleOrderQuery(int id)
        {
            Id = id;
        }
    }
}
