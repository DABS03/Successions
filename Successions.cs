using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucesiones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///SUCESIONES
          
            int distance;
            int FirstNum;
            int FinalPos;
            int Variable;

            Console.WriteLine("Succesions");
            Console.WriteLine("");
            //Introducir la distancia entre los numeros de la sucesión
            Console.WriteLine("Please introduce the distance between the numbers in the succession");
            distance = Convert.ToInt32(Console.ReadLine());
            //Introducir el número con el que comenzara la sucesión
            Console.WriteLine("Introduce the first number of the succesion");
            FirstNum = Convert.ToInt32(Console.ReadLine());
            //Introducir la posición final en donde terminará la sucesión
            Console.WriteLine("Introduce de final postion of the succesion");
            FinalPos = Convert.ToInt32(Console.ReadLine());

            //Estas variables toman el valor de las anteriores variables, porque con el for se modificaran, y asi guardamos su valor inicial para despues
            int d = distance;
            int a1 = FirstNum;
            int an = FinalPos;

            //For terminará cuando -i- sea igual a la posición final
            for (int i = 1; i <= FinalPos; i++)
            {
                //Solo es para escribir el número desde donde comenzara la sucesión
                if (i == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine(FirstNum);
                }
                else
                {
                    //Aquí se escribe la suceción
                    Variable = FirstNum + distance;
                    Console.WriteLine(Variable);
                    FirstNum = Variable;
                }
            }
            ///SUMA DE -N- TERMINOS

            //Aqui se encuentra si el numero se sumara o restara
            int x =a1-d;

            int Addition;
            //a1 = posición inicial
            //d=distancia entre numero
            //an=posicion final  

            Addition =((a1 + ((d * an) + x)) * an) / 2;
            Console.WriteLine("Suma de los "+an+" primeros términos = "+Addition);


            Console.ReadLine();
        }
    }
}
