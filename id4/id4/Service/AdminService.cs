using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using id4.DAL;
using id4.Models;
using id4.Service;
using Microsoft.EntityFrameworkCore;

namespace id4.Services
{
    public class AdminService : BaseService<Admin>, IAdminService
    {
       
        public AdminService(EFContext _db)
        {
           db = _db;
        }
        public async  Task<Admin> GetByStr(string name, string pwd)
        {
            Admin admin=await db.Admin.Where(a => a.UserName == name && a.Password == pwd).SingleOrDefaultAsync();
            ;
            if(admin!=null)
            {
                return admin;
            }
            else
            {
                return null;
            }
        }
    }
}
