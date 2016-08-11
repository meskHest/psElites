using psElites.Models;
using psElites.Models.DAL;
using psElites.ViewModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using psElites.Extensions;
using psElites.ViewModel;

namespace psElites.Controllers
{
    public class HomeController : Controller
    {
        testModel dbContext = new testModel();

       // psElites.Models.DAL.psElitesEntities dbContext = new Models.DAL.psElitesEntities();
        public ActionResult Index()
        {
            var model = new StartPageViewModel();
            using (var ctx = new testModel())
            {
                var gc = ctx.GameCollection.ToList();
                var g = ctx.Game.ToList();
                var cc = ctx.Console.ToList();
                var users = ctx.User.ToList();
                if(users.Any())
                {
                    var user = users.First(x => x.Username.ToLower() == "radx");
                        model.User = user;
                    model.Members = EnumerableExtension.PickRandom(users, 2).ToList();
                    model.OurGames = EnumerableExtension.PickRandom(g, 1).ToList();
                }

            }
                
            return View(model);
        }

        public ActionResult Profile()
        {

            var model = new ProfileViewModel();
            using (var ctx = new testModel())
            {
                var gc = ctx.GameCollection.ToList();
                var g = ctx.Game.ToList();
                var cc = ctx.Console.ToList();
                var user = ctx.User.FirstOrDefault(x=>x.UserID == 1);


                model.UserID = user.UserID;
                model.GamerName = user.Username;
                var games = user.Collection.Games.ToList();
                model.RandGames = EnumerableExtension.PickRandom(games, 5).ToList();

            }
            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}