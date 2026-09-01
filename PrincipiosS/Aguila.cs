using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosS
{
    public class Aguila : Ave, IVuela
    {
        public override void Comer() => Console.WriteLine("El águila está comiendo un conejo.");
        public void Volar() => Console.WriteLine("El águila está volando alto.");
    }
}
