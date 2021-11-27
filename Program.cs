using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraducirPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseas usar la calculadora?");
            string respuesta = Console.ReadLine();


            //Variables
            int num;
            double area, radio, b, h;

            while (respuesta != "no")
            {

                 //Entrada

                  Console.WriteLine("\n¿Qué area desea Calcular?");
                  Console.WriteLine("(1) Cirulo");
                  Console.WriteLine("(2) Rectangulo");
                  Console.WriteLine("(3) Triangulo");
                  Console.WriteLine("(4) Salir");

                  num = Convert.ToInt32(Console.ReadLine());

                    if (num == 4)
                    {
                        break;
                    }

                    if (num == 1)
                    {
                        //Pediendo datos
                        Console.Write("Ingrese el radio del circulo: ");
            
                        //Convierte de texto a tipo entero
                        radio = Int32.Parse(Console.ReadLine());

                        //Realiza la operacion
                        area = radio * radio * 3.1415;

                        //Imprimiendo el resultado
                        Console.WriteLine("El Area del Circulo: " + area);
                    }

                        

                    if (num == 2)
                    {
                        //Pidiendo datos
                        Console.Write("Ingrese la base del rectangulo: ");

                        //Convierte de texto a tipo entero
                        b = Int32.Parse(Console.ReadLine());

                        //Pediendo datos
                        Console.Write("Ingrese la altura del rectangulo: ");

                        //Convierte de texto a tipo entero
                        h = Int32.Parse(Console.ReadLine());

                        //Realiza la operacion
                        area = b * h;

                        //Imprimiendo el resultado
                        Console.WriteLine("El Area del Rectangulo: " + area);
                    }



                    if (num == 3)
                    {
                        //Pediendo datos
                        Console.Write("Ingrese la base del rectangulo: ");

                        //Convierte de texto a tipo entero
                        b = Int32.Parse(Console.ReadLine());

                        //Pediendo datos
                        Console.Write("Ingrese la altura del rectangulo: ");

                        //Convierte de texto a tipo entero
                        h = Int32.Parse(Console.ReadLine());

                        //Realiza la operacion
                        area = (b * h) / 2;

                        //Imprimiendo el resultado
                        Console.WriteLine("El Area del Triangulo: " + area);
                    }
                                             
                        
                        Console.WriteLine("Gracias por usar el programa de cálculo geométrico");
                    
                    Console.WriteLine("\nDeseas repetir otra vez?");
                    respuesta = Console.ReadLine();
            }
            Console.WriteLine("Has salido del bucle");
        }
    }
}
