using System;
using System.Collections.Generic;
using System.Text;

namespace DiaClass.LesClasses
{
    abstract class Cargaisons
    {
        protected int distance;
        protected List<Marchandises> pmarchandise = new List<Marchandises>();//initialiser

        public Cargaisons(int d) // pour creer un cargaison on doit voir un constructeur  et qui reçoit en paramete la distance

        {
            this.distance = d;

        }
        // CREATION DES METHODES POUR LA GESTIONS DES MARCHANDISES

        public void Add(Marchandises m)
        {
            pmarchandise.Add(m);

        }

        public void Afficher()
        {
            foreach (Marchandises m in pmarchandise)
            {
                Console.WriteLine(m.ToString());

            }


        }
        public Marchandises ConsulterMarchandises(int num)
        {
            foreach (Marchandises m in pmarchandise)
            {
                if (m.Numero == num) return m;
            }
            throw new Exception("marchandise introuvable");

        }
        public double getVolumeTotal()

        {

            double somme = 0;
            foreach (Marchandises m in pmarchandise)
            {
                somme += m.Volume;

            }
            return somme;

        }

        public double getPoidsTotal()

        {

            double somme = 0;
            foreach (Marchandises m in pmarchandise)
            {
                somme += m.Poids;

            }
            return somme;
           
        }
        public List<Marchandises> GetMarchandises()
        {
            return pmarchandise;

        }


        //UNE METHODE ABSTRAITE EST UNE METHODE QUI N'A PAS DE DEFINITION ET QUI TERMINE PAR UN POINT VIRGULE ET C'EST UNE METODE QU'ON DEVAIT REDEFINIR  DANS LES CLASSES DERIVES
        // ET ELLE PWEUT DEFINIR A L'INTERIEUR D'UNE CLASSE ABSTRAITE
        public abstract double Cout();

        

        
        

    }
}
