﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaApi.Application.Features.CQRSDesingPattern.Commands.OrdersCommands
{
    public class RemoveOrderCommand
    {
        public RemoveOrderCommand(int ordersId)
        {
            OrdersId = ordersId;
        }

        public int OrdersId { get; set; }


    }
}
