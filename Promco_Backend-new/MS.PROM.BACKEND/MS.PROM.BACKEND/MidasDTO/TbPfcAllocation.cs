using MS.PROM.BACKEND.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MS.PROM.BACKEND.MidasDTO
{
    [Table("TB_PFC_Allocation")]
    public partial class TbPfcAllocation
    {
        public int Id { get; set; }
        public string? MachineCode { get; set; }
        public string? MaterialCode { get; set; }
        public string? Date { get; set; }
        public string? Shift { get; set; }
        public int? OperatorId { get; set; }
        public string? Positions { get; set; }
        public string? HasDeleted { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public string? CreatorId { get; set; }
        public string? ModifierId { get; set; }
        public string HasEditingEnabledWhenDatePassed { get; set; } = null!;
        public string OperatorName { get; set; } = null!;
        public int? PlantDepId { get; set; }

       // public virtual TbPfcPlantDepartment? PlantDep { get; set; }

       
    }
}
