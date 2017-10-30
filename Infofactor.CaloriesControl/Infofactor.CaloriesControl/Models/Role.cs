﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Infofactor.CaloriesControl.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}