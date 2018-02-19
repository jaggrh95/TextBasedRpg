using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeArrayDemo
{
    class Program
    {
        private static void DrawMap(int[,] Kaart, int posX, int posY)
        {
            for (int i = 0; i <= Kaart.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= Kaart.GetUpperBound(1); j++)
                {
                    if (posX == i & posY == j)
                        Console.Write("X");
                    else if (Kaart[i, j] != 0)
                        Console.Write("o");
                    else
                        Console.Write(" ");
                }
                Console.Write('\n');
            }
        }
        static void Main()
        {
            int[,] Kaart =
                {
                    {0, 4, 0, 0, 5, 3, 1},
                    {0, 1, 0, 7, 0, 0, 1},
                    {3, 1, 0, 6, 0, 0, 1},
                    {1, 0, 0, 5, 0, 0, 1},
                    {1, 1, 1, 1, 1, 1, 1},
                    {0, 0, 0, 1, 0, 0, 0},
                    {0, 0, 0, 2, 0, 0, 0},
                    {0, 0, 0, 1, 0, 0, 0},
                };

            string[] Kamers =
                {
                    "Wall", //0 
                    "gang", //1
                    "HiddenGang", //2
                    "MonsterRoom 1", //3
                    "MonsterRoom 2", //4
                    "Key Room",//5
                    "Boss Room", //6
                    "Treasure Room", //7
                    "Secret" //8

                };

            string[] Beschrijving =
                                {
                    "", //0 
                    "Normale Gang, Geen gevaren", //1
                    "Deze Gang heeft een speciale schijn rond zich.", //2
                    "Je Ziet een grote cycloop voor je! Geef V in om te vechten! ", //3
                    "Een groot skelet staat voor je! Geef V in om te Vechten!", //4
                    "Je moet 2 sleutels hebben om door de grote deur voor je te raken.",//5
                    "Een gigantische draak staat voor je! Druk V om te Vechten", //6
                    "Je hebt de grote schat gevonden! Je wint!", //7
                    "Je vindt hier een hidden Power-up! je krijgt 10 extra krachtpunten!" //8

                };

            int posX = 7;
            int posY = 3;

            while (true)
            {
                Console.Clear();
                DrawMap(Kaart, posX, posY);

                int kamerindex = Kaart[posX, posY];
                Console.WriteLine(Kamers[kamerindex]);
                Console.WriteLine("******");
                Console.WriteLine(Beschrijving[kamerindex]);
                Console.WriteLine();
                Console.WriteLine("Up , Down , Left of Right (UDLR)");

                char inp = Convert.ToChar(Console.ReadLine());
                switch (inp)
                {
                    case 'U':
                        if (posX != 0 && Kaart[posX - 1, posY] != 0)
                            posX--;
                        else Console.WriteLine("Kan niet");
                        break;
                    case 'R':
                        if (posY != Kaart.GetUpperBound(1) && Kaart[posX, posY + 1] != 0)
                            posY++;
                        else Console.WriteLine("Kan niet");
                        break;
                    case 'D':
                        if (posX != Kaart.GetUpperBound(0) && Kaart[posX + 1, posY] != 0)
                            posX++;
                        else Console.WriteLine("Kan niet");
                        break;
                    case 'L':
                        if (posY != 0 && Kaart[posX, posY - 1] != 0)
                            posY--;
                        else Console.WriteLine("Kan niet");
                        break;
                    case 'G':
                        if (kamerindex != 2)
                        {
                            Console.WriteLine("Je duwt op elke muur, Je ziet eruit als een idioot terwijl je dit doet.");
                            Console.ReadLine();

                        }
                        else
                        {
                            Console.WriteLine("Je duwt op elke muur, een geheime kamer opent zich!");
                            Kaart[6, 4] = 8;
                            
                            Console.ReadLine();
                        }
                        break;

                }
            }
        }
    }
}
