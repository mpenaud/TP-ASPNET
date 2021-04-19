using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    public class Rectangle : Forme
    {
        public int Largeur { get; set; }
        public int Longueur { get; set; }

        public double Aire { get => Longueur * Largeur; }
        public double Perimetre { get => (Longueur + Largeur) *2; }




        public Rectangle()
        {
        }
        public Rectangle(int largeur, int longueur)
        {
            Largeur = largeur;
            Longueur = longueur;
        }

        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();
            stb.AppendLine("Rectangle de longueur=" + this.Longueur + "et largeur="  + this.Largeur);
            stb.AppendLine("Aire = " + this.Aire);
            stb.AppendLine("Pèrimetre = " + this.Perimetre);
            return stb.ToString();
        }
    }
}