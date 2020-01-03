using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourse.NET.Excepciones
{
   public class DivNums
    {
        int resultado;
      public   DivNums()
        {

            resultado = 0;

        }

        public void Division(int num1, int num2)
        {
            try { resultado = num1 / num2; }
            catch (DivideByZeroException Dividevyzero)
            {
                Console.WriteLine("Se ha producido la excepción del tipo {0}", Dividevyzero);


            }

            finally
            {
                Console.WriteLine("El resultado es {0}", resultado);

            }

        }


    }
}
