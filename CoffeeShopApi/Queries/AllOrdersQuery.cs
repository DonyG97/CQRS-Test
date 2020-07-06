using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShopApi.DataContext;
using CoffeeShopApi.Model;

namespace CoffeeShopApi.Queries
{
    public class AllOrdersQuery: IQuery<Order>, IQuery<IEnumerable<Order>>
    {

    }
}
