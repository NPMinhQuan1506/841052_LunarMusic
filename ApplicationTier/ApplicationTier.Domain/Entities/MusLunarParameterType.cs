using System;
using System.Collections.Generic;

namespace ApplicationTier.Domain.Entities
{
    public partial class MusLunarParameterType
    {
        public MusLunarParameterType()
        {
            MusLunarParameters = new HashSet<MusLunarParameter>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Note { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public int ModifiedBy { get; set; }
        public int? State { get; set; }

        public virtual ICollection<MusLunarParameter> MusLunarParameters { get; set; }
    }
}
