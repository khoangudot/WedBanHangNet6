using System;
using System.Collections.Generic;

namespace WedBanHangNet6.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Price { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Image { get; set; }
        public string? Video { get; set; }
        public bool HomeFlag { get; set; }
        public bool BestSale { get; set; }
        public bool Active { get; set; }
        public int UnitslnStock { get; set; }
        public int CateId { get; set; }
        public int? OrderDetailId { get; set; }

        public virtual Category Cate { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
