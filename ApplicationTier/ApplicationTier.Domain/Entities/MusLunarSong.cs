using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ApplicationTier.Domain.Entities
{
    public partial class MusLunarSong
    {
        public MusLunarSong()
        {
            //MusLunarCustomerPlaylists = new HashSet<MusLunarCustomerPlaylist>();
        }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; } = null!;
        [DataMember]
        public string Source { get; set; } = null!;
        public int PlayTimeInt { get; set; }
        public string? Image { get; set; }
        public int? IsPro { get; set; }
        public decimal UnitPrice { get; set; }
        public int GenresId { get; set; }
        public int AuthorId { get; set; }
        public int SingerId { get; set; }
        public int GroupId { get; set; }
        public int NationalId { get; set; }
        public int IsDisabled { get; set; }
        public string? Lyrics { get; set; }
        public string? Note { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public int ModifiedBy { get; set; }
        public int? State { get; set; }
        [JsonIgnore]
        public virtual MusLunarAuthor Author { get; set; } = null!;
        [JsonIgnore]
        public virtual MusLunarMusicGenre Genres { get; set; } = null!;
        [JsonIgnore]
        public virtual MusLunarSongGroup Group { get; set; } = null!;
        [JsonIgnore]
        public virtual MusLunarSinger Singer { get; set; } = null!;

        //public virtual ICollection<MusLunarCustomerPlaylist> MusLunarCustomerPlaylists { get; set; }
    }
}
