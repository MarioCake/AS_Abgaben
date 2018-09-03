using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wiederholungen
{
    public class BattleshipsGame
    {
        public CellField Field { get; private set; }
        public List<Ship> Ships { get; private set; }
        
        private int currentMessage = 0;

        private void SetWindowSize()
        {
            Console.WindowWidth = Field.CellWidth * (Field.Size.X + 2);
            Console.WindowHeight = Field.CellHeight * (Field.Size.Y + 4);
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
        }

        private void GenerateShips()
        {
            Ship submarine1 = new Ship(2);
            Ship submarine2 = new Ship(2);
            Ship submarine3 = new Ship(2);
            Ship submarine4 = new Ship(2);
            Ship destroyer1 = new Ship(3);
            Ship destroyer2 = new Ship(3);
            Ship destroyer3 = new Ship(3);
            Ship cruiser1   = new Ship(4);
            Ship cruiser2   = new Ship(4);
            Ship battleship = new Ship(5);

            Ships = new List<Ship>
            {
                submarine1,
                submarine2,
                submarine3,
                submarine4,
                destroyer1,
                destroyer2,
                destroyer3,
                cruiser1,
                cruiser2,
                battleship
            };
        }

        private void PlaceShips()
        {
            DateTime start;
            bool replace = true;

            while (replace)
            {
                start = DateTime.Now;
                replace = false;
                foreach (Ship shipToPlace in Ships)
                {
                    do
                    {
                        shipToPlace.PlaceShipRandomly(Field);

                        replace = (DateTime.Now - start).TotalSeconds > 1;
                    } while (!replace && Ships.Any(ship => ship != shipToPlace && ship.Intersects(shipToPlace)));

                    if (replace) break;
                }
            }
        }

        private void MapShips()
        {
            foreach(Ship ship in Ships)
            {
                foreach(Cell cell in ship.ShipParts)
                {
                    cell.State = CellState.Ship;
                    cell.Ship = ship;
                }
            }
        }

        public Vector2<int> ParsePosition(string position)
        {

            return new Vector2<int>(-1, -1);
        }

        public HitType Hit(int posX, int posY)
        {
            return Field.Hit(posX, posY);
        }

        public BattleshipsGame(Vector2<int> size)
        {
            Field = new CellField(size);

            SetWindowSize();

            GenerateShips();
            PlaceShips();
            MapShips();

        }
        public int FieldStartPosition {
            get
            {
                return Field.CellWidth + 1;
            }
        }

        public void Draw()
        {
            Field.Draw();

            Console.SetCursorPosition(0, Field.CellHeight * (Field.Size.Y + 2));
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(FieldStartPosition, Field.CellHeight * (Field.Size.Y + 2));
            ColoredWriter.Write("Feld abschießen: ", CellField.TextColor);
        }

        public bool IsOver()
        {
            foreach(Ship ship in Ships)
            {
                if (!ship.AllPartsHit()) return false;
            }

            return true;
        }

        public void ClearMessages()
        {
            Console.Clear();
            currentMessage = 0;
        }

        public void WriteInstruction(string message, ConsoleColor? foregroundColor = null, ConsoleColor? backgroundColor = null)
        {
            Console.CursorTop = Math.Min(Field.CellHeight * (Field.Size.Y + 2), Console.BufferHeight - 1);
            Program.ClearCurrentLine();
            Console.CursorLeft = FieldStartPosition;
            ColoredWriter.WriteLine(message, foregroundColor, backgroundColor);
        }

        public void WriteMessage(string message, ConsoleColor? foregroundColor = null, ConsoleColor? backgroundColor = null)
        {
            Console.CursorTop = Math.Min(Field.CellHeight * (Field.Size.Y + 2) + (++currentMessage), Console.BufferHeight-1);
            Program.ClearCurrentLine();
            Console.CursorLeft = FieldStartPosition;
            ColoredWriter.WriteLine(message, foregroundColor, backgroundColor);
        }
    }
}
