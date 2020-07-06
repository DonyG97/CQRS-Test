using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShopApi.DataContext;
using CoffeeShopApi.Model;

namespace CoffeeShopApi.Commands
{
    public class AddOrderCommandHandler: ICommandHandler<AddOrderCommand, OrderCommandResponse>
    {
        private readonly AddOrderCommand _command;

        public AddOrderCommandHandler(AddOrderCommand command)
        {
            _command = command;
        }

        public OrderCommandResponse Execute()
        {
            var response = new OrderCommandResponse
            {
                IsSuccess = true
            };

            try
            {
                // Could potentially check if the order already exists but realistically people can make the same order twice

                DemoOrderContext.AddOrder(_command.Order);
            }
            catch (Exception e)
            {
                // TODO: Some nlogging
                response.IsSuccess = false;
                // Do we really want to expose the error
                //response.Message = $"Error: {e}";
            }

            return response;
        }
    }
}
