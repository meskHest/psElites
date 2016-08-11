using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace psElites.Models
{
    public class Game
    {
        public Game() { }
        [Key]
        public int GameID { get; set; }
        public string Name { get; set; }        
        public Console Console { get; set; }
    }
}