using EnocaApi.Application.Features.CQRSDesingPattern.Commands.CarriersCommands;
using EnocaApi.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaApi.Application.Features.CQRSDesingPattern.Handlers.CarriersHandlers
{
    public class RemoveCarrierCommandHandler
    {
        private readonly EnocaContext _context;

        public RemoveCarrierCommandHandler(EnocaContext context)
        {
            _context = context;
        }

        public async Task Handler(RemoveCarrierCommand command)
        {
            var value = await _context.Carriers.FindAsync(command.CarriersId);
            _context.Carriers.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
