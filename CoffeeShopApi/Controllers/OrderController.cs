using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using CoffeeShopApi.Commands;
using CoffeeShopApi.Model;
using CoffeeShopApi.Queries;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Order> GetOrders()
        {
            var handler = new AllOrdersQueryHandler();
            return handler.Get();
        }

        [HttpGet]
        [Route("{id}")]
        public Order GetWidget(int id)
        {
            var query = new SingleOrderQuery(id);
            var handler = new SingleOrderQueryHandler(query);
            return handler.Get();
        }


        [HttpPost]
        public ActionResult<Order> CreateOrder(Order order)
        {
            var command = new AddOrderCommand(order);
            var handler = new AddOrderCommandHandler(command);
            var commandResponse = handler.Execute();
            if (!commandResponse.IsSuccess)
            {
                // Unsure what to return here. Need to look into the options
                return Problem(commandResponse.Message, statusCode: 500);
            }

            order.Id = commandResponse.Id;
            return order;
        }
    }
}
