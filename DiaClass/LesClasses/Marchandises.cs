using System;
using System.Collections.Generic;
using System.Text;

namespace DiaClass.LesClasses
{
    class Marchandises
    {
        // private static int nbmarchandises  un attibut statique est un attribut qui appartient a une classe mais partager automatiquement a tous les instances du projet ce qui explique dans le construcrteur
        // on va enlever le numero  partout et : this.numero = ++nbmarchandises; Tout cela c'est si on veut incrementer les numeros
        private int numero;
        private double poids;
        private double volume;

        public Marchandises(int num, double pd, double vol)
        {
            this.numero = num;
            this.poids = pd;
            this.volume = vol;
        }

        public int Numero { get => numero; set => numero = value; }
        public double Poids { get => poids; set => poids = value; }
        public double Volume { get => volume; set => volume = value; }

        public override string ToString()
        {
            return "Numero = " + numero + " Poids = " + poids + " Volume =" + volume;

        }

    }

}
