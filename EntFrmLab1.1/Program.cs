using EntFrmLab1._1.DAL;
using EntFrmLab1._1.DAL.Models;

namespace EntFrmLab1._1
{
    internal class Program
    {
        static void Main()
        {
            List<GameInfo> gameInfoList = new List<GameInfo>()
                {
                    new GameInfo()
                    {
                        GameName = "Elden Ring",
                        Studio = "From Software",
                        Genre = "Souls Like",
                        ReleaseDate = new DateTime(2022,02,25),
                    },
                    new GameInfo()
                    {
                        GameName = "Lies of P",
                        Studio = "NEOWIZ",
                        Genre = "Souls Like",
                        ReleaseDate = new DateTime(2023, 09, 18),
                    }
                };
            /*using (var context = new Context())
            {
                context.Games.AddRange(gameInfoList);
                context.SaveChanges();
            }*/
            using (var context = new Context())
            {
                var games = context.Games;
                foreach (var game in games)
                {
                    Console.WriteLine($"Name:{game.GameName}\nStudio:{game.Studio}\nGenre:{game.Genre}\nRelease Date:{game.ReleaseDate}\nCopies Sold:{game.CopiesSold}\nMultiplayer:{game.IsMultiplayer}\n");
                    if (game.IsMultiplayer == null || game.CopiesSold == null)
                    {
                        game.IsMultiplayer = true;
                        game.CopiesSold = 100;
                        context.SaveChanges();
                    }

                }

            }
        }
    }
}