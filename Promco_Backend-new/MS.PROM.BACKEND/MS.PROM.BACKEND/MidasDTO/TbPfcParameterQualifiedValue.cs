using System;
using System.Collections.Generic;

namespace MS.PROM.BACKEND.MidasDTO
{
    public partial class TbPfcParameterQualifiedValue
    {
        public int Id { get; set; }
        public int? PlantDepId { get; set; }
        public string? MaterialCode { get; set; }
        public string? Parameter { get; set; }
        public double? MinValue { get; set; }
        public double? Target { get; set; }
        public double? MaxValue { get; set; }

        public virtual TbPfcPlantDepartment? PlantDep { get; set; }
    }
}
