using System;

class Program
{
    static void Main(string[] args)
    {

        string Nombre = "";
        string Apellido = "";
        Console.WriteLine( " Por Favor Ingrese su Nombre: ");
        Nombre = Console.ReadLine();
        Console.WriteLine(" Por Favor Ingrese su Apellido: ");
        Apellido = Console.ReadLine();
        MostrarMensaje(Nombre,Apellido);
    }
    //Funcion con parametros sin Retorno
    public static void MostrarMensaje(string NombreUsuario, string ApellidoUsuario) 
    {
        Console.WriteLine("Bienvenido(a), Sr(a): "+NombreUsuario+" "+ApellidoUsuario);
        Console.ReadLine();
    }
}


