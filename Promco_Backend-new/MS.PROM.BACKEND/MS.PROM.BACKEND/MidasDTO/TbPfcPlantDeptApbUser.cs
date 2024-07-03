using System;
using System.Collections.Generic;

namespace MS.PROM.BACKEND.MidasDTO
{
    public partial class TbPfcPlantDeptApbUser
    {
        public int Id { get; set; }
        public long? AbpUserId { get; set; }
        public int? PlantDeptId { get; set; }
    }
}
