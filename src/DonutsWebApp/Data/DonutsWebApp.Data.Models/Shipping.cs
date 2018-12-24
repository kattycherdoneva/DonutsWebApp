using System;
using DonutsWebApp.Data.Common;

namespace DonutsWebApp.Data.Models
{

    public class Shipping : BaseModel<int>
    {
        private const decimal priceForCardAndGiftBox = 5.00m;

        public string UserId { get; set; }
        public DonutsAppUser User { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string Аddress { get; set; }

        public bool IsShippingAnonymous { get; set; }

        public bool IsThisForGift { get; set; }

        public DateTime DeliveryDate { get; set; }

        public int BasketId { get; set; }
        public Basket Basket { get; set; }

        public decimal OrderTotal => GetOrderTotal();

        private decimal GetOrderTotal()
        {
            decimal orderTotal = this.Basket.OrderTotal
                + (this.IsThisForGift == true ? priceForCardAndGiftBox : 0);

            return orderTotal;
        }
    }
}
