using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STreeMode1.Models
{
    public class Order_Item
    {
        public int OrderID { get; set; }
        public int GameID { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public Order_Item() { }

        public Order_Item(int OrderID, int GameID, int Quantity, int Price)
        {
            this.OrderID = OrderID;
            this.GameID = GameID;
            this.Quantity = Quantity;
            this.Price = Price;
        }
    }
}