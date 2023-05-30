using System;

class program{

    static void Main(){

        double valor;
        
        Console.WriteLine("Digite um número:");
        valor = double.Parse(Console.ReadLine());

        if (valor % 2 == 0)
        {
             Console.WriteLine("este valor é par.");
        }else
        {
            Console.WriteLine("este valor é impar.");
        }

        
    }
}