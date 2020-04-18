using System;

class Program
{
    static void Main(string[] args)
    {
        int NumeroNotas = 0;
        Console.WriteLine("===NOTAS===");
        Console.Write(" Ingrese el Numero de Notas: ");
        Int32.TryParse(Console.ReadLine(), out NumeroNotas);
        string Resultado = CalcularNotas(NumeroNotas);
            
    }

     public static string CalcularNotas(int NumeroNotas)
     {
        decimal Nota = 0;
        decimal SumaNotas = 0;
     for(int i=1; i <= NumeroNotas;i++)
     {
            Console.WriteLine(" Ingrese La Nota N."+i);
            decimal.TryParse(Console.ReadLine(), out Nota);
            SumaNotas += Nota/NumeroNotas;
     }
    Console.WriteLine(" El promedio es= {0:F2}", SumaNotas);

        if(SumaNotas>6){
            Console.WriteLine(" Aprovado!!!");             
        }
        else
            {
                Console.WriteLine(" Reprovado");               
            }
        Console.ReadLine();
        return "";      
    }      
}

