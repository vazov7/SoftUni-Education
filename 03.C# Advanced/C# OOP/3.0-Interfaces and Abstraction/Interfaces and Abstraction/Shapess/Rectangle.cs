using System;
using System.Collections.Generic;
using System.Text;

namespace Shapess
{
    public class Rectangle : IDrawable
    {
        public Rectangle(int wid, int hei)
        {
            this.width = wid;
            this.height = hei;
        }
        private int width;
        private int height;
        public void Draw()
        {
            DrawLine(this.width, '*', '*');
            for (int i = 1; i < this.height - 1; ++i)
                DrawLine(this.width, '*', ' ');
            DrawLine(this.width, '*', '*');
        }
        private void DrawLine(int width, char end, char mid)
        {
            Console.Write(end);
            for (int i = 1; i < width - 1; ++i)
                Console.Write(mid);
            Console.WriteLine(end);
        }

    }
}
