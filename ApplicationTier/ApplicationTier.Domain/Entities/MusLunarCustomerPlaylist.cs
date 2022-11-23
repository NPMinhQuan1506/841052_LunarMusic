using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ApplicationTier.Domain.Entities
{
    public partial class MusLunarCustomerPlaylist
    {
        public int? Id { get; set; }
        public int? CustomerId { get; set; }
        //public string CustName { get; set; }
        public int? SongId { get; set; }
        //public string SongName { get; set; }
        public int? ListeningTimes { get; set; }
        public DateTime? LastListeningTime { get; set; }
        public string? Note { get; set; }
        public DateTime? Created { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public int? ModifiedBy { get; set; }
        public int? State { get; set; }

        [JsonIgnore]
        public virtual MusLunarCustomer? Customer { get; set; } = null!;

        [JsonIgnore]
        public virtual MusLunarSong? Song { get; set; } = null!;
    }
}
