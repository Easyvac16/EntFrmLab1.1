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
            ShowData();
            Console.WriteLine("------------------");
            DeleteData();
            Console.WriteLine("-----------------------");
            ShowData();
        }



        public static void ShowData()
        {
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
                    }

                }

            }
        }

        public static GameInfo MapData()
        {
            GameInfo gameInfo = new GameInfo();

            Console.WriteLine("Game name:");
            gameInfo.GameName = Console.ReadLine();

            Console.WriteLine("Game Genre:");
            gameInfo.Genre = Console.ReadLine();

            Console.WriteLine("Game studio:");
            gameInfo.Studio = Console.ReadLine();

            Console.WriteLine("Copies solded");
            int.TryParse(Console.ReadLine(), out int buffer);
            gameInfo.CopiesSold = buffer;

            Console.WriteLine("Release date:");
            DateTime.TryParse(Console.ReadLine(), out DateTime date);
            gameInfo.ReleaseDate = date;



            return gameInfo;
        }

        public static void InsertData()
        {
            using (var context = new Context())
            {
                context.Games.Add(MapData());
                context.SaveChanges();
            }
        }

        public static void UpdateData()
        {
            using (var context = new Context())
            {
                var game = context.Games.FirstOrDefault();
                game.Genre = "Souls";
                context.Games.Update(game);
                context.SaveChanges();
            }
        }

        public static void DeleteData() 
        {
            using (var context = new Context()) 
            {
                var game = context.Games.FirstOrDefault();
                context.Games.Remove(game);
                context.SaveChanges();
            }
        }
    }
}