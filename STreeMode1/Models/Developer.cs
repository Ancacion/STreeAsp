﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STreeMode1.Models
{
    public class Developer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Developer() { }

        public Developer(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}