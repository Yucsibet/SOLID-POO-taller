using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosS
{
    public class Paloma : Ave,IVuela
    {
        public override void Comer() => Console.WriteLine("La paloma está comiendo migas.");
        public void Volar() => Console.WriteLine("La paloma está volando bajo.");
    }
}
