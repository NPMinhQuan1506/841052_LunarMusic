using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTier.Domain.Entities
{
    public class spFavouriteMusicDetail
    {
        public int Id { get; set; }
        public string? Genres { get; set; } = null!;
        public int? CustID { get; set; } = null!;
        public string? CustName { get; set; }
        public string? SongName { get; set; }
        public int? ListeningTimes { get; set; }
        public DateTime? LastListeningTime { get; set; }
    }
}
