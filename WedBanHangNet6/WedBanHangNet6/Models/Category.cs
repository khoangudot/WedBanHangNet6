using System;
using System.Collections.Generic;

namespace WedBanHangNet6.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CateId { get; set; }
        public string CateName { get; set; } = null!;
        public string? Description { get; set; }
        public bool? Published { get; set; }
        public string? Title { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
