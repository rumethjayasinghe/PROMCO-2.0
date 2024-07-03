using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MS.PROM.BACKEND.MidasDTO;
using MS.PROM.BACKEND.Models;
using System.Drawing;
using System.Xml.Linq;
using MS.PROM.BACKEND.Models;
using static MS.PROM.BACKEND.Models.Formatclass;

namespace MS.PROM.BACKEND.Service
{
    public class MatserDataService
    {

        readonly MidasDataContext _AppDbContext;
        //readonly ILogger _logger;

        public MatserDataService(MidasDataContext context)
        {
            _AppDbContext = context;
            //_logger = logger;
        }

        public string UserLogin(string email, string password)
        {
            var user = _AppDbContext.AbpUsers.FromSqlRaw($"Select * from AbpUsers where EmailAddress = '{email}' and Password = '{password}'").ToListAsync();
            if (user != null)
            {
                return "Login Success";
            }
            return "Username or Password Incorrect ";
        }

       
        //Save allocation 
        public string SaveAllocation(TbPfcAllocation allocation)
        {
            try
            {
                var resuklt = (from f in _AppDbContext.TbPfcAllocations
                               select f).FirstOrDefault();
                var user = _AppDbContext.TbPfcAllocations.Add(allocation);
                _AppDbContext.SaveChanges();

                if (user != null)
                {
                    return "Allocation created successfully";
                }
                else { return "Allocation creation failed"; }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
       


        //Save Section Templete 
        public string saveSectionTemplate(TbPfcSectionTemplate allocation)
        {
            try
            {
                var user = _AppDbContext.TbPfcSectionTemplates.Add(allocation);
                _AppDbContext.SaveChanges();

                if (user != null)
                {
                    return "Section Template  created successfully";
                }
                else { return "Section Template  Not Created "; }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // save tolarance 
        public string saveTolerance(TbPfcTolerance tolarance)
        {
            try
            {
                var user = _AppDbContext.TbPfcTolerances.Add(tolarance);
                _AppDbContext.SaveChanges();

                if (user != null)
                {
                    return "Tolarance   created successfully";
                }
                else { return "Tolarance   Not Created "; }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// test 
        /// </summary>
        //public class MachineUserCount
        //{
        //    public IEnumerable<MidasDTO.TbPfcMachine> Machines { get; set; }
        //    public int TotalEliment { get; set; }
        //    public int size;

        //}
        public MachineUserCount GetMachine(int plandepId)
        {
            var user = _AppDbContext.TbPfcMachines.FromSqlRaw($"Select * from dbo.TB_PFC_Machine where plantDepId = {plandepId} ").ToList();
            var count = user.Count();

            return new MachineUserCount
            {
                TotalEliment = count,
                Machines = user,
              
            };
        }
        /// <summary>
        /// /test end 
        /// </summary>
        /// <param name="plandepId"></param>
        /// <returns></returns>
        //Machine 
        public IEnumerable<MidasDTO.TbPfcMachine> getMachines(int plandepId)
        {
            
            //var result = new List<pfcUser>();
            //result = (List<pfcUser>)_AppDbContext.TbPfcUsers.FromSqlRaw($"Select * from TB_PFC_Use");

            var user = _AppDbContext.TbPfcMachines.FromSqlRaw($"Select * from dbo.TB_PFC_Machine where plantDepId = {plandepId} ").ToList();
            return user;


        }
        //Machine Type -1
        public IEnumerable<MidasDTO.TbPfcMachineType> getMachineType(int plandepId)
        {
            var user = _AppDbContext.TbPfcMachineTypes.FromSqlRaw($"Select * from dbo.TB_PFC_MachineType where plantDepId = {plandepId} ").ToList();
            return user;
        }
        //Machine Type -2

        public MachineTypeCount GetMachineYype(int plandepId)
        {
            var user = _AppDbContext.TbPfcMachineTypes.FromSqlRaw($"Select * from dbo.TB_PFC_MachineType where plantDepId= {plandepId} ").ToList();
            var count = user.Count();

            return new MachineTypeCount
            {
                TotalEliment = count,
                MachineType = user,

            };
        }




        // Main Section -1
        public IEnumerable<MidasDTO.TbPfcMainSection> getMainSections(int plandepId)
        {
            var user = _AppDbContext.TbPfcMainSections.FromSqlRaw($"Select * from dbo.TB_PFC_MainSection where plantDepId = {plandepId} ").ToList();
            return user;
        }

        //Main section -2 
        public MainSectionCount GetMainSection (int plandepId)
        {
            var user = _AppDbContext.TbPfcMainSections.FromSqlRaw($"Select * from dbo.TB_PFC_MainSection where plantDepId = {plandepId} ").ToList();
            var count = user.Count();

            return new MainSectionCount
            {
                TotalEliment = count,
                section = user,

            };
        }


        //Material code -1
        public IEnumerable<MidasDTO.TbPfcMaterialCode> getMaterialcodes(int plandepId)
        {
            var user = _AppDbContext.TbPfcMaterialCodes.FromSqlRaw($"Select * from dbo.TB_PFC_MaterialCode where plantDepId = {plandepId} ").ToList();
            return user;
        }
        //Material code -2
        public MaterialCount GetMaterialCode(int plandepId)
        {
            var user = _AppDbContext.TbPfcMaterialCodes.FromSqlRaw($"Select * from dbo.TB_PFC_MaterialCode where plantDepId = {plandepId} ").ToList();
            var count = user.Count();

            return new MaterialCount
            {
                TotalEliment = count,
                material = user,

            };
        }

        // Parameters -1 
        public IEnumerable<MidasDTO.TbPfcParameter> getParameters(int plandepId)
        {
            var user = _AppDbContext.TbPfcParameters.FromSqlRaw($"Select * from dbo.TB_PFC_Parameter where plantDepId = {plandepId} ").ToList();
            return user;
        }
        //Parameter -2 
        public ParameterCount GetParameter(int plandepId)
        {
            var user = _AppDbContext.TbPfcParameters.FromSqlRaw($"Select * from dbo.TB_PFC_Parameter where plantDepId = {plandepId} ").ToList();
            var count = user.Count();

            return new ParameterCount
            {
                TotalEliment = count,
                parameter = user,

            };
        }

        //Parameter Norms - 1
        public IEnumerable<MidasDTO.TbPfcParameterNorm> getParameterNorms(int plandepId)
        {
            var user = _AppDbContext.TbPfcParameterNorms.FromSqlRaw($"Select * from dbo.TB_PFC_Parameter_Norm where plantDepId = {plandepId} ").ToList();
            return user;
        }
        //Parameter Norm -2 
        public ParametrNormCount GetParameterNorm(int plandepId)
        {
            var user = _AppDbContext.TbPfcParameterNorms.FromSqlRaw($"Select * from dbo.TB_PFC_Parameter_Norm where plantDepId = {plandepId} ").ToList();
            var count = user.Count();

            return new ParametrNormCount
            {
                TotalEliment = count,
                parameterNorm = user,

            };
        }
        // Shift -1
        public IEnumerable<MidasDTO.TbPfcShift> getShifts(int plandepId)
        {
            var user = _AppDbContext.TbPfcShifts.FromSqlRaw($"Select * from dbo.TB_PFC_Shift where plantDepId = {plandepId} ").ToList();
            return user;
        }
        //Shift -2
        public Shift GetShift(int plandepId)
        {
            var user = _AppDbContext.TbPfcShifts.FromSqlRaw($"Select * from dbo.TB_PFC_Shift where plantDepId = {plandepId} ").ToList();
            var count = user.Count();

            return new Shift
            {
                TotalEliment = count,
                shift = user,

            };
        }

        //Section Template
        public IEnumerable<MidasDTO.TbPfcSectionTemplate> getSectionTemplate(int plandepId)
        {
            var user = _AppDbContext.TbPfcSectionTemplates.FromSqlRaw($"Select * from dbo.TB_PFC_SectionTemplate where plantDepId = {plandepId} ").ToList();
            return user;
        }
        //section templete  -2
        public SectionTemplate GetSectionTemplete(int plandepId)
        {
            var user = _AppDbContext.TbPfcSectionTemplates.FromSqlRaw($"Select * from dbo.TB_PFC_SectionTemplate where plantDepId = {plandepId} ").ToList();
            var count = user.Count();

            return new SectionTemplate
            {
                TotalEliment = count,
                sectionTemplate = user,

            };
        }
        //SubSection
        public IEnumerable<MidasDTO.TbPfcSubSection> getSubSections(int plandepId)
        {
            var user = _AppDbContext.TbPfcSubSections.FromSqlRaw($"Select * from dbo.TB_PFC_SubSection where plantDepId = {plandepId} ").ToList();
            return user;
        }
        //Sub section -2
        public SubSection GetSubSection(int plandepId)
        {
            var user = _AppDbContext.TbPfcSubSections.FromSqlRaw($"Select * from dbo.TB_PFC_SubSection where plantDepId = {plandepId} ").ToList();
            var count = user.Count();

            return new SubSection
            {
                TotalEliment = count,
                subSection = user,

            };
        }

        //Get Tolarance 
        public IEnumerable<MidasDTO.TbPfcTolerance> getToerances(int plandepId)
        {

            //var result = new List<pfcUser>();
            //result = (List<pfcUser>)_AppDbContext.TbPfcUsers.FromSqlRaw($"Select * from TB_PFC_Use");

            var user = _AppDbContext.TbPfcTolerances.FromSqlRaw($"Select * from dbo.TB_PFC_Tolerance where plantDepId = {plandepId}").ToList();
            return user;

        }
        //tolarance -2
        public Tolarance Gettolarance(int plandepId)
        {
            var user = _AppDbContext.TbPfcTolerances.FromSqlRaw($"Select * from dbo.TB_PFC_Tolerance where plantDepId = {plandepId}").ToList();
            var count = user.Count();

            return new Tolarance
            {
                TotalEliment = count,
                tolarance = user,

            };
        }

        //Get allocation 
       // public IEnumerable<MidasDTO.TbPfcAllocation> GetAll(int plantDepId, DateTime? updatedAfter, int page, int size, int? duringLastNoOfDays, int? notDuringLastNoOfDays)
         public IEnumerable<MidasDTO.TbPfcAllocation> GetAll()
        {

            //var result = new List<pfcUser>();
            //result = (List<pfcUser>)_AppDbContext.TbPfcUsers.FromSqlRaw($"Select * from TB_PFC_Use");

            var user = _AppDbContext.TbPfcAllocations.FromSqlRaw($"Select * from dbo.TB_PFC_Allocation").OrderByDescending(c => c.Id).Take(10).ToList();
           // var user = _AppDbContext.TbPfcTolerances.FromSqlRaw($"Select * from dbo.TB_PFC_Tolerance where plantDepId = {plantDepId} and createdTime > {}").ToList();
            var count = user.Count();
            return user;

        }
       


       







        //test end



    }




}
