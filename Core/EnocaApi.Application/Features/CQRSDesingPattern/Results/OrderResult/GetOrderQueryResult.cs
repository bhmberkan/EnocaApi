using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaApi.Application.Features.CQRSDesingPattern.Results.OrderResult
{
    public class GetOrderQueryResult
    {
        public int OrdersId { get; set; }

        public int OrderDesi { get; set; }
        public DateTime OrderDate { get; set; }

        public decimal OrderCarrierCost { get; set; }
        public int carriersId { get; set; }
    }
}
