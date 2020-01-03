using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourse.NET.Excepciones
{
    public class ThrowExceptions2
    {

       public  int num1, num2, resultado;

        public void Operacion()
        {

            Console.WriteLine("Introduce numero");
            num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Introduce numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (num2==0)
                {
                    throw new Exception("No se puede dividir por cero ");
                }

                resultado = num1 / num2;
                Console.WriteLine("{0},{1},{2}",num1,num2,resultado);
            }

            catch(Exception e)
            {
                Console.WriteLine("Se ha capturado la excpecion: {0}", e.ToString());


            }
            Console.ReadKey();
        }
    }
}
