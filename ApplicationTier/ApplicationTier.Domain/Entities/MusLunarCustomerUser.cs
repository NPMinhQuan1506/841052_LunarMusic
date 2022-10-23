using System;
using System.Collections.Generic;

namespace ApplicationTier.Domain.Entities
{
    public partial class MusLunarCustomerUser
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int CustomerId { get; set; }
        public DateTime LastSignin { get; set; }
        public int? IsBlock { get; set; }
        public DateTime? BlockTime { get; set; }
        public string? Note { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public int ModifiedBy { get; set; }
        public int? State { get; set; }

        public virtual MusLunarCustomer Customer { get; set; } = null!;
    }
}
