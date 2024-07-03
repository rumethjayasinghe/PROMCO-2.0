using MS.PROM.BACKEND.MidasDTO;

namespace MS.PROM.BACKEND.Models
{
    public class pfcUser
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public string? IsActive { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public int PlantDepId { get; set; }

        public virtual TbPfcPlantDepartment PlantDep { get; set; } = null!;
    }
}
