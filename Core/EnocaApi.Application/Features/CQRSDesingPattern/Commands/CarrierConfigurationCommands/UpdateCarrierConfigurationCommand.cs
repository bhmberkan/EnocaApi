using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaApi.Application.Features.CQRSDesingPattern.Commands.CarrierConfigurationCommands
{
    public class UpdateCarrierConfigurationCommand 
    {
        public int CarrierConfigurationsId { get; set; }
        public int CarrierMaxDesi { get; set; }
        public int CarrierMinDesi { get; set; }
        public decimal CarrierCost { get; set; }
        public int carriersId { get; set; }
    }
}
