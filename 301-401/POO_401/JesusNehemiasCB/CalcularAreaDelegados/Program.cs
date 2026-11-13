using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularAreaDelegados
{
    class Program
    {
        // Definición del delegado para operaciones que reciben dos parámetros double
        public delegate double OperacionDelegate(double x, double y);
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para calcular el área y perímetro de figuras geométricas");
            Console.WriteLine("Seleccione la figura geométrica:");
            Console.WriteLine("1. Rectángulo");
            Console.WriteLine("2. Círculo");
            Console.WriteLine("3. Cuadrado");
            Console.Write("Opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    CalcularRectangulo();
                    break;
                case "2":
                    CalcularCirculo();
                    break;
                case "3":
                    CalcularCuadrado();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        // Método para calcular el área y perímetro de un rectángulo
        static void CalcularRectangulo()
        {
            // Asignamos las funciones de cálculo a los delegados
            OperacionDelegate calcularArea = AreaRectangulo;
            OperacionDelegate calcularPerimetro = PerimetroRectangulo;

                Console.WriteLine("Ingrese la base del rectángulo: ");
                double baseRect = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la altura del rectángulo: ");
                double alturaRect = double.Parse(Console.ReadLine());

                double area = calcularArea(baseRect, alturaRect);
                double perimetro = calcularPerimetro(baseRect, alturaRect);

                Console.WriteLine("Área del rectángulo: " + area);
                Console.WriteLine("Perímetro del rectángulo: " + perimetro);
        }

        // Método para calcular el área y la circunferencia de un círculo
        static void CalcularCirculo()
        {
            // En el caso del círculo usamos el primer parámetro como radio; el segundo se ignora.
            OperacionDelegate calcularArea = AreaCirculo;
            OperacionDelegate calcularPerimetro = PerimetroCirculo;

                Console.Write("Ingrese el radio del círculo: ");
                double radio = double.Parse(Console.ReadLine());

                double area = calcularArea(radio, 0);       // El segundo parámetro no se utiliza
                double circunferencia = calcularPerimetro(radio, 0);

                Console.WriteLine("Área del círculo: " + area);
                Console.WriteLine("Circunferencia del círculo: " + circunferencia);
        }
        static void CalcularCuadrado()
        {
            // Asignamos las funciones correspondientes a los delegados
            OperacionDelegate calcularArea = AreaCuadrado;
            OperacionDelegate calcularPerimetro = PerimetroCuadrado;

            Console.WriteLine("Ingrese el valor del lado del cuadrado: ");
            double lado = Convert.ToDouble(Console.ReadLine());

            // En este caso, el segundo parámetro del delegado no se utiliza; se le pasa 0.
            double area = calcularArea(lado, 0);
            double perimetro = calcularPerimetro(lado, 0);

            Console.WriteLine("Área del cuadrado: " + area);
            Console.WriteLine("Perímetro del cuadrado: " + perimetro);
        }
        // Función para calcular el área de un rectángulo
        static double AreaRectangulo(double baseRect, double alturaRect)
        {
            return baseRect * alturaRect;
        }

        // Función para calcular el perímetro de un rectángulo
        static double PerimetroRectangulo(double baseRect, double alturaRect)
        {
            return 2 * (baseRect + alturaRect);
        }

        // Función para calcular el área de un círculo
        static double AreaCirculo(double radio, double nd)
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        // Función para calcular la circunferencia de un círculo
        static double PerimetroCirculo(double radio, double nd)
        {
            return 2 * Math.PI * radio;
        }
        static double AreaCuadrado(double lado, double dummy)
        {
            return lado * lado;
        }

        // Función que calcula el perímetro del cuadrado: perímetro = 4 * lado
        static double PerimetroCuadrado(double lado, double dummy)
        {
            return 4 * lado;
        }

    }

}
