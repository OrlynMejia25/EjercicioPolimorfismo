

namespace EjercicioPolimorfismo
{
    public  class Pajaro : Animal
    {
        public string Tipo { get; set; }

        public Pajaro(string tipo)
        {
            Tipo = tipo;
        }

        public override void Comunicar()
        {
            Console.WriteLine($"El {Tipo} canta: ¡Pío pío! o ¡kirikikiii!");
        }
    }
}
