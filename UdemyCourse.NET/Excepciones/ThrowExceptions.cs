using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourse.NET.Excepciones
{
   public class ThrowExceptions
    {

        public int num1, num2;
        public int resultado;


        public void operacion()
        {


            Console.WriteLine("Introduce numero");
            num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Introduce numero");
            num2 = Convert.ToInt32(Console.ReadLine());



            try
            {

                resultado = num1 / num2;
                Console.WriteLine("{0}, {1}, {2}", num1, num2, resultado);

            }
            catch
            {
                Console.WriteLine("{0}, {1}", num1, num2);
                Console.WriteLine("Se ha producido una excepcion");
                throw;

            }

            finally

            {
                resultado = num1 / num2;
                Console.WriteLine("El resultado es {0} ", resultado);

            }
            Console.ReadKey();

        }


    }
}
