using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STreeMode1.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Game() { }

        public Game(int Id, string Name, int Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
        }
    }
}