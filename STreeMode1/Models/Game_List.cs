using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STreeMode1.Models
{
    public class Game_List
    {
        public int Id { get; set; }
        public DateTime Date_Time { get; set; }
        public int Profit { get; set; }
        public int Sell_Quantity { get; set; }

        public Game_List() { }

        public Game_List(int Id, DateTime Date_Time, int Profit, int Sell_Quantity)
        {
            this.Id = Id;
            this.Date_Time = Date_Time;
            this.Profit = Profit;
            this.Sell_Quantity = Sell_Quantity;
        }
    }
}