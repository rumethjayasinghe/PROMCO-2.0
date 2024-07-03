using System;
using System.Collections.Generic;

namespace MS.PROM.BACKEND.MidasDTO
{
    public partial class TbPfcMachine
    {
        public string MachineCode { get; set; } = null!;
        public string? MachineType { get; set; }
        public string? SapResource { get; set; }
        public string? HasDeleted { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public int PlantDepId { get; set; }

        public virtual TbPfcPlantDepartment PlantDep { get; set; } = null!;
    }
}
