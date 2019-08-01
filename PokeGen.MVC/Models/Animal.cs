﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokeGen.MVC.Models
{
    public class Animal
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}