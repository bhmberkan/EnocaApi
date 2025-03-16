using EnocaApi.Application.Features.CQRSDesingPattern.Results.CarrierConfigurationResult;
using EnocaApi.Application.Features.CQRSDesingPattern.Results.CarrierResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaApi.Application.Features.CQRSDesingPattern.Queries.CarrierConfigurationQueries
{
    public class GetCarrierConfigurationByIdQuery 
    {
        public GetCarrierConfigurationByIdQuery(int carrierConfigurationsId)
        {
            CarrierConfigurationsId = carrierConfigurationsId;
        }

        public int CarrierConfigurationsId { get; set; }
       
    }
}
