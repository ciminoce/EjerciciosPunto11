using System;

namespace Ejercicios05Punto11
{
    class Program
    {
        static void Main(string[] args)
        {
            var sumaPares = 0;
            var contadorImpares = 0;
            Console.Write("Ingrese el número inicial:");
            var nroN = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el número final:");
            var nroM = int.Parse(Console.ReadLine());
            for (int nroGenerado = nroN; nroGenerado <= nroM; nroGenerado++)
            {
                Console.WriteLine($"{nroGenerado}");
                //Se pregunta si el nro que contiene la variable i es par
                if (nroGenerado%2==0)
                {
                    sumaPares += nroGenerado;
                }
                else
                {
                    contadorImpares++;
                }
            }
            Console.WriteLine($"La cantidad de nros impares es {contadorImpares}");
            Console.WriteLine($"La suma de los nros pares es {sumaPares}");

        }
    }
}
