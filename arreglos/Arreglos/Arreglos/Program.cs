using System;

class Program
{
    static void Main(string[] args)
    {
          
        string [] Aprendices = new string[3];  ;

        for (int apr = 0; apr <= 2; apr++)
        {
            Console.Write(" Por favor ingrese el nombre del Aprendiz Nro " + (apr + 1) + ". ");
            Aprendices[apr] = Console.ReadLine();
              
        }

        for (int apr = 0; apr <= 2; apr++)
        {
            Console.WriteLine((apr + 1) + " . " + Aprendices[apr]);
               
             
        }

        Console.ReadLine();
    }
}