using System;

namespace imc.App.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            // VARIABLES
            int peso;
            Double altura;
            Double imc;
            Double preimc;
            dynamic nombre;
 
 
            // BIENVENIDA
            Console.WriteLine("Calculador de IMC \n");
            Console.ReadKey();
            Console.Clear();
 
            // ALMACEN DE DATOS
            Console.WriteLine("¿Como te llamas?");
            nombre = Convert.ToString(Console.ReadLine());
            Console.Clear();
 
            Console.WriteLine("Hola " + nombre + ", Escriba su peso en kg:");
            peso = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
 
            Console.WriteLine("Ahora escriba su altura en metros \"Ejemplo: 1.65\":");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
 
            // FORMULA MATEMATICA
            preimc = Convert.ToDouble(altura * altura);
            imc = Convert.ToDouble(peso / preimc); // El resultado final
 
            Console.WriteLine(preimc);
            Console.WriteLine("Tu IMC es: " + imc);
            // INICIAN LAS CONDICIONES
            if (imc < 16) 
            {
                Console.WriteLine("Mala noticia " + nombre + "!, Padeces de delgadez severa\n");
                Console.WriteLine("Gracias por utilizar la calculadora de IMC");
                Console.WriteLine("CC\n");
                Console.WriteLine("Presiona cualquier letra para salir");
                Console.ReadKey();
            }
 
            else if (imc >= 16 && imc <= 16.99)
            {
                Console.WriteLine("Mala noticia " + nombre + "!, Padeces de delgadez moderada\n");
                Console.WriteLine("Gracias por utilizar la calculadora de IMC");
                Console.WriteLine("CC\n");
                Console.WriteLine("Presiona cualquier letra para salir");
                Console.ReadKey();
            }
 
            else if (imc >= 17 && imc <= 18.49) // y se sigue repitiendo el mismo else if pero con diferentes valores
            {
                Console.WriteLine(nombre + ", Padeces de delgadez aceptable\n");
                Console.WriteLine("Gracias por utilizar la calculadora de IMC");
                Console.WriteLine(" CC\n");
                Console.WriteLine("Presiona cualquier letra para salir");
                Console.ReadKey();
            }
 
            else if (imc >= 18.5 && imc <= 24.99)
            {
                Console.WriteLine("Buena noticia " + nombre + ", Mantienes un peso normal\n");
                Console.WriteLine("Gracias por utilizar la calculadora de IMC");
                Console.WriteLine("CC\n");
                Console.WriteLine("Presiona cualquier letra para salir");
                Console.ReadKey();
            }
 
            else if (imc >= 25 && imc <= 29.99)
            {
                Console.WriteLine(nombre + "!, Padeces de sobrepeso\n");
                Console.WriteLine("Gracias por utilizar la calculadora de IMC");
                Console.WriteLine("CC\n");
                Console.WriteLine("Presiona cualquier letra para salir");
                Console.ReadKey();
            }
 
            else if (imc >= 30 && imc <= 34.99)
            {
                Console.WriteLine("Mala Noticia" + nombre + "!, Tu peso esta en obesidad tipo I\n");
                Console.WriteLine("Gracias por utilizar la calculadora de IMC");
                Console.WriteLine("CC\n");
                Console.WriteLine("Presiona cualquier letra para salir");
                Console.ReadKey();
            }

            else if (imc >= 35 && imc <= 39.99)
            {
                Console.WriteLine("Mala Noticia" + nombre + "!, Tu peso esta en obesidad tipo II\n");
                Console.WriteLine("Gracias por utilizar la calculadora de IMC");
                Console.WriteLine("CC\n");
                Console.WriteLine("Presiona cualquier letra para salir");
                Console.ReadKey();
            }

            else if (imc >= 40 && imc <= 49.99)
            {
                Console.WriteLine("Mala Noticia" + nombre + "!, Tu peso esta en obesidad tipo III o morbida\n");
                Console.WriteLine("Gracias por utilizar la calculadora de IMC");
                Console.WriteLine("CC\n");
                Console.WriteLine("Presiona cualquier letra para salir");
                Console.ReadKey();
            }

            else if (imc >= 50)
            {
                Console.WriteLine("Mala Noticia" + nombre + "!, Tu peso esta en obesidad tipo IV o extrema\n");
                Console.WriteLine("Gracias por utilizar la calculadora de IMC");
                Console.WriteLine("CC\n");
                Console.WriteLine("Presiona cualquier letra para salir");
                Console.ReadKey();
            }
 
            else
            {
                Console.WriteLine("Algo salio mal, Por favor asegurate seguir las instrucciones o agrega valores logicos\n");
                Console.WriteLine("CC");
                Console.WriteLine("Presiona cualquier letra para salir");
                Console.ReadKey();
            }
        }
    }
}
