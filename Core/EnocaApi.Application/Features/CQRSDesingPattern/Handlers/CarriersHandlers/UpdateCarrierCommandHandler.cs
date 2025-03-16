using EnocaApi.Application.Features.CQRSDesingPattern.Commands.CarriersCommands;
using EnocaApi.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaApi.Application.Features.CQRSDesingPattern.Handlers.CarriersHandlers
{
    public class UpdateCarrierCommandHandler
    {
        private readonly EnocaContext _context;

        public UpdateCarrierCommandHandler(EnocaContext context)
        {
            _context = context;
        }

        public async Task Handler(UpdateCarrierCommand command)
        {
            var value = await _context.Carriers.FindAsync(command.CarriersId);
            value.CarrierName = command.CarrierName;
            value.CarrrierIsActive = command.CarrrierIsActive;
            value.CarrierPlusDesiCost = command.CarrierPlusDesiCost;
            value.CarrierConfigurationId = command.CarrierConfigurationId;
            await _context.SaveChangesAsync();
        }
    }
}
