using System;
using System.Collections.Generic;

namespace MS.PROM.BACKEND.MidasDTO
{
    public partial class TbPfcUserMainSection
    {
        public int UserId { get; set; }
        public string MainSection { get; set; } = null!;
        public int PlantDepId { get; set; }

        public virtual TbPfcMainSection TbPfcMainSection { get; set; } = null!;
    }
}
