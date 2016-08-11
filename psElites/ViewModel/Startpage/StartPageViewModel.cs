using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace psElites.ViewModel
{
    public class StartPageViewModel
    {
        public psElites.Models.User User{ get; set; }
        public List<psElites.Models.User> Members { get; set; }
        public List<psElites.Models.Game> OurGames { get; set; }
    }
}