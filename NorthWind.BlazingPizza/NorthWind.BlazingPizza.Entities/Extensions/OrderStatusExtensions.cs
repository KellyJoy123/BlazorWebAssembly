using NorthWind.BlazingPizza.Entities.Enums;
using NorthWind.BlazingPizza.Entities.Resources;


namespace NorthWind.BlazingPizza.Entities.Extensions
{
    public static class OrderStatusExtensions
    {
        public static string ToDriendlyString(this OrderStatus status) =>
            status switch
            {
                OrderStatus.Preparing => Messages.PrepparingText,
                OrderStatus.OutForDelivery => Messages.OutForDeliveryText,
                OrderStatus.Delivered => Messages.DeliveredText,
                _ => Messages.UnknowStatusText
            };
    }
}
