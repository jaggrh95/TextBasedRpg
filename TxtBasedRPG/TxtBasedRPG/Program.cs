using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo6();
        }

        static void Demo1()
        {
            string[] Kamers = new string[]
                {
                    "Je staat voor de ingang.",
                    "Je bent in de hal.",
                    "Je bent in het computerlabo",

                };

            for (int i = 0; i < Kamers.Length; i++)
            {
                Console.WriteLine(Kamers[i]);
                Console.ReadLine();
            }
        }

        static void Demo2()
        {
            string[] Kamers = new string[]
                {
                    "Je staat voor de ingang.",
                    "Je bent in de hal.",
                    "Je bent in het computerlabo",

                };

            int huidigekamer = 0;
            string keuze = "";
            while (keuze != "q")
            {
                Console.WriteLine(Kamers[huidigekamer]);

                Console.WriteLine("Vooruit= V, ACHTERUIT = A, q= quit");
                keuze = Console.ReadLine();
                if (keuze == "V" && huidigekamer != Kamers.Length - 1)
                    huidigekamer++;
                else if (keuze == "A" && huidigekamer != 0)
                    huidigekamer--;
                else if (keuze == "q")
                    Console.WriteLine("Byebye");
                else
                {
                    Console.WriteLine("Foute invoer");
                }
            }

        }

        static void Demo3()
        {
            int[,] Kaart =
                {
                    {1, 2, 1, 3},
                    {0, 1, 0, 1},
                    {0, 4, 0, 5}
                };

            string[] Kamers =
                {
                    "Onbekend terrein", //0
                    "In een gang", //1
                    "In de lobby", //2
                    "In de bar", //3
                    "In de keuken", //4
                    "Achtertuin"//5
                };

            int posX = 0;
            int posY = 0;

            while (true)
            {
                int kamerindex = Kaart[posX, posY];
                Console.WriteLine(Kamers[kamerindex]);

                Console.WriteLine("NOZW? Naar waar wil je?");

                char inp = Convert.ToChar(Console.ReadLine());
                switch (inp)
                {
                    case 'N':
                        if (posX != 0 && Kaart[posX - 1, posY] != 0)
                            posX--;
                        else Console.WriteLine("Kan niet");
                        break;
                    case 'O':
                        if (posY != Kaart.GetUpperBound(1) && Kaart[posX, posY + 1] != 0)
                            posY++;
                        else Console.WriteLine("Kan niet");
                        break;
                    case 'Z':
                        if (posX != Kaart.GetUpperBound(0) && Kaart[posX + 1, posY] != 0)
                            posX++;
                        else Console.WriteLine("Kan niet");
                        break;
                    case 'W':
                        if (posY != 0 && Kaart[posX, posY - 1] != 0)
                            posY--;
                        else Console.WriteLine("Kan niet");
                        break;
                }
            }
        }

        static void Demo4()
        {
            int[,] Kaart = { { 1, 2, 1, 3 }, { 0, 1, 0, 1 }, { 0, 4, 0, 5 } };

            string[] Kamers = { "Onbekend terrein", "In een gang", "In de lobby", "In de bar", "In de keuken", "Achtertuin" };

            int posX = 0;
            int posY = 0;

            while (true)
            {
                Console.Clear();
                DrawMap(Kaart, posX, posY);

                int kamerindex = Kaart[posX, posY];
                Console.WriteLine(Kamers[kamerindex]);

                Console.WriteLine("NOZW? Naar waar wil je?");

                char inp = Convert.ToChar(Console.ReadLine());
                switch (inp)
                {
                    case 'N':
                        if (posX != 0 && Kaart[posX - 1, posY] != 0)
                            posX--;
                        else Console.WriteLine("Kan niet");
                        break;
                    case 'O':
                        if (posY != Kaart.GetUpperBound(1) && Kaart[posX, posY + 1] != 0)
                            posY++;
                        else Console.WriteLine("Kan niet");
                        break;
                    case 'Z':
                        if (posX != Kaart.GetUpperBound(0) && Kaart[posX + 1, posY] != 0)
                            posX++;
                        else Console.WriteLine("Kan niet");
                        break;
                    case 'W':
                        if (posY != 0 && Kaart[posX, posY - 1] != 0)
                            posY--;
                        else Console.WriteLine("Kan niet");
                        break;
                }
            }
        }

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

        static void Demo5()
        {
            int[,] Kaart =
                {
                    {1, 2, 1, 3, 0, 0},
                    {0, 1, 0, 1, 0, 0},
                    {0, 4, 0, 1, 0, 0},
                    {0, 1, 0, 1, 0, 0},
                    {0, 7, 0, 6, 1, 8},

                };

            string[] Kamers =
                {
                    "Onbekend terrein", //0 
                    "In een gang", //1
                    "In de lobby", //2
                    "In de bar", //3
                    "In de keuken", //4
                    "Achtertuin",//5
                    "In de securityroom", //6
                    "In de personeelsruimte", //7
                    "In de folterkamer" //8

                };

            int posX = 0;
            int posY = 0;

            while (true)
            {
                Console.Clear();
                DrawMap(Kaart, posX, posY);

                int kamerindex = Kaart[posX, posY];
                Console.WriteLine(Kamers[kamerindex]);

                Console.WriteLine("NOZW? Naar waar wil je?");

                char inp = Convert.ToChar(Console.ReadLine());
                switch (inp)
                {
                    case 'N':
                        if (posX != 0 && Kaart[posX - 1, posY] != 0)
                            posX--;
                        else Console.WriteLine("Kan niet");
                        break;
                    case 'O':
                        if (posY != Kaart.GetUpperBound(1) && Kaart[posX, posY + 1] != 0)
                            posY++;
                        else Console.WriteLine("Kan niet");
                        break;
                    case 'Z':
                        if (posX != Kaart.GetUpperBound(0) && Kaart[posX + 1, posY] != 0)
                            posX++;
                        else Console.WriteLine("Kan niet");
                        break;
                    case 'W':
                        if (posY != 0 && Kaart[posX, posY - 1] != 0)
                            posY--;
                        else Console.WriteLine("Kan niet");
                        break;
                }
            }
        }

        static void Demo6()
        {
            int[,] Kaart =
                {
                    {1, 2, 1, 3, 0, 0},
                    {0, 1, 0, 1, 0, 0},
                    {0, 4, 0, 1, 0, 0},
                    {0, 1, 0, 1, 0, 0},
                    {0, 7, 0, 6, 1, 8},

                };

            string[] Kamers =
                {
                    "Onbekend terrein", //0 
                    "In een gang", //1
                    "In de lobby", //2
                    "In de bar", //3
                    "In de keuken", //4
                    "Achtertuin",//5
                    "In de securityroom", //6
                    "In de personeelsruimte", //7
                    "In de folterkamer" //8

                };

            string[] Beschrijving =
                                {
                    "", //0 
                    "Een ordinaire saaie gang met een mooie vloer", //1
                    "De receptioniste kijkt je verbaast aan. Een plant in de hoek is het enige groen in de purperen ruimte.", //2
                    "2 gasten zitten half beschonken aan de toog. Een verliefd koppel is zachtjes aan het praten", //3
                    "Overal liggen etensresten, maar verder is hier niets of niemand interessant.", //4
                    "Mooie plantjes, enkele bomen en een gezellig terras.",//5
                    "De veiligheidsagent houdt je nauwlettend in het oog", //6
                    "Overal staan kastjes.Hier en daar is er een personeelslid zich aan het omkleden", //7
                    "Wat doet deze vreemde plek in het hotel." //8

                };

            int posX = 0;
            int posY = 0;

            while (true)
            {
                Console.Clear();
                DrawMap(Kaart, posX, posY);

                int kamerindex = Kaart[posX, posY];
                Console.WriteLine(Kamers[kamerindex]);
                Console.WriteLine("******");
                Console.WriteLine(Beschrijving[kamerindex]);
                Console.WriteLine();
                Console.WriteLine("NOZW? Naar waar wil je?");

                char inp = Convert.ToChar(Console.ReadLine());
                switch (inp)
                {
                    case 'N':
                        if (posX != 0 && Kaart[posX - 1, posY] != 0)
                            posX--;
                        else Console.WriteLine("Kan niet");
                        break;
                    case 'O':
                        if (posY != Kaart.GetUpperBound(1) && Kaart[posX, posY + 1] != 0)
                            posY++;
                        else Console.WriteLine("Kan niet");
                        break;
                    case 'Z':
                        if (posX != Kaart.GetUpperBound(0) && Kaart[posX + 1, posY] != 0)
                            posX++;
                        else Console.WriteLine("Kan niet");
                        break;
                    case 'W':
                        if (posY != 0 && Kaart[posX, posY - 1] != 0)
                            posY--;
                        else Console.WriteLine("Kan niet");
                        break;
                }
            }
        }
        static void Demo7()
        {
            int[,] Kaart =
                {
                    {1, 2, 1, 3, 0, 0},{0, 1, 0, 1, 0, 0},{0, 4, 0, 1, 0, 0},{0, 1, 0, 1, 0, 0},{0, 7, 0, 6, 0, 0},
                };

            string[] Kamers =
                {
                    "Onbekend terrein", //0 
                    "In een gang", //1
                    "In de lobby", //2
                    "In de bar", //3
                    "In de keuken", //4
                    "Achtertuin",//5
                    "In de securityroom", //6
                    "In de personeelsruimte", //7
                    "In de folterkamer" //8

                };

            string[] Beschrijving =
                                {
                    "", //0 
                    "Een ordinaire saaie gang met een mooie vloer", //1
                    "De receptioniste kijkt je verbaast aan. Een plant in de hoek is het enige groen in de purperen ruimte.", //2
                    "2 gasten zitten half beschonken aan de toog. Een verliefd koppel is zachtjes aan het praten", //3
                    "Overal liggen etensresten, maar verder is hier niets of niemand interessant.", //4
                    "Mooie plantjes, enkele bomen en een gezellig terras.",//5
                    "De veiligheidsagent houdt je nauwlettend in het oog. Typ \"G\" om een geheime ruimte te ontdekken", //6
                    "Overal staan kastjes.Hier en daar is er een personeelslid zich aan het omkleden.", //7
                    "Wat doet deze vreemde plek in het hotel." //8

                };

            int posX = 0;
            int posY = 0;

            while (true)
            {
                Console.Clear();
                DrawMap(Kaart, posX, posY);

                int kamerindex = Kaart[posX, posY];
                Console.WriteLine(Kamers[kamerindex]);
                Console.WriteLine("******");
                Console.WriteLine(Beschrijving[kamerindex]);
                Console.WriteLine();
                Console.WriteLine("NOZW? Naar waar wil je?");

                char inp = Convert.ToChar(Console.ReadLine());
                switch (inp)
                {
                    case 'N':
                        if (posX != 0 && Kaart[posX - 1, posY] != 0)
                            posX--;
                        else Console.WriteLine("Kan niet");
                        break;
                    case 'O':
                        if (posY != Kaart.GetUpperBound(1) && Kaart[posX, posY + 1] != 0)
                            posY++;
                        else Console.WriteLine("Kan niet");
                        break;
                    case 'Z':
                        if (posX != Kaart.GetUpperBound(0) && Kaart[posX + 1, posY] != 0)
                            posX++;
                        else Console.WriteLine("Kan niet");
                        break;
                    case 'W':
                        if (posY != 0 && Kaart[posX, posY - 1] != 0)
                            posY--;
                        else Console.WriteLine("Kan niet");
                        break;
                    case 'G':
                        if (kamerindex != 6)
                        {
                            Console.WriteLine("Dat zal hier niet werken");
                        }
                        else
                        {
                            Console.WriteLine("Je ontdekt een geheime ruimte");
                            Kaart[4, 4] = 1;
                            Kaart[4, 5] = 8;
                            Console.ReadLine();
                        }
                        break;

                }
            }
        }


        static void Demo8()
        {
            int[,] Kaart;
            string[] Kamers;
            string[] Beschrijving;

            InitialiseerSpel(out Kaart, out Kamers, out Beschrijving);

            int posX = 0;
            int posY = 0;

            while (true)
            {
                Console.Clear();
                DrawMapCool(Kaart, posX, posY); //a

                int kamerindex = Kaart[posX, posY];
                Console.SetCursorPosition(26, 6); //b
                Console.WriteLine(Kamers[kamerindex]);

                Console.SetCursorPosition(1, 16);//c
                Console.WriteLine("******");
                Console.WriteLine(Beschrijving[kamerindex]);
                Console.WriteLine();
                Console.WriteLine("NOZW? Naar waar wil je?");

                VerwerkInput(Kaart, kamerindex, ref posX, ref posY);
            }
        }

        private static void InitialiseerSpel(
            out int[,] Kaart,
            out string[] Kamers,
            out string[] Beschrijving)
        {
            Kaart = new int[,]
                {
                {1, 2, 1, 3, 0, 0},
                {0, 1, 0, 1, 0, 0},
                {0, 4, 0, 1, 0, 0},
                {0, 1, 0, 1, 0, 0},
                {0, 7, 0, 6, 0, 0}
                };

            Kamers = new string[]
                {
                    "Onbekend terrein", "In een gang", "In de lobby", "In de bar", "In de keuken", "Achtertuin",
                    "In de securityroom", "In de personeelsruimte", "In de folterkamer"
                };

            Beschrijving = new string[]
                {
                    "", "Een ordinaire saaie gang met een mooie vloer",
                    "De receptioniste kijkt je verbaast aan. Een plant in de hoek is het enige groen in de purperen ruimte.",
                    "2 gasten zitten half beschonken aan de toog. Een verliefd koppel is zachtjes aan het praten",
                    "Overal liggen etensresten, maar verder is hier niets of niemand interessant.",
                    "Mooie plantjes, enkele bomen en een gezellig terras.",
                    "De veiligheidsagent houdt je nauwlettend in het oog. Typ \"G\" om een geheime ruimte te ontdekken",
                    "Overal staan kastjes.Hier en daar is er een personeelslid zich aan het omkleden.",
                    "Wat doet deze vreemde plek in het hotel."
                };
        }

        private static void VerwerkInput(
            int[,] Kaart,
            int kamerindex,
            ref int posX,
            ref int posY)
        {
            char inp = Convert.ToChar(Console.ReadLine());
            switch (inp)
            {
                //etc
                case 'N':
                    if (posX != 0 && Kaart[posX - 1, posY] != 0)
                        posX--;
                    else Console.WriteLine("Kan niet");
                    break;
                case 'O':
                    if (posY != Kaart.GetUpperBound(1) && Kaart[posX, posY + 1] != 0)
                        posY++;
                    else Console.WriteLine("Kan niet");
                    break;
                case 'Z':
                    if (posX != Kaart.GetUpperBound(0) && Kaart[posX + 1, posY] != 0)
                        posX++;
                    else Console.WriteLine("Kan niet");
                    break;
                case 'W':
                    if (posY != 0 && Kaart[posX, posY - 1] != 0)
                        posY--;
                    else Console.WriteLine("Kan niet");
                    break;
                case 'G':
                    if (kamerindex == 6)
                    {
                        Console.WriteLine("Je ontdekt een geheime ruimte");
                        Kaart[4, 4] = 1;
                        Kaart[4, 5] = 8;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Dat zal hier niet werken");
                    }
                    break;
            }
        }

        private static void DrawMapCool(int[,] Kaart, int posX, int posY)
        {
            string background =
                                @".-/|~~~~~~~MAP~~~~~~~~~\/~~~~~~~~**~~~~~~~~|\-." + "\n" +
                                @"||||                    :                    ||||" + "\n" +
                                @"||||                    :                    ||||" + "\n" +
                                @"||||                    :                    ||||" + "\n" +
                                @"||||                    :                    ||||" + "\n" +
                                @"||||                    :                    ||||" + "\n" +
                                @"||||                    :                    ||||" + "\n" +
                                @"||||                    :                    ||||" + "\n" +
                                @"||||                    :                    ||||" + "\n" +
                                @"||||___________________ : ___________________||||" + "\n" +
                                @"||/====================\:/====================\||" + "\n" +
                                @"`---------------------~---~--------------------''";

            ConsoleColor oll = Console.ForegroundColor; //1
            Console.ForegroundColor = ConsoleColor.DarkCyan; //2
            for (int i = 0; i < background.Length; i++)
            {
                if (background[i] != ' ' && background[i] != '_')
                    Console.Write(background[i]); //3
                else
                {
                    ConsoleColor bll = Console.BackgroundColor;//1
                    Console.BackgroundColor = ConsoleColor.DarkYellow;//2
                    Console.Write(background[i]);//3
                    Console.BackgroundColor = bll;//4

                }
            }

            Console.ForegroundColor = oll;//4

            ConsoleColor bll2 = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.DarkYellow;

            for (int i = 0; i <= Kaart.GetUpperBound(0); i++)
            {
                Console.SetCursorPosition(7, 3 + i);
                for (int j = 0; j <= Kaart.GetUpperBound(1); j++)
                {
                    if (posX == i & posY == j)
                    {
                        ConsoleColor l = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("X");
                        Console.ForegroundColor = l;

                    }

                    else
                        if (Kaart[i, j] != 0)
                        Console.Write("o");
                    else
                        Console.Write(" ");
                }
                Console.Write('\n');


            }
            Console.SetCursorPosition(1, 15);
            Console.BackgroundColor = bll2;
        }

        static void Demo9()
        {
            int[,] Kaart;
            string[] Kamers;
            string[] Beschrijving;

            InitialiseerSpel(out Kaart, out Kamers, out Beschrijving);

            int posX = 0;
            int posY = 0;

            while (true)
            {
                Console.Clear();
                DrawMapCoolV2(Kaart, posX, posY, 15, 5); //a

                int kamerindex = Kaart[posX, posY];
                Console.SetCursorPosition(26, 6); //b
                Console.WriteLine(Kamers[kamerindex]);

                Console.SetCursorPosition(1, 16);//c
                Console.WriteLine("******");
                Console.WriteLine(Beschrijving[kamerindex]);
                Console.WriteLine();
                Console.WriteLine("NOZW? Naar waar wil je?");

                VerwerkInput(Kaart, kamerindex, ref posX, ref posY);
            }
        }
        private static void DrawMapCoolV2(int[,] Kaart, int posX, int posY, int kaartposX, int kaartposY)
        {
            string topbook =
                @".-/|~~~~~~~MAP~~~~~~~~~\/~~~~~~~~**~~~~~~~~|\-.";
            string middlebook = @"||||                    :                    ||||";
            string bottombook = @"||/====================\:/====================\||" + "\n" +
                                @"`---------------------~---~--------------------''";

            //Teken boek
            Console.SetCursorPosition(kaartposX, kaartposY);
            Console.Write(topbook);
            for (int i = 0; i < Kaart.GetUpperBound(0) + 5; i++)
            {
                Console.SetCursorPosition(kaartposX, kaartposY + i + 1);
                Console.Write(middlebook);
            }
            Console.SetCursorPosition(kaartposX, kaartposY + Kaart.GetUpperBound(1) + 5);
            Console.Write(bottombook);

            //Teken kaart
            for (int i = 0; i <= Kaart.GetUpperBound(0); i++)
            {
                Console.SetCursorPosition(5 + kaartposX, 2 + i + kaartposY);
                for (int j = 0; j <= Kaart.GetUpperBound(1); j++)
                {
                    if (posX == i & posY == j)
                    {
                        ConsoleColor l = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("X");
                        Console.ForegroundColor = l;

                    }

                    else
                        if (Kaart[i, j] != 0)
                        Console.Write("o");
                    else
                        Console.Write(" ");
                }
                Console.Write('\n');


            }

        }
    }
}
