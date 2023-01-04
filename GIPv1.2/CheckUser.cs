﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIPv1._2
{
    public class CheckUser
    {
        public string Login { get; set; }
        public bool IsAdmin { get; }

        public string Status => IsAdmin ? "Администратор" : "Инженер(user)";
        public CheckUser(string login, bool isAdmin)
        {
            Login = login.Trim();
            IsAdmin = isAdmin;
        }
    }
}