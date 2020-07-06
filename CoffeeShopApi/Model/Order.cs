using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace CoffeeShopApi.Model
{
    public class Order
    {
        // Need a validator on here so they can't set the order id
        public int Id;

        public string CustomerName;

        public string CoffeeOrder;
    }

    // This could in theory be made generic, if we're just returning the Id of the created object
    public class OrderCommandResponse
    {
        public int Id;

        public bool IsSuccess;

        public string Message;
    }
}
