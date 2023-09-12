using Entidades;
namespace Sobrecarga_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador1 = new Sumador();
            string resultadoCadena=sumador1.Sumar("hola","mondo");
            Console.WriteLine($"Resultado {resultadoCadena}");
            int conversionExplicitaCantSumas = (int)sumador1;
            Console.WriteLine($"cant sumas: {conversionExplicitaCantSumas}");


        }
    }
}