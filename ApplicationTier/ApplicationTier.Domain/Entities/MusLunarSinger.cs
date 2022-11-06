using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ApplicationTier.Domain.Entities
{
    public partial class MusLunarSinger
    {
        public MusLunarSinger()
        {
            //MusLunarSongs = new HashSet<MusLunarSong>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? NameNoSign { get; set; }
        public string? NickName { get; set; }
        public string LastName { get; set; } = null!;
        public int GenderId { get; set; }
        public DateTime? BirthDay { get; set; }
        public string? Avartar { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Description { get; set; }
        public string? Note { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public int ModifiedBy { get; set; }
        public int? State { get; set; }
        [JsonIgnore]
        public virtual MusLunarParameter Gender { get; set; } = null!;
        //public virtual ICollection<MusLunarSong> MusLunarSongs { get; set; }
    }
}
