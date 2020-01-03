using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourse.NET.Excepciones
{
   public class ThrowException3
    {


        int num1, num2, resultado;
    
        public void Operaciones()
        {


            Console.WriteLine("Introduce tu numero");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce tu numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                resultado = num1 / num2;
                Console.WriteLine("El resultado de la operacion es {0}", resultado);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: {0}", e.ToString());

            }

            Console.ReadKey();
        }    
    }

}
