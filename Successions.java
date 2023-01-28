package com.mycompany.successions;

import java.util.Scanner;

public class Successions {
    public static void main(String[] args) {
     
            int distance;
            int FirstNum;
            int FinalPos;
            int Variable;

        Scanner input=new Scanner(System.in);
        
        //Introducir la distancia entre los numeros de la sucesión
        System.out.print("Please introduce the distance between the numbers in the succession: ");
        distance=input.nextInt();
        
        //Introducir el número con el que comenzara la sucesión
        System.out.println("Introduce the first number of the succesion");
        FirstNum=input.nextInt();
        
        //Introducir la posición final en donde terminará la sucesión
        System.out.println("Introduce de final postion of the succesion");
        FinalPos=input.nextInt();
        
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
                    System.out.println("");
                    System.out.println(FirstNum);
                }
                else
                {
                    //Aquí se escribe la suceción
                    Variable = FirstNum + distance;
                   System.out.println(Variable);
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
            System.out.println("Suma de los "+an+" primeros términos = "+Addition);      
        
}
}
