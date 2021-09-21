using System;

namespace IT_pro_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //sequence goes inside here
            Console.WriteLine("Para iniciar la secuencia del programa, escriba: start");
            Console.WriteLine();
            string key = Console.ReadLine();
            if (key == "start") {
                //the method goes inside here. That method prints out the array.
                //scratching the array, gonna go with nested methods.
                utilz.one();
            }
            Console.WriteLine();
            Console.WriteLine("end");

        }
    }
    //external class for anything that doesn't need to be in the main sequence(under class Program)
    public class utilz{ 
    //contents of the class are going to include the array, and the method that prints it out.
    //nested methods are below.
    public static void one()
        {
            void two(){

                Console.WriteLine("1. ");
                Console.WriteLine("");
                Console.WriteLine("•Reunir y analizar los requisitos del programa.");
                Console.WriteLine("_Tipos de documentacion:");
                Console.WriteLine("   Requirements doc. & Use case def.");
                Console.WriteLine("");
                Console.WriteLine("2. ");
                Console.WriteLine("");
                Console.WriteLine("•Diseñar la interfaz de usuario.");
                Console.WriteLine("");
                Console.WriteLine("3. ");
                Console.WriteLine("");
                Console.WriteLine("•Diseñar los objetos de precesamiento del programa.");
                Console.WriteLine("");
                Console.WriteLine("4. ");
                Console.WriteLine("");
                Console.WriteLine("•Codificar el programa.");
                Console.WriteLine("");
                Console.WriteLine("5. ");
                Console.WriteLine("");
                Console.WriteLine("•Probar el programa.");
                Console.WriteLine("");
                Console.WriteLine("6. ");
                Console.WriteLine("");
                Console.WriteLine("•Documentar el programa o sistema.");
                Console.WriteLine("");
                Console.WriteLine("7. ");
                Console.WriteLine("");
                Console.WriteLine("Mantener el programa o sistema.");
                }
            two();
        }
    }
}
