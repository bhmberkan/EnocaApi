using EnocaApi.Application.Features.CQRSDesingPattern.Commands.CarrierConfigurationCommands;
using EnocaApi.Domain.Entities;
using EnocaApi.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaApi.Application.Features.CQRSDesingPattern.Handlers.CarrierConfigurationHandlers
{
    public class CreateCarrierConfigurationCommandHandler 
    {
        private readonly EnocaContext _enocaContext;

        public CreateCarrierConfigurationCommandHandler(EnocaContext enocaContext)
        {
            _enocaContext = enocaContext;
        }

        public async Task Handler(CreateCarrierConfigurationCommand command)
        {
            _enocaContext.CarrierConfigurations.Add(new CarrierConfigurations
            {
                CarrierMaxDesi = command.CarrierMaxDesi,
                CarrierMinDesi = command.CarrierMinDesi,
                CarrierCost = command.CarrierCost,
                carriersId = command.carriersId

            });
            await _enocaContext.SaveChangesAsync();
        }
    }
}
