﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaApi.Domain.Entities
{
    public class Orders
    {
        public int OrdersId { get; set; }
    

        public int OrderDesi { get; set; }
        public DateTime OrderDate { get; set; }

        public decimal OrderCarrierCost { get; set; }

      
        // ilişki 
        public int carriersId { get; set; }

        public Carriers Carriers { get; set; }
    }
}
