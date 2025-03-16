using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaApi.Application.Features.CQRSDesingPattern.Results.CarrierResult
{
    public class GetCarrierByIdQueryResult
    {
        public int CarriersId { get; set; }
        public string CarrierName { get; set; }
    }
}
