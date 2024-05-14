using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("..........-CALCULADORAS- -•*.•.......");

            Console.WriteLine("Elija modo de operación:");
            Console.WriteLine("\n1 - Números enteros\n\n2 - Números decimales");
            int modoNumeros = Convert.ToInt32(Console.ReadLine());

            while (modoNumeros != 1 && modoNumeros != 2)
            {
                Console.WriteLine("Opción inválida. Elija 1 para números enteros o 2 para decimales.");
                modoNumeros = Convert.ToInt32(Console.ReadLine());
            }
            object a;
            object b;
            if(modoNumeros ==1)
            {
                Console.WriteLine("Introduzca el primer número:");
                //string inputA = Console.ReadLine();
                //double a = tryParseDouble(inputA);
                 a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduzca el segundo número:");
                //string inputB = Console.ReadLine();
                //double b = tryParseDouble(inputB);
                 b = Convert.ToInt32(Console.ReadLine());

            }
            else
            {
                Console.WriteLine("Introduzca el primer número:");
                //string inputA = Console.ReadLine();
                //double a = tryParseDouble(inputA);
                 a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Introduzca el segundo número:");
                //string inputB = Console.ReadLine();
                //double b = tryParseDouble(inputB);
                 b = Convert.ToDouble(Console.ReadLine());


            }
            

            Console.WriteLine("Elija una opción:");
            Console.WriteLine("\n1 - Sumar\n\n2- RestarIn\n\n3-Multiplicar\n\n4Dividir");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    if (modoNumeros == 1)
                    {
                        Console.WriteLine(suma_int((int)a, (int)b));
                    }
                    else
                    {
                        Console.WriteLine(suma((double)a, (double)b));
                    }
                    
                    break;
                case 2:
                    if (modoNumeros == 1)
                    {
                        Console.WriteLine(suma_int((int)a, (int)b));
                    }
                    else
                    {
                        Console.WriteLine(resta((double)a, (double)b));
                    }
                    break;
                case 3:
                    if (modoNumeros == 1)
                    {
                        Console.WriteLine(suma_int((int)a, (int)b));
                    }
                    else
                    {
                        Console.WriteLine(multiplicacion((double)a, (double)b));
                    }
                    break;
                case 4:
                    if (modoNumeros == 1)
                    {
                        Console.WriteLine(suma_int((int)a, (int)b));
                    }
                    else
                    {
                        Console.WriteLine(division((double)a, (double)b));
                    }
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }

        private static int suma_int(int a, int b)
        {
            return a + b;
        }

        private static double tryParseDouble(string input)
        {
            double result;
            if (double.TryParse(input, out result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Entrada no válida. Se utilizará el valor 0.");
                return 0; 
            }
        }

        private static double suma(double a, double b)
        {
            return a + b;
        }

        private static double resta(double a, double b)
        {
            return a - b;
        }

        private static double multiplicacion(double a, double b)
        {
            return a * b;
        }

        private static double division(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: División por cero.");
                return 0; 
            }
            else
            {
                return a / b;
            }
        }
    }
}





