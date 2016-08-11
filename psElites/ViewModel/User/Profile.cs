using psElites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace psElites.ViewModel.User
{
    public class ProfileViewModel
    {
        public int UserID { get; set; }
        public string GamerName { get; set; }
        public List<Game> RandGames { get; set; }
    }
}