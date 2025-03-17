using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaApi.Application.Features.CQRSDesingPattern.Queries.OrderQueries
{
    public class GetOrderByIdQuery
    {
        public GetOrderByIdQuery(int ordersId)
        {
            OrdersId = ordersId;
        }

        public int OrdersId { get; set; }

    }
}
