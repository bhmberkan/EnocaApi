using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaApi.Domain.Entities
{
    public class CarrierConfigurations
    {
        public int CarrierConfigurationsId { get; set; }
        public int CarrierMaxDesi {  get; set; }
        public int CarrierMinDesi {  get; set; }
        public decimal CarrierCost { get; set; }

        // ilişki
          public int carriersId { get; set; }

        public Carriers Carriers { get; set; }
    }
}



