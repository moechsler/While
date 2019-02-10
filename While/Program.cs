using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("elige el metodo a utilizar ximena / david");
            string metodos = Console.ReadLine();


            switch (metodos)
            {

                case "ximena":
                    Console.WriteLine("ximena");
                    metodowhile();
                    break;

                case "david":
                    Console.WriteLine("metodo 2");                
                    Metodowhile2();
                    break;

                default:
                    Console.WriteLine("metodo no contemplado");
                    break;

            }
            

            }

        static void metodowhile()
        {

            Console.WriteLine("Deseas entrar en el bucle ximena");

            string respuesta = Console.ReadLine();

            while (respuesta != "no")
            {

                Console.WriteLine("Estas ejecutando dentro del bucle ximena");

                Console.WriteLine("introduce tu nombre por favor");
                string nombre = Console.ReadLine();

                Console.WriteLine($"saldras del bucle while {nombre} cuando respondas 'no' a la pregunta");

                Console.WriteLine("deseas repetir otra vez?");

                respuesta = Console.ReadLine();


            }

            Console.WriteLine("has salido del bucle ximena");
            Console.ReadKey();

        }
        static void Metodowhile2()
        {
            Console.WriteLine("Deseas entrar en el bucle david?");

            string respuesta2 = Console.ReadLine();
            while (respuesta2 != "no")
            {

                Console.WriteLine("Estas ejecutando dentro del david");

                Console.WriteLine("introduce tu edad por favor");
                string nombre2 = Console.ReadLine();

                Console.WriteLine($"saldras del bucle while {nombre2} cuando respondas 'no' a la pregunta");

                Console.WriteLine("deseas repetir otra vez?");

                respuesta2 = Console.ReadLine();


            }

            Console.WriteLine("has salido del bucle david");
            Console.ReadKey();


        }

    }
}
