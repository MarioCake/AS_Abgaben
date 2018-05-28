using System;
using System.Collections.Generic;
using System.Text;

namespace Wiederholungen
{
    public class CellField
    {
        public static ConsoleColor TextColor { get; set; } = ConsoleColor.Gray;

        public List<Cell> Cells { get; private set; }
        public Vector2<int> Size { get; private set; }
        
        public int CellWidth { get; private set; } = 6;
        public int CellHeight { get; private set; } = 3;

        public CellField(Vector2<int> size)
        {
            Size = size;

            Cells = new List<Cell>(Size.X * Size.Y);
            for (int i = 0; i < Cells.Capacity; i++)
            {
                Cells.Add(new Cell(CellState.Water, i % Size.X, (int)Math.Floor((i * 1.0)/ Size.X)));
            }
        }

        private int CursorStartX { get; set; } = 1;
        private int CursorStartY { get; set; } = 1;

        private void SetCursorPosition(Vector2<int> pos)
        {
            Console.SetCursorPosition(pos.X + CursorStartX, pos.Y + CursorStartY);
        }

        

        public HitType Hit(int posX, int posY)
        {
            int index = posX + (posY * Size.X);

            return Cells[index].Hit();
        }

        public void Draw()
        {
            const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            SetCursorPosition(new Vector2<int>(CellWidth, CellHeight - 1));

            using (new ColorChanger(TextColor))
            {
                for (int i = 1; i <= Size.X; i++)
                {
                    SetCursorPosition(new Vector2<int>(i * CellWidth, CellHeight - 1));
                    Console.Write(i);
                }

                for (int i = 1; i <= Size.Y; i++)
                {
                    SetCursorPosition(new Vector2<int>(CellWidth - 1, (i * CellHeight)));
                    Console.Write(alphabet[i - 1]);
                }
            }
            bool evenField = true;
            for (int y = 0; y < Size.Y; y++)
            {
                for (int x = 0; x < Size.X; x++)
                {
                    int cellIndex = x + (y * Size.X);
                    SetCursorPosition(new Vector2<int>((x * CellWidth) + CellWidth, (y * CellHeight) + CellHeight));
                    Cells[cellIndex].Draw(CellWidth, CellHeight, evenField);
                    evenField = !evenField;
                }
                if (Size.X % 2 == 0)
                    evenField = !evenField;
            }
        }
    }
}
