using System;
using System.Collections.Generic;

namespace ApplicationTier.Domain.Entities
{
    public partial class VwWork
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
