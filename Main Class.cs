

using System;
using System.Security.Cryptography.X509Certificates;


namespace EjercicioAbstraccion
{




 public class Main_Class:Matematicas



    {
        double a, b, resultado;


        //definiendo metodo captura
        public override void Captura()
        {
            Console.WriteLine("Ingrese Primer numero: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Segundo numero: ");
            b=int.Parse(Console.ReadLine());

        }



        //definiendo metodo imprimir
        public override void Imprimir()
        {
            Console.WriteLine($"El resultado es: {resultado}");

        }




        //definiendo metodo Area
        public override void Area()
        {

            Captura();

            resultado = a * b;


            Imprimir();

        }

        //definiendo metodo Volumen_Cubo
        public override void Volumen_Cubo()
        {

            Console.WriteLine("Ingrese el tamaño de uno de los lados del cubo en cm: ");
            a = int.Parse(Console.ReadLine());


            resultado = Math.Pow(a, 3);


            Imprimir();


            

        }






    }











}
