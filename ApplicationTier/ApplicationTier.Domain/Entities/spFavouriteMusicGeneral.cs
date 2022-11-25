using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTier.Domain.Entities
{
    public class spFavouriteMusicGeneral
    {
        public int Id { get; set; }
        public string? Genres { get; set; } = null!;
        public int? FavNum { get; set; } = null!;
        public int? ListenTimes { get; set; }
    }
}
