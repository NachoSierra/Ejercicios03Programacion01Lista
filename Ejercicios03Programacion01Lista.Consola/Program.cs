using System;
using System.Collections.Generic;

namespace Ejercicios03Programacion01Lista.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            double mayorAltura = double.MinValue;
            double menorAltura = double.MaxValue;
            double promedioAltura = 0;
            List<double> listaAlturas = new List<double>();
            for (int i = 0; i < 7; i++)
            {
                bool esError = true;
                double altura;
                do
                {
                    Console.Write($"Ingrese la {i + 1}° altura:");
                    if (double.TryParse(Console.ReadLine(), out altura))
                    {
                        if (altura >= 120 && altura <= 230)
                        {
                            Console.WriteLine($"La altura es {altura}cm");
                            listaAlturas.Add(altura);
                            esError = false;
                        }
                        else
                        {
                            Console.WriteLine("Altura fuera del rango");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Valor mal ingresado,intente devuelta");
                    }
                } while (esError);
                if (altura > mayorAltura)
                {
                    mayorAltura = altura;
                }
                if (altura < menorAltura)
                {
                    menorAltura = altura;
                }
                promedioAltura += altura;
            }
            promedioAltura = promedioAltura / 7;
            foreach (var altura in listaAlturas)
            {
                if (altura < promedioAltura)
                {
                    Console.WriteLine($"{altura}*");
                }
                else
                {
                    Console.WriteLine($"{altura}");
                }
            }
            Console.WriteLine($"La mayor altura es {mayorAltura}cm");
            Console.WriteLine($"La menor altura es {menorAltura}cm");
            Console.WriteLine($"El promedio de altura es {promedioAltura}");
            Console.ReadLine();
        }
    }
    
}
