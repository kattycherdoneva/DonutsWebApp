using DonutsWebApp.Data.Common;

namespace DonutsWebApp.Data.Models
{
    public class Comment : BaseModel<int>
    {
        public string UserId { get; set; }
        public DonutsAppUser User { get; set; }

        public int? ProductId { get; set; }
        public Item Product { get; set; }

        public int? ResourceId { get; set; }
        public Resource Resource { get; set; }

        public string Text { get; set; }
    }
}
