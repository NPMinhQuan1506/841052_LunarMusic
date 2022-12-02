using System;
using System.Collections.Generic;

namespace ApplicationTier.Domain.Entities
{
    public partial class spMusLunarSong
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Source { get; set; }
        public int? PlayTimeInt { get; set; }
        public string? Image { get; set; }
        public int? GenresId { get; set; }
        public int? SingerId { get; set; }
        public int? GroupId { get; set; }
        public string? GroupName { get; set; }
        public string? GroupImg { get; set; }
        public DateTime? GroupRelease { get; set; }

        public string? Singer { get; set; }
        public string? SingerImg { get; set; }
        public DateTime? Created { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public int? ModifiedBy { get; set; }
        public int? State { get; set; }
    }
}
