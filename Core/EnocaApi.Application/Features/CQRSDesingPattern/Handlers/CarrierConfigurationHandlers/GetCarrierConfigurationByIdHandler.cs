using EnocaApi.Application.Features.CQRSDesingPattern.Queries.CarrierConfigurationQueries;
using EnocaApi.Application.Features.CQRSDesingPattern.Results.CarrierConfigurationResult;
using EnocaApi.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaApi.Application.Features.CQRSDesingPattern.Handlers.CarrierConfigurationHandlers
{
    public class GetCarrierConfigurationByIdHandler 
    {
        private readonly EnocaContext _context;

        public GetCarrierConfigurationByIdHandler(EnocaContext context)
        {
            _context = context;
        }

       

          public async Task<GetCarrierConfigurationByIdQueryResult> Handle(GetCarrierConfigurationByIdQuery query)
          {
              var value = await _context.CarrierConfigurations.FindAsync(query.CarrierConfigurationsId);
              return new GetCarrierConfigurationByIdQueryResult
              {
                  CarrierConfigurationsId = value.CarrierConfigurationsId,
                  CarrierMaxDesi=value.CarrierMaxDesi,
                  CarrierMinDesi=value.CarrierMinDesi,
                  CarrierCost=value.CarrierCost,
                  carriersId=value.carriersId
              };
          }


    }
}
