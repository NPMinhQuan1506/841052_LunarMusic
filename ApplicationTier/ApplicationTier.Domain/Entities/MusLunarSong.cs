using System;
using System.Collections.Generic;

namespace ApplicationTier.Domain.Entities
{
    public partial class MusLunarSong
    {
        public MusLunarSong()
        {
            MusLunarCustomerPlaylists = new HashSet<MusLunarCustomerPlaylist>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Source { get; set; } = null!;
        public int PlayTimeInt { get; set; }
        public string? Image { get; set; }
        public int? IsPro { get; set; }
        public decimal UnitPrice { get; set; }
        public int GenresId { get; set; }
        public int AuthorId { get; set; }
        public int SingerId { get; set; }
        public int GroupId { get; set; }
        public int OriginId { get; set; }
        public int IsDisabled { get; set; }
        public string? Note { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public int ModifiedBy { get; set; }
        public int? State { get; set; }

        public virtual MusLunarAuthor Author { get; set; } = null!;
        public virtual MusLunarMusicGenre Genres { get; set; } = null!;
        public virtual MusLunarSongGroup Group { get; set; } = null!;
        public virtual MusLunarSinger Singer { get; set; } = null!;
        public virtual ICollection<MusLunarCustomerPlaylist> MusLunarCustomerPlaylists { get; set; }
    }
}
