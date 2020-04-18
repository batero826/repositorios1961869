using System;



    class Program
    {
        static void Main(string[] args)
        {

            int dia = 0;
            int mes = 0;
            string mesLetras="";
            int anio = 0;

            Console.WriteLine(" Ingrese el dia de Nacimiento");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Ingrese el mes de Nacimiento");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Ingrese el año de Nacimiento");
            anio = Convert.ToInt32(Console.ReadLine());

            switch(mes)
            {
                case 1:
                mesLetras="Enero";
                break;
                case 2:
                mesLetras = "Febrero";
                break;
                case 3:
                mesLetras = "Marzo";
                break;
                case 4:
                mesLetras = "Abril";
                break;
                case 5:
                mesLetras = "Mayo";
                break;
                case 6:
                mesLetras = "Junio";
                break;
                case 7:
                mesLetras = "Julio";
                break;
                case 8:
                mesLetras = "Agosto";
                break;
                case 9:
                mesLetras = "Septiembre";
                break;
                case 10:
                mesLetras = "Octubre";
                break;
                case 11:
                mesLetras = "Noviembre";
                break;
                case 12:
                mesLetras = "Diciembre";
                break;

                default:
                       mesLetras ="ERROR";
                    break;
                   
            }

            if (mesLetras == "ERROR")
            {

                Console.WriteLine("La fecha dada esta incorrecta");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" Usted naciò el dia " + dia + " del mes " + mesLetras + " del año " + anio);
                Console.ReadLine();
            }
        }
    }

