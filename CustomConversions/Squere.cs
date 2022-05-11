using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomConversions
{
    public struct Squere
    {
        public int width { get; set; }
        public Squere(int width):this()
        {
            this.width = width;
        }
        public void Draw()
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public override string ToString() => $"[Width={width}]";
        public static explicit operator Squere(Rectangle r)
        {
            Squere squere = new Squere {width=r.width};
            return squere;
            
        }
        public static explicit operator Squere(int sideLength)
        {
            Squere newSq = new Squere { width = sideLength };
            return newSq;
        }
        public static explicit operator int(Squere s) => s.width;

    }
}