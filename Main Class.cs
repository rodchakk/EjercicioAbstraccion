

namespace EjercicioAbstraccion
{




 public class Main_Class:Matematicas



    {
        int a, b, resultado;



        public override void Captura()
        {
            Console.WriteLine("Ingrese Primer numero: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Segundo numero: ");
            b=int.Parse(Console.ReadLine());




        }











        //area de rectangulo, base x altura
        public override void Area()
        {

            Captura();

            resultado = a * b;


            Imprimir();



        }






















        public override void Imprimir()
        {
            Console.WriteLine($"El resultado es: {resultado}");

        }





    }


    







    
}
