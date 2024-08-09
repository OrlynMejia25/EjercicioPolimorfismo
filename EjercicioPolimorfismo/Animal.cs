

namespace EjercicioPolimorfismo
{
    public class Animal
    {
        public virtual void Comunicar()
        {
            Console.WriteLine("El animal emite un sonido.");
        }

        // Sobrecarga de métodos
        public void Comer()
        {
            Console.WriteLine("El animal está comiendo.");
        }

        public void Comer(string comida)
        {
            Console.WriteLine($"El animal está comiendo {comida}.");
        }
    }
}
