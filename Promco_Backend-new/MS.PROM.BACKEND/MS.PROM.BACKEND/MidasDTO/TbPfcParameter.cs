using System;
using System.Collections.Generic;

namespace MS.PROM.BACKEND.MidasDTO
{
    public partial class TbPfcParameter
    {
        public TbPfcParameter()
        {
            TbPfcParameterNorms = new HashSet<TbPfcParameterNorm>();
        }

        public string Parameter { get; set; } = null!;
        public string? HasDeleted { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public int PlantDepId { get; set; }

        public virtual TbPfcPlantDepartment PlantDep { get; set; } = null!;
        public virtual ICollection<TbPfcParameterNorm> TbPfcParameterNorms { get; set; }
    }
}
