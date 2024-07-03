using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MS.PROM.BACKEND.MidasDTO
{
   
    public partial class TbPfcSubSection
    {
        public string SubSection { get; set; } = null!;
        public string? HasDeleted { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public int PlantDepId { get; set; }

        public virtual TbPfcPlantDepartment PlantDep { get; set; } = null!;
    }
}
