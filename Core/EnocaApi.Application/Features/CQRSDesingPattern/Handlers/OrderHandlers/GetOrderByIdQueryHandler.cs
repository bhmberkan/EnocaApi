using EnocaApi.Application.Features.CQRSDesingPattern.Queries.CarrierQueries;
using EnocaApi.Application.Features.CQRSDesingPattern.Queries.OrderQueries;
using EnocaApi.Application.Features.CQRSDesingPattern.Results.CarrierResult;
using EnocaApi.Application.Features.CQRSDesingPattern.Results.OrderResult;
using EnocaApi.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaApi.Application.Features.CQRSDesingPattern.Handlers.OrderHandlers
{
    public class GetOrderByIdQueryHandler
    {
        private readonly EnocaContext _context;

        public GetOrderByIdQueryHandler(EnocaContext context)
        {
            _context = context;
        }
        
        public async Task<GetOrderByIdQueryResult> Handler(GetOrderByIdQuery query)
        {
          var value = await _context.Orders.FindAsync(query.OrdersId);
            return new GetOrderByIdQueryResult
            {
              OrdersId = value.OrdersId,
              carriersId=value.carriersId
             
            };
        }
    }
}
