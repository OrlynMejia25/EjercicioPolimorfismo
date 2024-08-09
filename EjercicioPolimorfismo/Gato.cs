using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Gato : Animal
    {
        public string Raza { get; set; }

        public Gato(string raza)
        {
            Raza = raza;
        }

        public override void Comunicar()
        {
            Console.WriteLine($"El gato de raza {Raza} maúlla: ¡Miau miau!");
        }
    }
}
