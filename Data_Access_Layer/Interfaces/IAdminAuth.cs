﻿using Data_Access_Layer.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Interfaces
{
    public interface IAdminAuth
    {
        AdminToken Authenticate(Admin use);
        bool IsAuthenticated(string tok);
        bool Logout(string token);
    }
}
