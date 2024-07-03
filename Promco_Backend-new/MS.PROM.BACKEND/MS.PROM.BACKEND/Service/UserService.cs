using Microsoft.EntityFrameworkCore;
using MS.PROM.BACKEND.MidasDTO;
using MS.PROM.BACKEND.Models;
using System;
using System.Collections.Generic;

namespace MS.PROM.BACKEND.Service
{
    public class UserService
    {

        readonly MidasDataContext _AppDbContext;
       
        public UserService(MidasDataContext context)
        {
            _AppDbContext = context;
           
        }
        public void Insert()
        {

        }
        //public Task<List<TbPfcUser>> GetAllUsers()
        //{
            
        //    var emp =  _AppDbContext.TbPfcUsers.FromSqlRaw($"Select * from TB_PFC_Use").ToListAsync();
        //    return emp;


        //}

        public IEnumerable<MidasDTO.TbPfcUser> GetAll()
        {

            //var result = new List<pfcUser>();
            //result = (List<pfcUser>)_AppDbContext.TbPfcUsers.FromSqlRaw($"Select * from TB_PFC_Use");
           
            var user =  _AppDbContext.TbPfcUsers.FromSqlRaw($"Select * from dbo.TB_PFC_User").ToList();
            return user;


        }
        public void Update()
        {

        }

        public string UserLogin(string email,string password)
        {
            var user =   _AppDbContext.AbpUsers.FromSqlRaw($"Select * from AbpUsers where EmailAddress = '{email}' and Password = '{password}'").ToListAsync();
            if(user != null)
            {
                return "Login Success";
            }
            return "Username or Password Incorrect ";
        }

    }
}
