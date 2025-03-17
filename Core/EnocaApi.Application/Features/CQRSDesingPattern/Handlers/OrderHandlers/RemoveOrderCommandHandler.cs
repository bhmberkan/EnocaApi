using EnocaApi.Application.Features.CQRSDesingPattern.Commands.OrdersCommands;
using EnocaApi.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaApi.Application.Features.CQRSDesingPattern.Handlers.OrderHandlers
{
    public class RemoveOrderCommandHandler
    {
        private readonly EnocaContext _context;

        public RemoveOrderCommandHandler(EnocaContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveOrderCommand command)
        {
            var values = await _context.Orders.FindAsync(command.OrdersId);
            _context.Orders.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
