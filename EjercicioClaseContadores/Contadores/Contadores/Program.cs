using System;


class Program
{
static void Main(string[] args)
{
    string NombreProducto= "";
    int NumeroProducto = 1;
    Console.Write(" Escriba el nombre del Producto: ");
    NombreProducto = Console.ReadLine();

while(NombreProducto!= "FIN")
{
    Console.WriteLine(" Producto N: " + NumeroProducto);
    Console.WriteLine(" El nombre del Producto es " + NombreProducto + ".");
    Console.WriteLine("");
    Console.Write("Escriba el nombre del Producto ");
    NombreProducto = Console.ReadLine();
    NumeroProducto += 1;
}
    Console.WriteLine("fin del programa");
    Console.ReadLine();
  
}
}

