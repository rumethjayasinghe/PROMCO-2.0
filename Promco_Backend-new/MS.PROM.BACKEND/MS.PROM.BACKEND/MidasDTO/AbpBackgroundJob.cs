using System;
using System.Collections.Generic;

namespace MS.PROM.BACKEND.MidasDTO
{
    public partial class AbpBackgroundJob
    {
        public long Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public bool IsAbandoned { get; set; }
        public string JobArgs { get; set; } = null!;
        public string JobType { get; set; } = null!;
        public DateTime? LastTryTime { get; set; }
        public DateTime NextTryTime { get; set; }
        public byte Priority { get; set; }
        public short TryCount { get; set; }
    }
}
