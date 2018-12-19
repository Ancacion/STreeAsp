using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STreeMode1.Models
{
    public class Game_List_Add
    {
        public int GameID { get; set; }
        public int Game_List_ID { get; set; }

        public Game_List_Add() { }

        public Game_List_Add(int GameID, int Game_List_ID)
        {
            this.GameID = GameID;
            this.Game_List_ID = Game_List_ID;
        }
    }
}