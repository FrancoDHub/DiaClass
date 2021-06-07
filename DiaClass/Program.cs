using System;
using DiaClass.LesClasses;

namespace DiaClass
{
    class Program  // 
    {
        static void Main(string[] args)
        {
            Cargaisons c1 = new CargaisonRoutiere(80); // on ne peut pas instancier une classe abstraite comme Cargaisons alors une classe derive cargaisonRoutiere avec une distance 80
            // ajout des marchandises
            c1.Add(new Marchandises(1, 60, 70)); // 1 le numero,60 le ppids,70 le volume
            c1.Add(new Marchandises(2, 90, 50));
            c1.Add(new Marchandises(3, 99,60));

            c1.Afficher();
            Console.WriteLine("cout de la " + c1.ToString() + " est :  " + c1.Cout()); // il appelle la methode Cout de la cargaisonRoutiere selon le polymorphisme " la liason tardive "

            Console.WriteLine("--------------------------------------------------------------------------------");

            Cargaisons c2 = new CargaisonAerienne(100); // on ne peut pas instancier une classe abstraite comme Cargaisons alors une classe derive cargaisonRoutiere avec une distance 80
            // ajout des marchandises
            c2.Add(new Marchandises(4, 50, 40)); // 1 le numero,60 le ppids,70 le volume
            c2.Add(new Marchandises(5, 80, 90));
            c2.Add(new Marchandises(6, 100, 20));

            c2.Afficher();
            Console.WriteLine("cout de la " + c2.ToString() + " est :  " + c2.Cout());

            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("------ Consulter la marchandise num 2");
            Marchandises m = c1.ConsulterMarchandises(2);
            Console.WriteLine(m);
                 

            Console.ReadLine();

        }
    }
}
