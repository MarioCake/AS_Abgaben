using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wiederholungen
{
    public class Ship
    {
        public List<Cell> ShipParts { get; private set; }
        private int shipSize;

        public Ship(int shipSize)
        {
            this.shipSize = shipSize;
            ShipParts = new List<Cell>(shipSize);
        }
        public bool AllPartsHit()
        {
            foreach(Cell cell in ShipParts)
            {
                if (cell.State == CellState.ShipDown) return true;
                if (cell.State != CellState.ShipHit) return false;
            }

            return true;
        }
        
        public void MarkAsDown()
        {
            foreach (Cell cell in ShipParts)
            {
                cell.State = CellState.ShipDown;
            }
        }
        

        private bool FillShip(CellField field, int startX, int startY, int direction)
        {
            int startIndex = startX + (startY * field.Size.X);

            ShipParts.Clear();

            switch (direction)
            {
                default:
                case 0:
                    if (startX + shipSize >= field.Size.X) return false;
                    for (int i = 0; i < shipSize; i++)
                    {
                        Cell cell = field.Cells[startIndex + i];
                        ShipParts.Add(cell);
                    }

                    break;
                case 1:
                    if (startY + shipSize >= field.Size.Y) return false;
                    for (int i = 0; i < shipSize; i++)
                    {
                        Cell cell = field.Cells[startIndex + (i * field.Size.X)];
                        ShipParts.Add(cell);
                    }

                    break;
                case 2:
                    if (startX - shipSize < 0) return false;
                    for (int i = 0; i < shipSize; i++)
                    {
                        Cell cell = field.Cells[startIndex - i];
                        ShipParts.Add(cell);
                    }

                    break;
                case 3:
                    if (startY - shipSize < 0) return false;
                    for (int i = 0; i < shipSize; i++)
                    {
                        Cell cell = field.Cells[startIndex - (i * field.Size.X)];
                        ShipParts.Add(cell);
                    }

                    break;
            }
            return true;
        }

        public void PlaceShipRandomly(CellField field)
        {
            Random rnd = new Random();

            int startX = rnd.Next(field.Size.X);
            int startY = rnd.Next(field.Size.Y);
            int direction = rnd.Next(4);

            while (!FillShip(field, startX, startY, direction))
            {
                startX = rnd.Next(field.Size.X);
                startY = rnd.Next(field.Size.Y);
                direction = rnd.Next(4);
            }

        }

        public bool Intersects(Ship other)
        {
            if(ShipParts.Intersect(other.ShipParts).Any()) return true;

            foreach(Cell mainCell in ShipParts)
            {
                foreach(Cell otherCell in other.ShipParts)
                {
                    int xDiff = Math.Abs(mainCell.PosX - otherCell.PosX);
                    if (xDiff > 1) continue;

                    int yDiff = Math.Abs(mainCell.PosY - otherCell.PosY);
                    if (yDiff > 1) continue;

                    if (Math.Max(yDiff, xDiff) == 1 && Math.Min(yDiff, xDiff) == 0) return true;
                }
            }
            

            return false;
        }
    }
}
