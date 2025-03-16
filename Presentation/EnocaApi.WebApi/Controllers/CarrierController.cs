using EnocaApi.Application.Features.CQRSDesingPattern.Commands.CarriersCommands;
using EnocaApi.Application.Features.CQRSDesingPattern.Handlers.CarriersHandlers;
using EnocaApi.Application.Features.CQRSDesingPattern.Queries.CarrierQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EnocaApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrierController : ControllerBase
    {
        private readonly GetCarrierByIdQueryHandler _getCarrierByIdQueryHandler;
        private readonly GetCarrierQueryHandler _getCarrierQueryHandler;
        private readonly CreateCarrierCommandHandler _createCarrierCommandHandler;
        private readonly UpdateCarrierCommandHandler _updateCarrierCommandHandler;
        private readonly RemoveCarrierCommandHandler _removeCarrierCommandHandler;

        public CarrierController(GetCarrierByIdQueryHandler getCarrierByIdQueryHandler,
            GetCarrierQueryHandler getCarrierQueryHandler,
            CreateCarrierCommandHandler createCarrierCommandHandler, 
            UpdateCarrierCommandHandler updateCarrierCommandHandler,
            RemoveCarrierCommandHandler removeCarrierCommandHandler)
        {
            _getCarrierByIdQueryHandler = getCarrierByIdQueryHandler;
            _getCarrierQueryHandler = getCarrierQueryHandler;
            _createCarrierCommandHandler = createCarrierCommandHandler;
            _updateCarrierCommandHandler = updateCarrierCommandHandler;
            _removeCarrierCommandHandler = removeCarrierCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> GetCarrierList()
        {
            var value = await _getCarrierQueryHandler.Handle();
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCarrier(CreateCarrierCommand command)
        {
            await _createCarrierCommandHandler.Handler(command);
            return Ok("Carrier Ekleme işlemi başarılı");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCarrier(int id)
        {
            await _removeCarrierCommandHandler.Handler(new RemoveCarrierCommand(id));
            return Ok("Carrier Silme işlemi başarılı");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCarrier(UpdateCarrierCommand command)
        {
            await _updateCarrierCommandHandler.Handler(command);
            return Ok("Carrier Güncelleme işlemi başarılı");
        }

        [HttpGet("GetCarrier")]
        public async Task<IActionResult> GetCarrier(int id)
        {
            var value = await _getCarrierByIdQueryHandler.Handle(new GetCarrierByIdQuery(id));
            return Ok(value);
        }
    }
}
