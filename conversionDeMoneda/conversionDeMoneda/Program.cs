// Aplicación para convertir pesos colombianos (COP) a USD y EUR

using System;

namespace conversionDeMoneda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definimos las variables 
            const double monedaUsd = 4000;
            const double monedaEur = 4500;
            bool continuar = true;

            Console.WriteLine("Conversión de Moneda de Pesos Colombianos (COP) a USD y EUR");

            while (continuar)
            {
                double monto = 0;

                // Validación de entrada
                while (true)
                {
                    //Le pedimos al usuario que ingrese el monto que desea convertir
                    Console.Write("Ingrese el monto en pesos colombianos (COP) que desea convertir: ");

                    //Usamos double.TryParse este método permite verificar
                    //si la entrada del usuario es un número válido
                    if (double.TryParse(Console.ReadLine(), out monto) && monto > 0)
                    {
                        break; // Si la enntrada es válida, salimos del bucle
                    }
                    else
                    {   
                        //Mensaje de error por si el usuario ingresa un valor invalido
                        Console.WriteLine("Error: Ingrese un número válido mayor a 0.");
                    }
                }

                // Realizamos las conversiones
                //Usamos Math.Round para redondear el valor a solo 2 decimales
                double valorEnUsd = Math.Round(monto / monedaUsd, 2);
                double valorEnEur = Math.Round(monto / monedaEur, 2);

                // Mostramos los resultados
                Console.WriteLine("\nResultados de la Conversión:");
                Console.WriteLine($"El valor en USD es: " + valorEnUsd);
                Console.WriteLine($"El valor en EUR es: " + valorEnEur);

                // Preguntamos si el usuario desea continuar
                Console.Write("\n¿Deseas convertir otro monto? (S/N): ");
                //Capturamos la respuesta y usamos el .ToUpper para convertir una cadena a mayusculas
                string respuesta = Console.ReadLine().ToUpper();

                //Validamos si el usuario quiere continuar, en caso de ser N
                // o diferente de N cerramos el bucle While
                if (respuesta != "S")
                {
                    continuar = false;
                    Console.WriteLine("Gracias por usar el programa. ¡Hasta luego!");
                }
            }
        }
    }
}