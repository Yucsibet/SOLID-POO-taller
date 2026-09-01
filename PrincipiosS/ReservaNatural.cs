using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosS
{
    public class ReservaNatural
    {
        private readonly Ave nuevaAve;

        // Inyección de dependencia a través de abstracción (Ave)
        public ReservaNatural(Ave nuevaAve1)
        {
            nuevaAve = nuevaAve1;
        }

        public void AlimentarAve()
        {
            Console.Write("Alimentado en la reserva:");
            nuevaAve.Comer();
        }
    }
}
