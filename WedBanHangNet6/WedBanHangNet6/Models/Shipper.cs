using System;
using System.Collections.Generic;

namespace WedBanHangNet6.Models
{
    public partial class Shipper
    {
        public int ShipperId { get; set; }
        public string ShipperName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Company { get; set; } = null!;
        public int OrderDetailId { get; set; }

        public virtual OrderDetail OrderDetail { get; set; } = null!;
    }
}
