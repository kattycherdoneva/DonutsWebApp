using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using DonutsWebApp.Data.Common;
using DonutsWebApp.Data.Models.Enum;

namespace DonutsWebApp.Data.Models
{
    public class Item : BaseModel<int>
    {
        public Item()
        {
            this.Comments = new HashSet<Comment>();
        }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public FoodType FoodType { get; set; }

        public ProductType ProductType { get; set; }

        public string Description { get; set; }

        public int? Rating { get; set; }

        public byte[] Image { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
