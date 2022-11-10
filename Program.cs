using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L13_CJNR_1128121
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] edad = new int[5];
            string[] nombres = new string[5];
            bool val = true;
            string nombres18 = "";
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Ingrese su nombre ");
                    nombres[i] = Console.ReadLine();
                    Console.Write("Ingrese su edad ");
                    edad[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (FormatException)
            {
                val = false;
                Console.WriteLine("Error! Valor no valido");
            }
            if (val)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (edad[i] > 18)
                    {
                        nombres18 += nombres[i] + "\n";
                    }
                }
                Console.WriteLine("Las personas mayores a  18 años son:\n" + nombres18);
            }
            Console.ReadKey();
        }
    }
}
