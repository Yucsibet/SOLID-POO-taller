
using System;

namespace PrincipiosS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PRINCIPIOS SOLID(LSP, ISP, DIP) ===\n");

           
            Ave pinguino = new Pinguino();
            Aguila aguila = new Aguila();
            Paloma paloma = new Paloma();

            // 1. LSP (Liskov Substitution Principle)
            
            Console.WriteLine("---  LSP (Sustitución de Liskov) ---");
            pinguino.Comer();

            // 2. ISP (Interface Segregation Principle)
         
            Console.WriteLine("\n---  ISP (Segregación de Interfaces) ---");
            aguila.Volar();
            paloma.Volar();

            // 3. DIP (Inversión de Dependencias)
            // La ReservaNatural puede resivir cualquier ave porque depende de la abstracción Ave
            Console.WriteLine("\n--- DIP (Inversión de Dependencias) ---");

            ReservaNatural reserva1 = new ReservaNatural(pinguino);
            reserva1.AlimentarAve();

            ReservaNatural reserva2 = new ReservaNatural(aguila);
            reserva2.AlimentarAve();

            ReservaNatural reserva3 = new ReservaNatural(paloma);
            reserva3.AlimentarAve();

           
            
        }
    }
}