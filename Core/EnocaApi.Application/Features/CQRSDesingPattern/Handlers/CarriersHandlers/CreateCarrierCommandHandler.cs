
using EnocaApi.Application.Features.CQRSDesingPattern.Commands.CarriersCommands;
using EnocaApi.Domain.Entities;
using EnocaApi.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaApi.Application.Features.CQRSDesingPattern.Handlers.CarriersHandlers
{
    public class CreateCarrierCommandHandler
    {
        private readonly EnocaContext _context;
       

        public CreateCarrierCommandHandler(EnocaContext context)
        {
            _context = context;
          
        }

        public async Task Handler(CreateCarrierCommand command)
        {
          // Manuel mapleme

            _context.Carriers.Add(new Carriers
            {
                CarrierName = command.CarrierName,
                CarrrierIsActive=command.CarrrierIsActive,
                CarrierPlusDesiCost=command.CarrierPlusDesiCost,
                CarrierConfigurationId = command.CarrierConfigurationId
               
            });        
            await _context.SaveChangesAsync();
        }
    }
}
