using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            float x1, y1, x2, y2, x, y, dx, dy, step, i = 1;
            x1 = float.Parse(Console.ReadLine());
            y1 = float.Parse(Console.ReadLine());
            x2 = float.Parse(Console.ReadLine());
            y2 = float.Parse(Console.ReadLine());
            step = 0;

            dx = x2 - x1;
            dy = y2 - y1;
            x = x1;
            y = y1;

            if (Math.Abs(dx) >= Math.Abs(dy))
            {
                step = Math.Abs(dx);
            }
            else if (Math.Abs(dx) < Math.Abs(dy))
            {
                step = Math.Abs(dy);
            }
            else if (i <= step && dx != step && dy != step)
            {
                step = float.Parse(Console.ReadLine());
                i = float.Parse(Console.ReadLine());
                Console.Write("{0},{1}", x, y);
                x += dx;
                y += dy;
                i++;
            }
            else
            {
                Console.Write("End");
            }
            Console.ReadLine();
        }
    }
}
