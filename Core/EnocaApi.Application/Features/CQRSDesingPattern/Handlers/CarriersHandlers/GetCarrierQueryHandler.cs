using EnocaApi.Application.Features.CQRSDesingPattern.Results.CarrierResult;
using EnocaApi.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaApi.Application.Features.CQRSDesingPattern.Handlers.CarriersHandlers
{
    public class GetCarrierQueryHandler
    {
        private readonly EnocaContext _context;

        public GetCarrierQueryHandler(EnocaContext context)
        {
            _context = context;
        }

        public async Task<List<GetCArrierQueryResult>> Handle()
        {
            var values = await _context.Carriers.ToListAsync();
            return values.Select(x => new GetCArrierQueryResult()
            {
                CarriersId = x.CarriersId,
                CarrierName = x.CarrierName

            }).ToList();
        }
    }
}
