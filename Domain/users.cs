﻿using Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Users : BaseEntity
    {
        public string userName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
