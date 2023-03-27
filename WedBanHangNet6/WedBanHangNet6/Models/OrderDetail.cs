using System;
using System.Collections.Generic;

namespace WedBanHangNet6.Models
{
    public partial class OrderDetail
    {
        public OrderDetail()
        {
            Shippers = new HashSet<Shipper>();
        }

        public int OrderDetailId { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public int? Discount { get; set; }
        public int? Total { get; set; }
        public DateTime? ShipDate { get; set; }

        public virtual Order? Order { get; set; }
        public virtual Product? Product { get; set; }
        public virtual ICollection<Shipper> Shippers { get; set; }
    }
}
