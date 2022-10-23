using System;
using System.Collections.Generic;

namespace ApplicationTier.Domain.Entities
{
    public partial class MusLunarAuthor
    {
        public MusLunarAuthor()
        {
            MusLunarSongs = new HashSet<MusLunarSong>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? NameNoSign { get; set; }
        public string Avartar { get; set; } = null!;
        public string NickName { get; set; } = null!;
        public string? LastName { get; set; }
        public int GenderId { get; set; }
        public DateTime BirthDay { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Note { get; set; }
        public DateTime? Created { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public int? ModifiedBy { get; set; }
        public int State { get; set; }

        public virtual ICollection<MusLunarSong> MusLunarSongs { get; set; }
    }
}
