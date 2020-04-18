using System;

class Program
{
    static decimal PrecioProducto = 0;
    static decimal PrecioProductoconIva = 0;
    static int CategoriaProducto = 0;

  static void Main(string[] args)
{
            
    Console.WriteLine(" Por favor Ingrese el costo del Producto: ");
    decimal.TryParse(Console.ReadLine(), out PrecioProducto);
    Console.WriteLine(" Por favor Ingrese la categoria del Producto");
    Int32.TryParse(Console.ReadLine(), out CategoriaProducto);

    if (CategoriaProducto == 1)
    {
        PrecioProductoconIva = Porcentaje5();
        Console.WriteLine("El precio del producto con Iva es: {0:C}", PrecioProductoconIva);           
    }
      
    if (CategoriaProducto == 2)
    {
        PrecioProductoconIva = Porcentaje10();
        Console.WriteLine("El precio del producto con Iva es: {0:C}", PrecioProductoconIva);
    }
       
    if (CategoriaProducto == 3)
    {
        PrecioProductoconIva = Porcentaje19();
        Console.WriteLine("El precio del producto con Iva es: {0:C}", PrecioProductoconIva);
    }
    
    Console.ReadLine();
    }
    public static decimal Porcentaje5()
    {
        decimal aux = 0.05M;
        PrecioProducto += PrecioProducto * aux;
        return PrecioProducto;
    }
    public static decimal Porcentaje10()
    {
        decimal aux = 0.10M;
        PrecioProducto += PrecioProducto * aux;
        return PrecioProducto;
    }
    public static decimal Porcentaje19()
    {
        decimal aux = 0.19M;
        PrecioProducto += PrecioProducto * aux;
        return PrecioProducto;
    }
  
    }

