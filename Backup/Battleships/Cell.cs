using System;
using System.Collections.Generic;
using System.Text;

namespace Wiederholungen
{
    public class Cell
    {
        public static ConsoleColor WaterColor { get; set; } = ConsoleColor.Cyan;
        public static ConsoleColor WaterEvenColor { get; set; } = ConsoleColor.DarkCyan;
        public static ConsoleColor WaterHitColor { get; set; } = ConsoleColor.Blue;
        public static ConsoleColor WaterHitEvenColor { get; set; } = ConsoleColor.DarkBlue;
        public static ConsoleColor ShipHitColor { get; set; } = ConsoleColor.Yellow;
        public static ConsoleColor ShipHitEvenColor { get; set; } = ConsoleColor.DarkYellow;
        public static ConsoleColor ShipColor { get; set; } = WaterColor;
        public static ConsoleColor ShipEvenColor { get; set; } = WaterEvenColor;
        public static ConsoleColor ShipDownColor { get; set; } = ConsoleColor.Red;
        public static ConsoleColor ShipDownEvenColor { get; set; } = ConsoleColor.DarkRed;
        

        public Ship Ship { get; set; }
        public CellState State { get; set; }

        public int PosX { get; private set; }
        public int PosY { get; private set; }

        public Cell(CellState state, int posX, int posY)
        {
            State = state;
            PosX = posX;
            PosY = posY;
        }

        public HitType Hit()
        {

            if (State == CellState.Ship) {
                State = CellState.ShipHit;
                if (Ship.AllPartsHit())
                {
                    Ship.MarkAsDown();
                    return HitType.ShipDown;
                }


                return HitType.ShipHit;
            }

            if(State != CellState.Water) return HitType.SameSpotHit;

            State = CellState.WaterHit;
            return HitType.WaterHit;
        }

        public void Draw(int cellWidth, int cellHeight, bool even)
        {
            ConsoleColor? drawColor = null;

            switch (State)
            {
                case CellState.Ship:
                    drawColor = even ? ShipColor : ShipEvenColor;
                    break;
                case CellState.Water:
                    drawColor = even ? WaterColor : WaterEvenColor;
                    break;
                case CellState.WaterHit:
                    drawColor = even ? WaterHitColor : WaterHitEvenColor;
                    break;
                case CellState.ShipHit:
                    drawColor = even ? ShipHitColor : ShipHitEvenColor;
                    break;
                case CellState.ShipDown:
                    drawColor = even ? ShipDownColor : ShipDownEvenColor;
                    break;
                default:
                    break;
            }

            int startX = Console.CursorLeft;
            int startY = Console.CursorTop;
            using (new ColorChanger(backgroundColor: drawColor))
            {
                for (int y = 0; y < cellHeight; y++)
                    for (int x = 0; x < cellWidth; x++)
                    {
                        Console.SetCursorPosition(startX + x, startY + y);
                        Console.Write(" ");
                    }
            }
            Console.SetCursorPosition(startX + cellWidth, startY);
        }
    }
}
