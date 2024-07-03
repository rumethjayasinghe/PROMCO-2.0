using System;
using System.Collections.Generic;

namespace MS.PROM.BACKEND.MidasDTO
{
    public partial class TbPfcParameterNorm
    {
        public int Id { get; set; }
        public string? Parameter { get; set; }
        public int? PlantDepId { get; set; }
        public double? MinValue { get; set; }
        public double? MaxValue { get; set; }
        public DateTime? NDateTime { get; set; }
        public string? HasDeleted { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }

        public virtual TbPfcParameter? P { get; set; }
    }
}
