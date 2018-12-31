using id4.DAL;
using id4.Interface;
using id4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace id4.Services
{
    public interface IAdminService : IBaseService<Admin>
    {
        Task<Admin> GetByStr(string name, string pwd); //根据用户名和密码查找用户
    }
}
