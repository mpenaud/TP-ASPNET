using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    public class Cercle : Forme
    {
        public int Rayon { get; set; }

        public double Aire { get => 3.14 * (Rayon *Rayon); }
        public double Perimetre { get => Rayon * 2 * 3.14; }




        public Cercle()
        {
        }
        public Cercle(int rayon)
        {
            Rayon = rayon;
        }

        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();
            stb.AppendLine("Cercle de rayon  : " + this.Rayon);
            stb.AppendLine("Aire = " + this.Aire );
            stb.AppendLine("Pèrimetre = " + this.Perimetre);
            return stb.ToString();
        } 
    }
}
