using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace psElites.Models
{
    public class Console
    {
        public Console() { }
        [Key]
        public int ConsoleID { get; set; }
        public string Name { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}