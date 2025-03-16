using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaApi.Application.Features.CQRSDesingPattern.Commands.OrdersCommands
{
    public class UpdateOrderCommand
    {
        public int OrdersId { get; set; }

        public int OrderDesi { get; set; }
        public DateTime OrderDate { get; set; }

        public decimal ORderCarrierCost { get; set; }

        public int CarrierId { get; set; }
    }
}
