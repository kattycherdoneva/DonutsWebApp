using DonutsWebApp.Data.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace DonutsWebApp.Data.Models
{
    public class Donation : BaseModel<int>
    {
        public string UserId { get; set; }
        public DonutsAppUser User { get; set; }

        public int? TotalNumberOfDonuts { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal ТotalАmountОfМoney { get; set; }

        public bool DonationThroughCompany { get; set; }
    }
}
