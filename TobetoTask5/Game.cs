using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobetoTask5
{
    public class Game
    {
        public List<FootballPlayer> footballPlayers = new List<FootballPlayer>();
        Random random = new Random();
        public Game()
        {
            footballPlayers.Add(new Defense("defans", 1));
            footballPlayers.Add(new Defense("defans", 2));
            footballPlayers.Add(new Defense("defans", 3));
            footballPlayers.Add(new Defense("defans", 4));
            footballPlayers.Add(new MidFielder("ortasaha", 5));
            footballPlayers.Add(new MidFielder("ortasaha", 6));
            footballPlayers.Add(new MidFielder("ortasaha", 7));
            footballPlayers.Add(new MidFielder("ortasaha", 8));
            footballPlayers.Add(new Striker("forvet", 9));
            footballPlayers.Add(new Striker("forvet", 10));
        }


        public void StartGame()
        {

            bool golsansi = true;
            int formano = 0;
            int formanokontrol = 31;
            for (int c = 0; c < 3; c++)
            {
                Console.WriteLine("pas vermek için enter bas");
                Console.ReadLine();
                formano = random.Next(1, 11);
                while (formanokontrol == formano)
                {
                    formano = random.Next(1, 11);
                }
                formanokontrol = formano;
                if (footballPlayers[formano - 1].TryToPass())
                {
                    Console.WriteLine(formano + " numaralı oyuncudan");
                    Console.WriteLine("güzel pas");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("pas başarısız");
                    golsansi = false;
                    break;
                }
            }
            if (golsansi == true)
            {
                Console.WriteLine("Şut çekmek için enter bas");
                Console.ReadLine();
                if (footballPlayers[formano - 1].TryToShoot())
                {
                    Console.WriteLine(formano + " numara");
                    Console.WriteLine("gol");
                }
                else
                    Console.WriteLine("Şut pazara gitti");

            }
            if (golsansi == false)
            {
                Console.WriteLine("gol bulamadın");
            }


            Console.ReadLine();
        }
    }
}
