using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Truncated_cone
    {
        public
            double R, r, h;

        public Truncated_cone()
        {
            Console.WriteLine($"Triangle was successfully created");
        }
        ~Truncated_cone()
        {
            Console.WriteLine($"Triangle was successfully destroyed");
        }

        public void SetR(double value) { R = value; }
        public double GetR() { return R; }

        public void Setr(double value) { r = value; }
        public double Getr() { return r; }

        public void Seth(double value) { h = value; }
        public double Geth() { return h; }

        public double GetSquare()
        {
            return 1.0 / 3 * Math.PI * h * (Math.Pow(R, 2) + R * r + Math.Pow(r, 2));
        }

    }
}