using EnocaApi.Application.Features.CQRSDesingPattern.Commands.CarrierConfigurationCommands;
using EnocaApi.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EnocaApi.Application.Features.CQRSDesingPattern.Handlers.CarrierConfigurationHandlers
{
    public class UpdateCarrierConfigurationCommandHandler 
    {
        private readonly EnocaContext _context;

        public UpdateCarrierConfigurationCommandHandler(EnocaContext context)
        {
            _context = context;
        }

     

        public async Task Handler(UpdateCarrierConfigurationCommand command)
        {
            var value = await _context.CarrierConfigurations.FindAsync(command.CarrierConfigurationsId);
            value.CarrierMaxDesi=command.CarrierMaxDesi;
            value.CarrierMaxDesi=command.CarrierMinDesi;
            value.CarrierCost=command.CarrierCost;
            value.carriersId = command.carriersId;
            await _context.SaveChangesAsync();
        }
        
    }
}
