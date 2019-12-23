﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ShopAppNew.Models
{
    public class User : IdentityUser
    {
        public int Balance { get; set; }
    }
}
