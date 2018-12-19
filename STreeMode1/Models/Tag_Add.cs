using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STreeMode1.Models
{
    public class Tag_Add
    {
        public int GameID { get; set; }
        public int TagID { get; set; }

        public Tag_Add() { }

        public Tag_Add(int GameID, int TagID)
        {
            this.GameID = GameID;
            this.TagID = TagID;
        }
    }
}