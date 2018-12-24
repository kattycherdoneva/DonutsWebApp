using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using DonutsWebApp.Data.Common;

namespace DonutsWebApp.Data.Models
{
    public class Basket : BaseModel<int>
    {
        public Basket()
        {
            this.Products = new HashSet<Item>();
        }

        [Key, ForeignKey("User")]
        public string UserId { get; set; }
        public DonutsAppUser User { get; set; }

        public ICollection<Item> Products { get; set; }

        public int? ProductsCount => this.Products.Count;

        [Column(TypeName = "decimal(18,2)")]
        [DefaultValue(0.00)]
        public decimal GiftMoney { get; set; }

        public decimal OrderTotal => GetOrderTotal();

        private decimal GetOrderTotal()
        {
            decimal priceOnProducts = decimal.Parse(this.Products.Sum(x => x.Price).ToString());
            if(priceOnProducts == 0)
            {
                return 0;
            }

            decimal totalOrder = priceOnProducts - this.GiftMoney;
            if(totalOrder < 0)
            {
                this.GiftMoney = totalOrder;
                return 0;
            }
            else
            {
                this.GiftMoney = 0;
                return totalOrder;
            }
        }
    }
}
