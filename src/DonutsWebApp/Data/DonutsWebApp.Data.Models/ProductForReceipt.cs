using DonutsWebApp.Data.Common;

namespace DonutsWebApp.Data.Models
{
    public class ProductForReceipt : BaseModel<int>
    {
        public string Name { get; set; }    
    }
}
