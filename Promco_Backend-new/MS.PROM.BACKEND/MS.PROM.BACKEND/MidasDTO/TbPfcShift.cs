using System;
using System.Collections.Generic;

namespace MS.PROM.BACKEND.MidasDTO
{
    public partial class TbPfcShift
    {
        public string Shift { get; set; } = null!;
        public int PlantDepId { get; set; }
        public string? HasDeleted { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }

        public virtual TbPfcPlantDepartment PlantDep { get; set; } = null!;
    }
}
