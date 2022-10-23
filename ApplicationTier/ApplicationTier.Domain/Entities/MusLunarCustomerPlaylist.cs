using System;
using System.Collections.Generic;

namespace ApplicationTier.Domain.Entities
{
    public partial class MusLunarCustomerPlaylist
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int SongId { get; set; }
        public int ListeningTimes { get; set; }
        public DateTime LastListeningTime { get; set; }
        public string? Note { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public int ModifiedBy { get; set; }
        public int? State { get; set; }

        public virtual MusLunarCustomer Customer { get; set; } = null!;
        public virtual MusLunarSong Song { get; set; } = null!;
    }
}
