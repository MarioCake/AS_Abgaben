using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;

namespace Wiederholungen
{
    class Program
    {
        public static void ClearCurrentLine()
        {
            Console.CursorLeft = 0;
            Console.Write(new string(' ', Console.WindowWidth));
            Console.CursorTop--;
        }


        static void Main(string[] args)
        {
            const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            ResizabilityHandler.DisableConsoleReziability();
            Console.CursorVisible = false;

            Console.BackgroundColor = ConsoleColor.White;
            CellField.TextColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.DarkGreen;


            BattleshipsGame player1 = new BattleshipsGame(new Vector2<int>(10, 10));
            BattleshipsGame player2 = new BattleshipsGame(new Vector2<int>(10, 10));

            BattleshipsGame currentField = player1;

            string currentPlayer = "Spieler 1";
            bool switchPlayer = false;



            while (!currentField.IsOver())
            {
                currentField.ClearMessages();

                bool continueLoop = false;

                currentField = switchPlayer ? (currentField == player1 ? player2 : player1) : currentField;

                currentPlayer = currentField == player1 ? "Spieler 1" : "Spieler 2";

                Console.SetCursorPosition(0, 0);
                ClearCurrentLine();
                ColoredWriter.Write(currentPlayer, ConsoleColor.Black, ConsoleColor.Yellow);

                currentField.Draw();

                string input = Console.ReadLine();

                char character = '\0';
                int number = 0;

                ClearCurrentLine();

                bool error = false;


                if (Regex.IsMatch(input, @"^([a-z]|[A-Z])\d$"))
                {
                    character = input[0];
                    number = int.Parse(input[1].ToString());

                }
                else if (Regex.IsMatch(input, @"^\d([a-z]|[A-Z])$"))
                {
                    character = input[1];
                    number = int.Parse(input[0].ToString());
                }
                else if (Regex.IsMatch(input, @"^\d\d([a-z]|[A-Z])$"))
                {
                    character = input[2];
                    number = int.Parse(input[0].ToString() + input[1].ToString());
                }
                else if (Regex.IsMatch(input, @"^([a-z]|[A-Z])\d\d$"))
                {
                    character = input[0];
                    number = int.Parse(input[1].ToString() + input[2].ToString());
                }
                else
                {
                    currentField.WriteMessage("Falsches Format (z = Zahl, b = Buchstabe): zb, bz, zzb, bzz", ConsoleColor.Red, ConsoleColor.White);
                    switchPlayer = false;
                    continueLoop = true;
                }
                if (!continueLoop)
                {
                    int posX = number - 1;
                    int posY = alphabet.ToLower().IndexOf(character.ToString().ToLower());

                    if (posY >= currentField.Field.Size.Y || posY == -1)
                    {
                        currentField.WriteMessage($"Der Buchstabe muss zwischen A und {alphabet[currentField.Field.Size.X - 1]} liegen.");
                        error = true;
                    }


                    if (posX >= currentField.Field.Size.X || posX == -1)
                    {
                        currentField.WriteMessage($"Die Zahl muss zwischen 1 und {currentField.Field.Size.Y} liegen.");
                        error = true;
                    }

                    HitType hit = HitType.None;
                    if (!error)
                    {

                        hit = currentField.Hit(posX, posY);
                        switch (hit)
                        {
                            case HitType.SameSpotHit:
                                error = true;
                                currentField.WriteMessage("Feld schonmal abgeschossen! Neuer Versuch.", ConsoleColor.Red, ConsoleColor.White);
                                break;
                            case HitType.ShipDown:
                                currentField.WriteMessage("Schiff versenkt!", ConsoleColor.Green, ConsoleColor.Black);
                                break;
                            case HitType.WaterHit:
                                currentField.WriteMessage("Wasser getroffen.", ConsoleColor.Blue);
                                break;
                            case HitType.ShipHit:
                                currentField.WriteMessage("Schiff getroffen!", ConsoleColor.Yellow, ConsoleColor.Black);
                                break;
                        }

                    }

                    switchPlayer = !error;
                }
                currentField.Draw();
                Console.CursorTop = 0;
                Console.CursorLeft = 0;
                using (new ColorChanger(backgroundColor: ConsoleColor.Green))
                {
                    for (int i = 0; i < Console.WindowWidth; i++)
                    {
                        Thread.Sleep(1000 / Console.WindowWidth);
                        Console.Write(" ");
                    }
                }

            }

            currentField.Draw();
            Console.WriteLine();

            if (currentField == player1)
                currentField.WriteMessage("Spieler 2 hat gewonnen!");
            else
                currentField.WriteMessage("Spieler 1 hat gewonnen!");

            Console.ReadKey();
        }



    }
}
