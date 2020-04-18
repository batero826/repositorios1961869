using System;

class Program
{
static void Main(string[] args)
{
    string NombreUsuario="";
    Console.Write(" Por favor Ingrese su Nombre ");
    NombreUsuario = Console.ReadLine();

    //Estructura Repetitiva while para preguntar el nombre
    while(NombreUsuario!= "FIN")
    {
      
    Console.WriteLine(" Bienvenido(a),Sr(a) "+NombreUsuario+".");
    Console.WriteLine("");
    Console.Write(" Por favor Ingrese su Nombre ");
    NombreUsuario = Console.ReadLine();
   
    }
    Console.WriteLine(" Fin del Programa ");
    
}
     
}

