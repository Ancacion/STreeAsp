using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STreeMode1.Models
{
    public class Trace
    {
        public int CustomerID { get; set; }
        public int GameID { get; set; }
        public DateTime Date_Time { get; set; }

        public Trace() { }

        public Trace(int CustomerID, int GameID, DateTime Date_Time)
        {
            this.CustomerID = CustomerID;
            this.GameID = GameID;
            this.Date_Time = Date_Time;
        }
    }
}