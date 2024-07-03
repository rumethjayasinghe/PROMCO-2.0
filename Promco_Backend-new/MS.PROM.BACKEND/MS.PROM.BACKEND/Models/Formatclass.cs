namespace MS.PROM.BACKEND.Models
{
    public class Formatclass
    {

        public class MachineUserCount
        {
            public IEnumerable<MidasDTO.TbPfcMachine> Machines { get; set; }
            public int TotalEliment { get; set; }
            public int size;

        }

        public class MachineTypeCount
        {
            public IEnumerable<MidasDTO.TbPfcMachineType> MachineType { get; set; }
            public int TotalEliment { get; set; }
           
        }

        public class MainSectionCount
        {
            public IEnumerable<MidasDTO.TbPfcMainSection> section  { get; set; }
            public int TotalEliment { get; set; }
          
        }

        public class MaterialCount
        {
            public IEnumerable<MidasDTO.TbPfcMaterialCode> material { get; set; }
            public int TotalEliment { get; set; }
          
        }
        public class ParameterCount
        {
            public IEnumerable<MidasDTO.TbPfcParameter> parameter { get; set; }
            public int TotalEliment { get; set; }
          
        }

        public class ParametrNormCount
        {
            public IEnumerable<MidasDTO.TbPfcParameterNorm> parameterNorm { get; set; }
            public int TotalEliment { get; set; }

        }

        public class SectionTemplate
        {
            public IEnumerable<MidasDTO.TbPfcSectionTemplate> sectionTemplate { get; set; }
            public int TotalEliment { get; set; }

        }
        public class Shift
        {
            public IEnumerable<MidasDTO.TbPfcShift> shift { get; set; }
            public int TotalEliment { get; set; }

        }
        public class SubSection
        {
            public IEnumerable<MidasDTO.TbPfcSubSection> subSection { get; set; }
            public int TotalEliment { get; set; }

        }
        public class Tolarance
        {
            public IEnumerable<MidasDTO.TbPfcTolerance> tolarance { get; set; }
            public int TotalEliment { get; set; }

        }
        public class User
        {
            public IEnumerable<MidasDTO.TbPfcUser> user { get; set; }
            public int TotalEliment { get; set; }

        }
    }


}
