using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MS.PROM.BACKEND.MidasDTO
{
    
    [Table("TB_PFC_Tolerance")]
    public partial class TbPfcTolerance
    {
        public TbPfcTolerance()
        {
            TbPfcToleranceValueDropDowns = new HashSet<TbPfcToleranceValueDropDown>();
        }

        public int Id { get; set; }
        public string? HasDeleted { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? CreatorId { get; set; }
        public string? ModifierId { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public int? PlantDepId { get; set; }

        public virtual TbPfcPlantDepartment? PlantDep { get; set; }
        public virtual TbPfcToleranceValueNumeric TbPfcToleranceValueNumeric { get; set; } = null!;
        public virtual ICollection<TbPfcToleranceValueDropDown> TbPfcToleranceValueDropDowns { get; set; }
    }
}
