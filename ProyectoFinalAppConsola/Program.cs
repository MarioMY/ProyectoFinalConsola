using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAppConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            int V1, V2, operacion1, x1, x2, y1, y2, operacion2;
            
            
            Console.WriteLine("Distancia Entre 2 Puntos de una Recta");
            Console.WriteLine(" Primer Punto = ");
            V1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Segundo Punto = ");
            V2 = int.Parse(Console.ReadLine());
            operacion1 = Math.Abs(V1 - V2);
            Console.WriteLine("Resultado = " + operacion1);
            Console.ReadKey();
            Console.WriteLine("Distancia Entre 2 Puntos en el Plano Cartesiano");
            Console.WriteLine(" X1 = ");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Y1 = ");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" X2 = ");
            x2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Y2 = ");
            y2 = int.Parse(Console.ReadLine());
            operacion2 = (int)Math.Sqrt(Math.Pow(double.Parse(x1 + "") - double.Parse(x2 + ""), 2) + Math.Pow(double.Parse(y1 + "") - double.Parse(y2 + ""), 2));
            Console.WriteLine("Resultado = " + operacion2);
            Console.ReadKey();
        }
    }
}
