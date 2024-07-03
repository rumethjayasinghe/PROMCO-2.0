using System;
using System.Collections.Generic;

namespace MS.PROM.BACKEND.MidasDTO
{
    public partial class AbpEntityChange
    {
        public AbpEntityChange()
        {
            AbpEntityPropertyChanges = new HashSet<AbpEntityPropertyChange>();
        }

        public long Id { get; set; }
        public DateTime ChangeTime { get; set; }
        public byte ChangeType { get; set; }
        public long EntityChangeSetId { get; set; }
        public string? EntityId { get; set; }
        public string? EntityTypeFullName { get; set; }
        public int? TenantId { get; set; }

        public virtual AbpEntityChangeSet EntityChangeSet { get; set; } = null!;
        public virtual ICollection<AbpEntityPropertyChange> AbpEntityPropertyChanges { get; set; }
    }
}
