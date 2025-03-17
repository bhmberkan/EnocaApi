using EnocaApi.Application.Features.CQRSDesingPattern.Results.OrderResult;
using EnocaApi.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaApi.Application.Features.CQRSDesingPattern.Handlers.OrderHandlers
{
    public class GetOrderQueryHandler
    {
        private readonly EnocaContext _context;

        public GetOrderQueryHandler(EnocaContext context)
        {
            _context = context;
        }

        public async Task<List<GetOrderQueryResult>> Handle()
        {
            var values = await _context.Orders.ToListAsync();
            return values.Select(x=>new GetOrderQueryResult()
            {
               OrdersId = x.OrdersId,
                carriersId = x.carriersId,
                OrderDate = x.OrderDate,
                OrderCarrierCost = x.OrderCarrierCost,
                OrderDesi=x.OrderDesi

            }).ToList();
        }
    }
}

