using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIMER_PROYECTO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables
            int numero1, numero2, suma;
            // Solicitar al usuario que ingrese dos números
            Console.WriteLine("Ingrese el primer número:");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            numero2 = Convert.ToInt32(Console.ReadLine());
            // Calcular la suma
            suma = numero1 + numero2;
            // Mostrar el resultado
            Console.WriteLine($"La suma de {numero1} y {numero2} es: {suma}");
            // Esperar a que el usuario presione una tecla antes de cerrar
            Console.ReadKey();
        }
    }
}
