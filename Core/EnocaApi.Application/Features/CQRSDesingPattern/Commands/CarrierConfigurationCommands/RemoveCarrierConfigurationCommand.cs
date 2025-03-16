using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaApi.Application.Features.CQRSDesingPattern.Commands.CarrierConfigurationCommands
{
    public class RemoveCarrierConfigurationCommand 
    {
        public int CarrierConfigurationsId { get; set; }
        
    }
}
