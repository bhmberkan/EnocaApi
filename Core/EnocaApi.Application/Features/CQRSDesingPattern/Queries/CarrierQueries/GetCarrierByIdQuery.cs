using EnocaApi.Application.Features.CQRSDesingPattern.Results.CarrierResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaApi.Application.Features.CQRSDesingPattern.Queries.CarrierQueries
{
    public class GetCarrierByIdQuery 
    {
        public GetCarrierByIdQuery(int carriersId)
        {
            CarriersId = carriersId;
        }

        public int CarriersId { get; set; }
        
    }
}
