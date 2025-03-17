using EnocaApi.Application.Features.CQRSDesingPattern.Commands.CarriersCommands;
using EnocaApi.Application.Features.CQRSDesingPattern.Commands.OrdersCommands;
using EnocaApi.Application.Features.CQRSDesingPattern.Handlers.CarriersHandlers;
using EnocaApi.Application.Features.CQRSDesingPattern.Handlers.OrderHandlers;
using EnocaApi.Application.Features.CQRSDesingPattern.Queries.CarrierQueries;
using EnocaApi.Application.Features.CQRSDesingPattern.Queries.OrderQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EnocaApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly GetOrderQueryHandler _getOrderQueryHandler;
        private readonly GetOrderByIdQueryHandler _getOrderByIdQueryHandler;
        private readonly CreateOrderCommandHandler _createOrderCommandHandler;
        private readonly UpdateOrderCommandHandler _updateOrderCommandHandler;
        private readonly RemoveOrderCommandHandler _removeOrderCommandHandler;

        public OrdersController(GetOrderQueryHandler getOrderQueryHandler,
            GetOrderByIdQueryHandler getOrderByIdQueryHandler,
            CreateOrderCommandHandler createOrderCommandHandler,
            UpdateOrderCommandHandler updateOrderCommandHandler,
            RemoveOrderCommandHandler removeOrderCommandHandler)
        {
            _getOrderQueryHandler = getOrderQueryHandler;
            _getOrderByIdQueryHandler = getOrderByIdQueryHandler;
            _createOrderCommandHandler = createOrderCommandHandler;
            _updateOrderCommandHandler = updateOrderCommandHandler;
            _removeOrderCommandHandler = removeOrderCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrderList()
        {
            var values = await _getOrderQueryHandler.Handle();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(CreateOrderCommand command)
        {
            await _createOrderCommandHandler.Handler(command);
            return Ok("Carrier Ekleme işlemi başarılı");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            await _removeOrderCommandHandler.Handle(new RemoveOrderCommand(id));
            return Ok("Carrier Silme işlemi başarılı");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOrder(/*UpdateCarrierCommand command*/)
        {
            /* await _updateOrderCommandHandler.Handler(command);
             return Ok("Carrier Güncelleme işlemi başarılı");*/

            return Ok("Projede istenmemıştı");
        }

        [HttpGet("GetOrder")]
        public async Task<IActionResult> GetOrder(int id)
        {
            var value = await _getOrderByIdQueryHandler.Handler(new GetOrderByIdQuery(id));
            return Ok(value);
        }
    }
}
