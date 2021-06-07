using System;
using System.Collections.Generic;
using System.Text;

namespace DiaClass.LesClasses
{
    class CargaisonRoutiere : Cargaisons
    {
        public CargaisonRoutiere(int d) : base(d)
        {
        }

        public override double Cout()

        {
            if (getVolumeTotal() < 38000)
            {
                return 4 * distance * getPoidsTotal();

            }
            else
            {
                return 6 * distance * getPoidsTotal();
            }
        }
        public override string ToString()
        {
            return " Cargaison routiere Distance = " + distance;
        }
    }

}
