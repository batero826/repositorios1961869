using System;

class Program
{
    static void Main(string[] args)
    {
        string respuesta= "";
        int valorProducto = 0;
        int totalProducto = 0;
        int totalCompra = 0;
        int numeroProducto = 0;
        int cantidad = 0;

        Console.WriteLine(" Desea Agregar productos al carrito Y/N ");
        respuesta = Console.ReadLine();

        while(respuesta == "Y")
        {
            numeroProducto++;
                              
            Console.WriteLine(" Ingrese el valor del producto N."+numeroProducto);
            valorProducto= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Ingrese la cantidad de Productos");
            cantidad = Convert.ToInt32(Console.ReadLine());

            totalProducto = valorProducto * cantidad;
            totalCompra += totalProducto;
              
            Console.WriteLine(" Desea seguir agregando productos al carrito Y/N ");
            respuesta = Console.ReadLine();
              
            
        }
        Console.WriteLine(" Valor de la Factura= " + totalCompra);
        Console.WriteLine(" fin de la factura ");
        Console.ReadLine();
    }
}

