using System;
using System.Collections.Generic;

namespace MS.PROM.BACKEND.MidasDTO
{
    public partial class TbPfcPlantDepartment
    {
        public TbPfcPlantDepartment()
        {
            TbPfcMachineTypes = new HashSet<TbPfcMachineType>();
            TbPfcMachines = new HashSet<TbPfcMachine>();
            TbPfcMainSections = new HashSet<TbPfcMainSection>();
            TbPfcMaterialCodes = new HashSet<TbPfcMaterialCode>();
            TbPfcParameterQualifiedValues = new HashSet<TbPfcParameterQualifiedValue>();
            TbPfcParameters = new HashSet<TbPfcParameter>();
            TbPfcSectionTemplates = new HashSet<TbPfcSectionTemplate>();
            TbPfcShifts = new HashSet<TbPfcShift>();
            TbPfcSubSections = new HashSet<TbPfcSubSection>();
            TbPfcTolerances = new HashSet<TbPfcTolerance>();
            TbPfcUsers = new HashSet<TbPfcUser>();
        }

        public int Id { get; set; }
        public int? PlantId { get; set; }
        public int? DepartmentId { get; set; }
        public string? PlantName { get; set; }
        public string? DepartmentName { get; set; }
        public string? HasDeleted { get; set; }

        public virtual ICollection<TbPfcMachineType> TbPfcMachineTypes { get; set; }
        public virtual ICollection<TbPfcMachine> TbPfcMachines { get; set; }
        public virtual ICollection<TbPfcMainSection> TbPfcMainSections { get; set; }
        public virtual ICollection<TbPfcMaterialCode> TbPfcMaterialCodes { get; set; }
        public virtual ICollection<TbPfcParameterQualifiedValue> TbPfcParameterQualifiedValues { get; set; }
        public virtual ICollection<TbPfcParameter> TbPfcParameters { get; set; }
        public virtual ICollection<TbPfcSectionTemplate> TbPfcSectionTemplates { get; set; }
        public virtual ICollection<TbPfcShift> TbPfcShifts { get; set; }
        public virtual ICollection<TbPfcSubSection> TbPfcSubSections { get; set; }
        public virtual ICollection<TbPfcTolerance> TbPfcTolerances { get; set; }
        public virtual ICollection<TbPfcUser> TbPfcUsers { get; set; }
    }
}
