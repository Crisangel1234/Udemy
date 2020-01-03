using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace UdemyCourse.NET.Excepciones
{
    public class ApplyList<t>
    {

        private List<t> elementos;

        public ApplyList(){

            elementos = new List<t>();


           }

     
        public void AgregarElemento(t nuevoElemento)
        {

            elementos.Add(nuevoElemento);
        }

       
        public void EliminarElemento(t eliminarElemento)
        {

            elementos.Remove(eliminarElemento);
        }

        public void Listar()
        {
            foreach (var elemento in elementos)
            {
                Console.WriteLine("El elemento es  "+elemento );

            }

        }
    }
}
