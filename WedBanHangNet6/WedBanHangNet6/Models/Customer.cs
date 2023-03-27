using System;
using System.Collections.Generic;

namespace WedBanHangNet6.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public string FullName { get; set; } = null!;
        public DateTime Dob { get; set; }
        public string Address { get; set; } = null!;
        public string? Avatar { get; set; }
        public string Gmail { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public bool Gender { get; set; }
        public int? AccountId { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Account? Account { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
