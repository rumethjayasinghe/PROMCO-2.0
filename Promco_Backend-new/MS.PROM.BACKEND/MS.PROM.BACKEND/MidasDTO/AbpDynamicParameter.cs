using System;
using System.Collections.Generic;

namespace MS.PROM.BACKEND.MidasDTO
{
    public partial class AbpDynamicParameter
    {
        public AbpDynamicParameter()
        {
            AbpDynamicParameterValues = new HashSet<AbpDynamicParameterValue>();
            AbpEntityDynamicParameters = new HashSet<AbpEntityDynamicParameter>();
        }

        public int Id { get; set; }
        public string? ParameterName { get; set; }
        public string? InputType { get; set; }
        public string? Permission { get; set; }
        public int? TenantId { get; set; }

        public virtual ICollection<AbpDynamicParameterValue> AbpDynamicParameterValues { get; set; }
        public virtual ICollection<AbpEntityDynamicParameter> AbpEntityDynamicParameters { get; set; }
    }
}
