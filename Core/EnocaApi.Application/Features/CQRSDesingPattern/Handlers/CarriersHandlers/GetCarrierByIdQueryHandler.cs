using EnocaApi.Application.Features.CQRSDesingPattern.Queries.CarrierQueries;
using EnocaApi.Application.Features.CQRSDesingPattern.Results.CarrierResult;
using EnocaApi.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaApi.Application.Features.CQRSDesingPattern.Handlers.CarriersHandlers
{
    public class GetCarrierByIdQueryHandler
    {
        private readonly EnocaContext _context;

        public GetCarrierByIdQueryHandler(EnocaContext context)
        {
            _context = context;
        }

        public async Task<GetCarrierByIdQueryResult> Handle(GetCarrierByIdQuery query)
        {
            var value = await _context.Carriers.FindAsync(query.CarriersId);
            return new GetCarrierByIdQueryResult
            {
                CarriersId = value.CarriersId,
                CarrierName =  value.CarrierName
            };
        }
    }
}
