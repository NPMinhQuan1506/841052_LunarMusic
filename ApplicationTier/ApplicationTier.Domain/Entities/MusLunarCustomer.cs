using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ApplicationTier.Domain.Entities
{
    public partial class MusLunarCustomer
    {
        public MusLunarCustomer()
        {
            //MusLunarCustomerPlaylists = new HashSet<MusLunarCustomerPlaylist>();
            //MusLunarCustomerUsers = new HashSet<MusLunarCustomerUser>();
            //MusLunarOrders = new HashSet<MusLunarOrder>();
        }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; } = null!;
        public string? NameNoSign { get; set; } = null!;
        public string? NickName { get; set; }
        public string? LastName { get; set; } = null!;
        public int? GenderId { get; set; }
        public DateTime? BirthDay { get; set; }
        public string? Phone { get; set; } = null!;
        public string? Email { get; set; }
        public string? AssistantEmail { get; set; }
        public string? Address { get; set; } = null!;
        public string? Avartar { get; set; }
        public string? BackgroundImage { get; set; }
        public string? Note { get; set; }
        public DateTime? Created { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public int? ModifiedBy { get; set; }
        public int? State { get; set; }

        //public virtual ICollection<MusLunarCustomerPlaylist> MusLunarCustomerPlaylists { get; set; }
        //public virtual ICollection<MusLunarCustomerUser> MusLunarCustomerUsers { get; set; }
        //public virtual ICollection<MusLunarOrder> MusLunarOrders { get; set; }
    }
}
