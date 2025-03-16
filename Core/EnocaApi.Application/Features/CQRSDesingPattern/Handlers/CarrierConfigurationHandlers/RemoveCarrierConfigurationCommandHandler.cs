using EnocaApi.Application.Features.CQRSDesingPattern.Commands.CarrierConfigurationCommands;
using EnocaApi.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaApi.Application.Features.CQRSDesingPattern.Handlers.CarrierConfigurationHandlers
{
    public class RemoveCarrierConfigurationCommandHandler 
    {
        private readonly EnocaContext _context;

        public RemoveCarrierConfigurationCommandHandler(EnocaContext context)
        {
            _context = context;
        }


        public async Task Handler(RemoveCarrierConfigurationCommand command)
        {
            var value = await _context.CarrierConfigurations.FindAsync(command.CarrierConfigurationsId);
            _context.CarrierConfigurations.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
