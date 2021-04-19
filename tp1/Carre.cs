using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    public class Carre : Forme
    {
        public int Longueur { get; set; }

        public double Aire { get => Longueur * Longueur; }
        public double Perimetre { get => Longueur * 4; }


        public Carre()
        {
        }
        public Carre(int longueur)
        {
            Longueur = longueur;
        }

        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();
            stb.AppendLine("Carré de côté " + this.Longueur);
            stb.AppendLine("Aire = " + this.Aire);
            stb.AppendLine("Pèrimetre = " + this.Perimetre);
            return stb.ToString();
        }
    }
}