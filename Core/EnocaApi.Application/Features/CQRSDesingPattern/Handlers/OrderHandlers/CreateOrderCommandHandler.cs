using EnocaApi.Application.Features.CQRSDesingPattern.Commands.CarriersCommands;
using EnocaApi.Application.Features.CQRSDesingPattern.Commands.OrdersCommands;
using EnocaApi.Domain.Entities;
using EnocaApi.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaApi.Application.Features.CQRSDesingPattern.Handlers.OrderHandlers
{
    public class CreateOrderCommandHandler
    {
        private readonly EnocaContext _context;

        public CreateOrderCommandHandler(EnocaContext context)
        {
            _context = context;
        }

        public async Task Handler(CreateOrderCommand command)
        {
            //suitableCarriers uygun kargo
            // closestCarrier  en yakın taşıyıcı
            // differenceDesi desi farkı

            var orderDesi = command.OrderDesi;
            var suitableCarriers = _context.CarrierConfigurations
                .Where(x=> orderDesi>= x.CarrierMinDesi && orderDesi<=x.CarrierMaxDesi)
                .OrderBy(x=>x.CarrierCost)
                .FirstOrDefault();

            decimal orderCarrierCost;
            if (suitableCarriers != null)
            {
                orderCarrierCost = suitableCarriers.CarrierCost;
            }
            else
            {
                var closestCarrier = _context.CarrierConfigurations
                    .OrderBy(c=> Math.Abs(c.CarrierMinDesi-orderDesi))
                    .FirstOrDefault();
                if (closestCarrier != null)
                {
                 int differenceDesi =  orderDesi - closestCarrier.CarrierMaxDesi;
                    if (differenceDesi > 0)
                    {
                        var carrier = _context.Carriers
                            .FirstOrDefault(c => c.CarriersId == closestCarrier.carriersId);
                        if (carrier != null)
                        {
                            orderCarrierCost = closestCarrier.CarrierCost - (differenceDesi * carrier.CarrierPlusDesiCost);
                        }
                        else
                        {
                            orderCarrierCost = closestCarrier.CarrierCost;
                        }
                    }
                    else
                    {
                        orderCarrierCost = closestCarrier.CarrierCost;
                    }
                }
                else
                {
                    orderCarrierCost= 0;
                }
            }

           
            _context.Orders.Add(new Orders()
                {
                OrderDesi = command.OrderDesi,
                OrderDate = command.OrderDate,
                OrderCarrierCost = orderCarrierCost,
                carriersId = suitableCarriers?.carriersId ?? 0,
            });
            await _context.SaveChangesAsync();

          
        }
    }
}
