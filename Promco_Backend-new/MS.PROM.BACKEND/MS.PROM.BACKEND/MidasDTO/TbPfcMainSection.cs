using System;
using System.Collections.Generic;

namespace MS.PROM.BACKEND.MidasDTO
{
    public partial class TbPfcMainSection
    {
        public TbPfcMainSection()
        {
            TbPfcUserMainSections = new HashSet<TbPfcUserMainSection>();
        }

        public string MainSection { get; set; } = null!;
        public string? MainSectionName { get; set; }
        public string? HasDeleted { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public int PlantDepId { get; set; }

        public virtual TbPfcPlantDepartment PlantDep { get; set; } = null!;
        public virtual ICollection<TbPfcUserMainSection> TbPfcUserMainSections { get; set; }
    }
}
