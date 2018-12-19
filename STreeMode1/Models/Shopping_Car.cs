using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STreeMode1.Models
{
    public class Shopping_Car
    {
        public int CustomerID { get; set; }
        public int GameID { get; set; }
        public int Game_Quantity { get; set; }
        public DateTime Date_Time { get; set; }

        public Shopping_Car() { }

        public Shopping_Car(int CustomerID, int GameID, DateTime Date_Time, int Game_Quantity)
        {
            this.CustomerID = CustomerID;
            this.GameID = GameID;
            this.Date_Time = Date_Time;
            this.Game_Quantity = Game_Quantity;
        }
    }
}