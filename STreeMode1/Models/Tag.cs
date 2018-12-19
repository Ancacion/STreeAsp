using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STreeMode1.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public DateTime Add_Time { get; set; }

        public Tag() { }

        public Tag(int Id, DateTime Add_Time)
        {
            this.Id = Id;
            this.Add_Time = Add_Time;
        }
    }
}