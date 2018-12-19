using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STreeMode1.Models
{
    public class Order_List
    {
        public int Id { get; set; }
        public DateTime Date_Time { get; set; }

        public Order_List() { }

        public Order_List(int Id, DateTime Date_Time)
        {
            this.Id = Id;
            this.Date_Time = Date_Time;
        }
    }
}