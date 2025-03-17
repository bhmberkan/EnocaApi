using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaApi.Application.Features.CQRSDesingPattern.Results.CarrierResult
{
    public class GetCArrierQueryResult
    {
        public int CarriersId { get; set; }
        public string CarrierName { get; set; }

        public bool CarrrierIsActive { get; set; }

        public int CarrierPlusDesiCost { get; set; }

        public int CarrierConfigurationId { get; set; }
    }
}
