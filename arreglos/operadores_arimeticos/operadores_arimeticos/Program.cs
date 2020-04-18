using System;

class Program
{
    static void Main(string[] args)
    {
        string[] Operaciones = new string[5];
        Operaciones[0] = "suma ";
        Operaciones[1] = "Resta";
        Operaciones[2] = "Multiplicación ";
        Operaciones[3] = "Division ";
        Operaciones[4] = " ERROR";
        int OpUsuario = 0;
        int Resultado = 0;
        int num1 = 0;
        int num2 = 0;
        int op = 0;
        string RespuestaUsuario = "";
        Console.WriteLine("Desea  realizar  algun tipo de operación (Y/N)");
        RespuestaUsuario = Convert.ToInt32(Console.ReadLine());
        while (RespuestaUsuario == "Y")
        {
            for ( op = 0; op <= 3; op++)
            {


                Console.WriteLine((op+1)+"."+Operaciones[op]);
            
            
            }
                 Console.WriteLine(" ingrese  el primero  entero: ");
                 num1 = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine(" ingrese  el segundo  entero:");
                 num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("SELECIONE UNA OPERACION: ");
                op = Convert.ToInt32(Console.ReadLine());
                
                switch (op)
                {

                    case 1:
                        Console.WriteLine("usted ha selecionado  una suma: ");
                        Resultado = num1 + num2;
                        break;

                    case 2:
                        Console.WriteLine("usted ha selecionado  una resta : ");
                        Resultado = num1 - num2;
                        break;

                    case 3:
                        Console.WriteLine("usted ha selecionado  una multiiplicacion: ");
                        Resultado = num1 * num2;
                        break;

                    case 4:
                        Console.WriteLine("usted ha selecionado  una  dividir: ");
                        Resultado = num1 / num2;
                        break;
                    default:

                        Console.WriteLine("No selecciono  una operacion  validad");
                        break;

                }
                  Console.WriteLine("desea resultado es =" + Resultado);
                  Console.WriteLine("desea hacer una operacion  Y/N");
                 RespuestaUsuario = Console.ReadLine();
            }

            Console.WriteLine("fin del programa ");
            Console.ReadLine();
        }
    }
