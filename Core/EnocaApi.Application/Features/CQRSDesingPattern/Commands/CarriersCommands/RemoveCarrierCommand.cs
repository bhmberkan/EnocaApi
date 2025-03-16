using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaApi.Application.Features.CQRSDesingPattern.Commands.CarriersCommands
{
    public class RemoveCarrierCommand
    {
        public RemoveCarrierCommand(int carriersId)
        {
            CarriersId = carriersId;
        }

        public int CarriersId { get; set; }
    }
}
