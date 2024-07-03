using System;
using System.Collections.Generic;

namespace MS.PROM.BACKEND.MidasDTO
{
    public partial class TbPfcAllocationSectionV3
    {
        public int Id { get; set; }
        public string? SessionId { get; set; }
        public DateTime? SessionCreatedDateTime { get; set; }
        public string? SessionCreatorUserId { get; set; }
        public int? AllocationId { get; set; }
        public int? SectionTemplateId { get; set; }
        public string? ToleranceValue { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public string? CreatorId { get; set; }
        public string? ModifierId { get; set; }
        public string? HasDeleted { get; set; }
        public int? ParameterNormId { get; set; }
    }
}
