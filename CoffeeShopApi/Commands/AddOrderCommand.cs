using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShopApi.Model;

namespace CoffeeShopApi.Commands
{
    public class AddOrderCommand: ICommand<OrderCommandResponse>
    {
        public Order Order;

        public AddOrderCommand(Order order)
        {
            Order = order;
        }

    }
}
