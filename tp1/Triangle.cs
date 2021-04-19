using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    public class Triangle : Forme
    {
        public int A { get; set; }
        public int B { get; set; }

        public int C { get; set; }

        public double Aire { get => (A * C) /2; }
        public double Perimetre { get => A + B + C ; }


        public Triangle()
        {
        }
        public Triangle(int a, int b, int C)
        {
            A = a;
            B = b;
            C = C;
        }

        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();
            stb.AppendLine("Triangle de côté A=" + this.A + ", B=" + this.B + ", C= " + this.C);
            stb.AppendLine("Aire = " + this.Aire);
            stb.AppendLine("Pèrimetre = " + this.Perimetre);
            return stb.ToString();
        }
    }
}
