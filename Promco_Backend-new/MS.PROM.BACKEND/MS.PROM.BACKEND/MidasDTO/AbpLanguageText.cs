﻿using System;
using System.Collections.Generic;

namespace MS.PROM.BACKEND.MidasDTO
{
    public partial class AbpLanguageText
    {
        public long Id { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public string Key { get; set; } = null!;
        public string LanguageName { get; set; } = null!;
        public DateTime? LastModificationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public string Source { get; set; } = null!;
        public int? TenantId { get; set; }
        public string Value { get; set; } = null!;
    }
}
