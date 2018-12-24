using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace DonutsWebApp.Data.Models
{
    // Add profile data for application users by adding properties to the DonutsAppUser class
    public class DonutsAppUser : IdentityUser
    {
        public DonutsAppUser()
        {
            this.Donations = new HashSet<Donation>();
            this.Shippings = new HashSet<Shipping>();
            this.Resources = new HashSet<Resource>();
            this.Comments = new HashSet<Comment>();
        }

        public int BasketId { get; set; }
        public Basket Basket { get; set; }

        public int Points { get; set; }

        public ICollection<Donation> Donations { get; set; }

        public ICollection<Shipping> Shippings { get; set; }

        public ICollection<Resource> Resources { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
