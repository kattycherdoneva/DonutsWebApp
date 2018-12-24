using DonutsWebApp.Data.Common;
using System.Collections.Generic;

namespace DonutsWebApp.Data.Models
{
    public class Receipt : BaseModel<int>
    {
        public Receipt()
        {
            this.ProductForReceipts = new HashSet<ProductForReceipt>();
        }

        public ICollection<ProductForReceipt> ProductForReceipts { get; set; }
    }
}
