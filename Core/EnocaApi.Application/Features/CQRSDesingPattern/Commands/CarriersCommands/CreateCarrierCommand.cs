using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaApi.Application.Features.CQRSDesingPattern.Commands.CarriersCommands
{
    public class CreateCarrierCommand
    {
       
        public string CarrierName { get; set; }

        public bool CarrrierIsActive { get; set; }

        public int CarrierPlusDesiCost { get; set; }

        public int CarrierConfigurationId { get; set; }

      
    }
}
