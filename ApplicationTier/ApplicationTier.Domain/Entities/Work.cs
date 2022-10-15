using ApplicationTier.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTier.Domain.Entities
{
    public class Work : EntityBase<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
