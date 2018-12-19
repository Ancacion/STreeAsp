using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STreeMode1.Models
{
    public class Comment
    {
        public int CustomerID { get; set; }
        public int GameID { get; set; }
        public DateTime Date_Time { get; set; }
        public int Score { get; set; }
        public string Impression { get; set; }

        public Comment() { }

        public Comment(int CustomerID, int GameID, DateTime Date_Time, int Score, string Impression)
        {
            this.CustomerID = CustomerID;
            this.GameID = GameID;
            this.Date_Time = Date_Time;
            this.Score = Score;
            this.Impression = Impression;
        }
    }
}