using System;
using System.Collections.Generic;

namespace MS.PROM.BACKEND.MidasDTO
{
    public partial class TbPfcToleranceValueDropDown
    {
        public int Id { get; set; }
        public int? ToleranceId { get; set; }
        public string? Value { get; set; }
        public string? HasDeleted { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public string? CreatorId { get; set; }
        public string? ModifierId { get; set; }

        public virtual TbPfcTolerance? Tolerance { get; set; }
    }
}
