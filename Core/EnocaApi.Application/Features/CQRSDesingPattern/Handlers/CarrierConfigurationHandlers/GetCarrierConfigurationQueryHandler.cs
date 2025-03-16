using EnocaApi.Application.Features.CQRSDesingPattern.Queries.CarrierConfigurationQueries;
using EnocaApi.Application.Features.CQRSDesingPattern.Results.CarrierConfigurationResult;
using EnocaApi.Application.Features.CQRSDesingPattern.Results.CarrierResult;
using EnocaApi.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaApi.Application.Features.CQRSDesingPattern.Handlers.CarrierConfigurationHandlers
{
    public class GetCarrierConfigurationQueryHandler
    {
        private readonly EnocaContext _context;

        public GetCarrierConfigurationQueryHandler(EnocaContext context)
        {
            _context = context;
        }

        

         public async Task<List<GetCarrierConfigurationQueryResult>> Handle()
         {
             var values = await _context.CarrierConfigurations.ToListAsync();
             return values.Select(x=> new GetCarrierConfigurationQueryResult()
             {
                 CarrierConfigurationsId = x.CarrierConfigurationsId,
                 CarrierMaxDesi=x.CarrierMaxDesi,
                 CarrierMinDesi=x.CarrierMinDesi,
                 CarrierCost=x.CarrierCost,
                 carriersId=x.carriersId
             }).ToList(); 

            
        }

    }
}
