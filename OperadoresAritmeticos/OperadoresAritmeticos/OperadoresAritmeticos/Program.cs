using System;

    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int resultado = 0;
            int opc = 0;
            int opUsuario = 0;
            string [] operaciones = new string[5];
        operaciones[0] = "Suma";
        operaciones[1] = "Resta";
        operaciones[2] = "Multiplicacion";
        operaciones[3] = "Division";
        operaciones[4] = "ERROR";
        string respuesta = "";
        Console.WriteLine(" Desea hacer una Operacion Y/N ");
        respuesta = Console.ReadLine();

        while (respuesta == "Y")
        {
            for (opc = 0; opc <= 3; opc++)
            {
                
                Console.WriteLine((opc+1)+"."+operaciones[opc]);

            }
            Console.WriteLine("Seleccione una operacion");
            opUsuario = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Ingrese dos numeros enteros");
            Console.WriteLine("Ingrese el primer numero");
            num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            switch(opUsuario)
            {
                case 1:
                Console.WriteLine(" Usted a seleccionado una Suma ");
                resultado = num1 + num2;
                break;
                case 2:
                Console.WriteLine("Usted a seleccionado una Resta ");
                resultado=num1-num2;
                break;
                case 3:
                Console.WriteLine("Usted a seleccionado una Multiplicacion ");
                resultado=num1*num2;
                break;
                case 4:
                Console.WriteLine("Usted a seleccionado una Division ");
                resultado=num1/num2;
                break;
                default:
                Console.WriteLine(" No selecciono una operacion valida ");
                break;

            }

            Console.WriteLine(" El resultado de la opreracion es: " + resultado);
            Console.WriteLine(" Desea hacer una Operacion Y/N ");
            respuesta = Console.ReadLine();
        }

      
        Console.WriteLine(" Fin del Programa ");
        Console.ReadLine();
        }
    }

