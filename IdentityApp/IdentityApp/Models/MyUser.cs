﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityApp.Models
{
    public class MyUser:IdentityUser
    {
        public int MyProperty { get; set; }

    }
}
