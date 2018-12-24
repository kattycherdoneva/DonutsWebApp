using DonutsWebApp.Data.Common;
using DonutsWebApp.Data.Models.Enum;
using System.Collections.Generic;

namespace DonutsWebApp.Data.Models
{

    public class Resource : BaseModel<int>
    {
        public Resource()
        {
            this.Comments = new HashSet<Comment>();
        }

        public string Name { get; set; }

        public string UserId { get; set; }
        public DonutsAppUser User { get; set; }

        public ResourceType ResourceType { get; set; }

        public PeopleType PeopleType { get; set; }

        public string Description { get; set; }

        public int? Rating { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
