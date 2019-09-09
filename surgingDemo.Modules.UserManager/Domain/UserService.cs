﻿using Surging.Core.ProxyGenerator;
//using surgingDemo.Data.Models;
using surgingDemo.IModuleServices.UserManager;
using surgingDemo.Modules.UserManager.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Surging.Core.CPlatform.Ioc;
namespace surgingDemo.Modules.UserManager.Domain
{
    [ModuleName("User")]
    public class UserService : ProxyServiceBase, IUserService
    {
        private readonly UsersRepository _usersRepository;
        public UserService(UsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }
        public  Task<string> GetName(string name)
        {
            return Task.FromResult(name);
        }

        //public  Task<List<Users>> GetUsersAsync()
        //{
           // return Task.FromResult(new List<Users> { new Users { CreateDate = DateTime.Now, Id = 1, Name = "123", Sex = "男" } });
            ////var list = _usersRepository.GetUsers();
            //return await _usersRepository.GetUsersAsync();
       // }
    }
}
