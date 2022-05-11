using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomConversions
{
    public struct Rectangle
    {
        public int width { get; set; }
        public int height { get; set; }
        public Rectangle(int x,int y):this()
        {
            width = x;
            height = y;
        }
        public void Draw()
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }
        public override string ToString() => $"[Width={width}; Height={height}]";

        
    }
}