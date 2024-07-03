using System;
using System.Collections.Generic;

namespace MS.PROM.BACKEND.MidasDTO
{
    public partial class AbpDynamicParameterValue
    {
        public int Id { get; set; }
        public string Value { get; set; } = null!;
        public int? TenantId { get; set; }
        public int DynamicParameterId { get; set; }

        public virtual AbpDynamicParameter DynamicParameter { get; set; } = null!;
    }
}
