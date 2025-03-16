using EnocaApi.Application.Features.CQRSDesingPattern.Commands.CarrierConfigurationCommands;
using EnocaApi.Application.Features.CQRSDesingPattern.Commands.CarriersCommands;
using EnocaApi.Application.Features.CQRSDesingPattern.Handlers.CarrierConfigurationHandlers;
using EnocaApi.Application.Features.CQRSDesingPattern.Handlers.CarriersHandlers;
using EnocaApi.Application.Features.CQRSDesingPattern.Queries.CarrierConfigurationQueries;
using EnocaApi.Persistence;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EnocaApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrierConfigurationController : ControllerBase
    {
        private readonly GetCarrierConfigurationByIdHandler _getCarrierConfigurationByIdHandler;
        private readonly GetCarrierConfigurationQueryHandler _getCarrierConfigurationQueryHandler;
        private readonly CreateCarrierConfigurationCommandHandler _createCarrierConfigurationCommandHandler;
        private readonly UpdateCarrierConfigurationCommandHandler _updateCarrierConfigurationCommandHandler;
        private readonly RemoveCarrierConfigurationCommandHandler _removeCarrierConfigurationCommandHandler;

        public CarrierConfigurationController(GetCarrierConfigurationByIdHandler getCarrierConfigurationByIdHandler,
            GetCarrierConfigurationQueryHandler getCarrierConfigurationQueryHandler, 
            CreateCarrierConfigurationCommandHandler createCarrierConfigurationCommandHandler,
            UpdateCarrierConfigurationCommandHandler updateCarrierConfigurationCommandHandler,
            RemoveCarrierConfigurationCommandHandler removeCarrierConfigurationCommandHandler)
        {
            _getCarrierConfigurationByIdHandler = getCarrierConfigurationByIdHandler;
            _getCarrierConfigurationQueryHandler = getCarrierConfigurationQueryHandler;
            _createCarrierConfigurationCommandHandler = createCarrierConfigurationCommandHandler;
            _updateCarrierConfigurationCommandHandler = updateCarrierConfigurationCommandHandler;
            _removeCarrierConfigurationCommandHandler = removeCarrierConfigurationCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> GetCarrierConfigurationList()
        {
            var value = await _getCarrierConfigurationQueryHandler.Handle();
            return Ok(value);

        }

        [HttpPost]
        public async Task<IActionResult> CreateCarrierConfiguration(CreateCarrierConfigurationCommand command)
        {
            await _createCarrierConfigurationCommandHandler.Handler(command);
            return Ok("Ekleme işlemi başarılı");
            
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCarrierConfiguration(UpdateCarrierConfigurationCommand command)
        {
            await _updateCarrierConfigurationCommandHandler.Handler(command);
            return Ok("Güncelleme işlemi başarılı");
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteCarrierConfiguration(RemoveCarrierConfigurationCommand command)
        {
            await _removeCarrierConfigurationCommandHandler.Handler(command);
            return Ok("Silindi");
        }

        [HttpGet("GetCarrierConfiguration")]
        public async Task<IActionResult> GetCarrierConfiguration(int id)
        {
            var value  = await _getCarrierConfigurationByIdHandler.Handle(new GetCarrierConfigurationByIdQuery(id));
            return Ok(value);
        }

    }
}
