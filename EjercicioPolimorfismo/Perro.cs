using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Perro : Animal
    {
        public string Raza { get; set; }

        public Perro(string raza)
        {
            Raza = raza;
        }

        public override void Comunicar()
        {
            Console.WriteLine($"El perro de raza {Raza} ladra: ¡Guau guau!");
        }
    }
}
