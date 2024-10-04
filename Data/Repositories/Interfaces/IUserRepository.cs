﻿using Business.Entyties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Interfaces
{
    public interface IUserRepository : IGenericInterface<User>
    {
        Task<User> GetByName(string Name);
    }
}
