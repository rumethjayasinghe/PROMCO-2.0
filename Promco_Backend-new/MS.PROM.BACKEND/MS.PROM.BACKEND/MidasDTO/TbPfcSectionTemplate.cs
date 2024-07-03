using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MS.PROM.BACKEND.MidasDTO
{
    [Table("TB_PFC_SectionTemplate")]
    public partial class TbPfcSectionTemplate
    {
        public int Id { get; set; }
        public string? MainSection { get; set; }
        public string? SubSection { get; set; }
        public string? MachineType { get; set; }
        public string? Parameter { get; set; }
        public int? ToleranceId { get; set; }
        public double? Threshold { get; set; }
        public string? HasDeleted { get; set; }
        public string? CreatorId { get; set; }
        public string? ModifierId { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public int? PlantDepId { get; set; }
        public string? ParameterShortName { get; set; }
        public int? SortNumber { get; set; }
        public string? IsDynamic { get; set; }
        public string? Equation { get; set; }

        public virtual TbPfcPlantDepartment? PlantDep { get; set; }
    }
}
