// See https://aka.ms/new-console-template for more information
using EjercicioAbstraccion;







Main_Class main_Class = new Main_Class();

int opc = 0;



Console.WriteLine("Ingrese [1] para Calcular Area, Ingrese [2] para Calcular Volumen Cubo, Ingrese [3] para Calcular Diferencia Cuadratica");
opc=int.Parse(Console.ReadLine());


switch(opc)
{

    case 1:

        Main_Class area = new Main_Class();
        main_Class.Area();


        break;




    case 2:

        Main_Class Volumen_Cubo = new Main_Class();
        main_Class.Volumen_Cubo();


        break;






    case 3:


        Main_Class Raiz_Suma = new Main_Class();    
        main_Class.Raiz_Suma();



        break;





    case 4:



        Main_Class Diferencia_Cuadratica = new Main_Class();
        main_Class.Diferencia_Cuadratica();


        break;





    default:
        Console.WriteLine("Opcion no valida, ingrese valor correcto");
        break;

}
























