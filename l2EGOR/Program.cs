using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Truncated_cone truncated_cone = new Truncated_cone();
            
            truncated_cone.SetR(4);
            truncated_cone.Setr(3);
            truncated_cone.Seth(8);

            Console.WriteLine(truncated_cone.GetR());

            Console.WriteLine(truncated_cone.Getr());

            Console.WriteLine(truncated_cone.Geth());

            

            Console.WriteLine(truncated_cone.GetSquare());
            Console.ReadKey();
        }
    }
}