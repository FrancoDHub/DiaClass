using System;
using System.Collections.Generic;
using System.Text;

namespace DiaClass.LesClasses
{
    class CargaisonAerienne:Cargaisons
    {

        public CargaisonAerienne(int d) : base(d)
        {
        }

        public override double Cout()

        {
            if (getVolumeTotal() < 8000)
            {
                return 10 * distance * getPoidsTotal();

            }
            else
            {
                return 12 * distance * getPoidsTotal();
            }
        }
        public override string ToString()
        {
            return " Cargaison Aerienne Distance = " + distance;
        }
    }
}
