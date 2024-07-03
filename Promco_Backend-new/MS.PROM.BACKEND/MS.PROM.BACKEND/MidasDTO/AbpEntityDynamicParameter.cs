using System;
using System.Collections.Generic;

namespace MS.PROM.BACKEND.MidasDTO
{
    public partial class AbpEntityDynamicParameter
    {
        public AbpEntityDynamicParameter()
        {
            AbpEntityDynamicParameterValues = new HashSet<AbpEntityDynamicParameterValue>();
        }

        public int Id { get; set; }
        public string? EntityFullName { get; set; }
        public int DynamicParameterId { get; set; }
        public int? TenantId { get; set; }

        public virtual AbpDynamicParameter DynamicParameter { get; set; } = null!;
        public virtual ICollection<AbpEntityDynamicParameterValue> AbpEntityDynamicParameterValues { get; set; }
    }
}
