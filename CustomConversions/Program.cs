using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomConversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(15,10);
            Console.WriteLine(rect.ToString());
            rect.Draw();
            Console.WriteLine();
            Squere squere = (Squere)rect;
            
            Squere sq=(Squere)51;
            Console.WriteLine($"Sq={sq}");
            int a = (int)sq;
            Console.WriteLine(a);
            //DrawSquere(squere);
        }
        static void DrawSquere(Squere sq)
        {
            Console.WriteLine(sq.ToString());
            sq.Draw();
            Console.WriteLine();
        }
    }
}
