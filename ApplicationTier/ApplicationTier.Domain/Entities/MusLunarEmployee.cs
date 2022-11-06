using System;
using System.Collections.Generic;

namespace ApplicationTier.Domain.Entities
{
    public partial class MusLunarEmployee
    {
        public MusLunarEmployee()
        {
            MusLunarUsers = new HashSet<MusLunarUser>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string NameNoSign { get; set; } = null!;
        public string? NickName { get; set; }
        public string LastName { get; set; } = null!;
        public int GenderId { get; set; }
        public DateTime BirthDay { get; set; }
        public string Phone { get; set; } = null!;
        public string? Email { get; set; }
        public string? AssistantEmail { get; set; }
        public string Address { get; set; } = null!;
        public string? Avartar { get; set; }
        public string? BackgroundImage { get; set; }
        public string? Note { get; set; }
        public DateTime? Created { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public int? ModifiedBy { get; set; }
        public int State { get; set; }

        public virtual MusLunarParameter Gender { get; set; } = null!;
        public virtual ICollection<MusLunarUser> MusLunarUsers { get; set; }
    }
}
