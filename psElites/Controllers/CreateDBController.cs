using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using psElites.Models;
using System.Collections.ObjectModel;

namespace psElites.Controllers
{
    public class CreateDBController : Controller
    {
        // GET: CreateDB
        public ActionResult Index()
        {




            var console = new Models.Console
            {
                Name = "Playstation 4"
            };


            using (var ctx = new Models.DAL.testModel())
            {
                ctx.Console.Add(console);

                var games = new List<string>(){ "NHL 17", "FIFA 16", "No man's sky", "Assassins Creed",
                    "Attack on titan", "Party Hard", "Destiny", "Curse of monkey island",
                    "The walking dead", "Race the sun", "Gran turismo", "Rock band 3", "Journey"};

                var gamesList = new Collection<Game>();

                foreach (var g in games)
                {
                    var game = new Game
                    {
                        Name = g,
                        Console = console
                    };
                    ctx.Game.Add(game);
                    gamesList.Add(game);
                }

                var names = new List<string>() {
                    "rbnbghl",
                    "rockaz87",
                    "rehnmaise",
                    "ludde_lada83",
                    "sku77z0n3",
                    "RadX"
                };

                var user = new User
                {
                    Email = "meskhest@gmail.com",
                    FirstName = "Fredrik",
                    LastName = "Olsson",
                    Username = "RadX",
                    Password = "password"
                };

                var users = new List<User>();
                users.Add(user);

                var gc = new GameCollection
                {
                    Games = gamesList
                };

                user.Collection = gc;
                ctx.User.Add(user);
                ctx.SaveChanges();


                //ctx.GameCollection.Add(gc);
                //ctx.SaveChanges();

                //var listOfUsers = ctx.User.ToList();
                //foreach(var u in listOfUsers)
                //{
                //    u.Games = ctx.GameCollection.FirstOrDefault(x => x.User.UserID == u.UserID);
                //}
                //ctx.SaveChanges();
            }



            return View();
        }
    }
}