using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using UdemyCourse.NET.Excepciones;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace UdemyCourse.NET
{

   public class Persona
    {

        public string nombre;
       
        [XmlAttribute ("MayorEdad")]
        
        public int edad;

        
        [XmlIgnore]
        public DateTime cumpleaños; 

    }
    class Program


    {
        /// <summary>
        /// [Serializable] Indicamos que esta clase serializacion se va a serializar
        /// </summary>



       // [Serializable]
      /* class serializacion
        {
            /// <param name="id"> El campo id se serializara </param>
            /// <param name="nombre"> El campo nombre se serializara</param>

          
        }
        */

        /// <summary>
        /// INDICAR QUE ESTA CLASE SERA SERIALIZABLE POR JSON
        /// </summary>
        //[DataContract]

        class cliente {

         //   [DataMember]
            public string Nombre { get; set; }
         //   [DataMember]
            public string Email { get; set; }


        }



        static void Main(string[] args)
        {
            #region Serialize - Deserialize
            /*
             serializacion objeto = new serializacion();

            objeto.id = 1;
            objeto.nombre = "Juan";

           
             
             //Comenzamos la serializacion 
            

            // Serializar y convertir un objeto a formato binario
            IFormatter formatter = new BinaryFormatter();

            // Un objeto de secuencia de archivos, FileStream crear un nuevo archivo de solo escritura 
            Stream stream = new FileStream(@"C:\Users\cangulo\Desktop\ejemplo.txt", FileMode.Create, FileAccess.Write);

            /// <param name="stream"> Entregamos el archivo que va a contener los datos </param>
            /// <param name="objeto"> Entregamois el objeto que contiene los datos a serializar  </param>
            formatter.Serialize(stream, objeto);

            // cerramos la transmision

            stream.Close();

            
            // Comenzamos Deserializar archivo
             
            
            // abrir nuestro archivo de nuestra instancia stream, ir a nuestro archivo, lo abrimos y le damos acceso de solo lectura
            stream = new FileStream(@"C:\Users\cangulo\Desktop\ejemplo.txt", FileMode.Open, FileAccess.Read);

            // Nueva instancia objetonuevo, asignar valor que tenemos en serializacion, usando el metodo de deserialize de formatear
            serializacion objetonuevo = (serializacion)formatter.Deserialize(stream);


            Console.WriteLine(objetonuevo.id);
            Console.WriteLine(objetonuevo.nombre);
            Console.ReadKey();


            */

            #endregion

            #region Serialize - Deserialize JSON - Biblioteca Datacontract

            /*cliente objcliente = new cliente()
            {
                Nombre = "Juan",
                Email = "Gold@gmail.com"
            };

            // Crear unstancia de DataContractJsonSerializar
            /// <param name="Cliente"> Pasamos a la instancia nuestro cliente</param>

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(cliente));

            MemoryStream Objms = new MemoryStream();

            // Escribimos el contenido de nuestro objeto cliente en nuestro objeto memory stream
            js.WriteObject(Objms, objcliente);

            // desde donde escribimos
            Objms.Position = 0;


            // Leer los datos de nuestros json en nuestro streamreader
            StreamReader sr = new StreamReader(Objms);


            string json = sr.ReadToEnd();
            Objms.Close();

            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {

                DataContractJsonSerializer deserializar = new DataContractJsonSerializer(typeof(cliente));

                cliente objcliente2 = (cliente)deserializar.ReadObject(ms);

                Console.WriteLine(objcliente2.Nombre);
                Console.WriteLine(objcliente2.Email);
                Console.ReadKey();
            }
            */
            #endregion

            #region Serialize - Deserialize JSON - Biblioteca JavaScriptSerializer

            /* cliente objcliente = new cliente()
             {
                 Nombre = "Juan",
                 Email = "Gold@gmail.com"
             };

             // nos ahorramos mucho codigo 
             JavaScriptSerializer js = new JavaScriptSerializer();
             string json = js.Serialize(objcliente);
             JavaScriptSerializer js2 = new JavaScriptSerializer();
             cliente deserializar = js2.Deserialize<cliente>(json);

             Console.WriteLine("El nombre {0}  tiene el email {1}", deserializar.Nombre, deserializar.Email);
             Console.ReadKey();*/
            #endregion

            #region Excepciones


            /* DivNums div = new DivNums();
            div.Division(23, 0);
            Console.ReadKey();*/

            /*
            ThrowExceptions throwExceptions = new ThrowExceptions();
            throwExceptions.operacion(); */

            /*
            ThrowExceptions2 throwExceptions2 = new ThrowExceptions2();
            throwExceptions2.Operacion();
            */


            /*
             ThrowException3 throwExceptions3 = new ThrowException3();
             throwExceptions3.Operaciones();
            */

            #endregion

            #region Lista generica
            /* Lista genericas

             ApplyList<int> MiListadeEnteros = new ApplyList<int>();

           MiListadeEnteros.AgregarElemento(1);
           MiListadeEnteros.AgregarElemento(2);

           MiListadeEnteros.Listar();

           MiListadeEnteros.EliminarElemento(1);

           MiListadeEnteros.Listar();

           Console.ReadKey();
           ApplyList<string> MiListadeCadenas = new ApplyList<string>();

           string nombre = "juan";
           string Apellido = "ahum";
           MiListadeCadenas.AgregarElemento(nombre);
           MiListadeCadenas.AgregarElemento(Apellido.ToString());

           MiListadeCadenas.Listar();

           MiListadeCadenas.EliminarElemento(nombre);

           MiListadeCadenas.Listar();

           Console.ReadKey();
            */

            #endregion

            #region Serialize - Deserialize JSON - Biblioteca Json.net
            /* cliente objcliente = new cliente()
             {
                 Nombre = "Juan",
                 Email = "Gold@gmail.com"
             };

             string json = JsonConvert.SerializeObject(objcliente);

             cliente objcliente2 = JsonConvert.DeserializeObject<cliente>(json);

             Console.WriteLine("El nombre es {0} y tiene el email {1}", objcliente2.Nombre, objcliente2.Email);
             Console.ReadKey(); */
            #endregion

            #region Serialize - Deserialize - XML - Biblioteca XmlSerializer 
            /*Persona p = new Persona();
            p.nombre = "Angel";
            p.edad = 40;
            DateTime dateTime = DateTime.Now;

            p.cumpleaños = dateTime;

            XmlSerializer xs = new XmlSerializer(typeof(Persona));

            // crear un nuevo archivo xml
            using (Stream s = File.Create(@"C:\Users\cangulo\Desktop\Persona.xml"))
            {


                // Pasamos por parametro el objeto donde va a estar guaradado, y el objeto que va a serializar

                xs.Serialize(s, p);

            }

            Persona persona2 = new Persona();
            using (Stream s = File.OpenRead(@"C:\Users\cangulo\Desktop\Persona.xml"))
            {


                // Pasamos por parametro el objeto donde va a estar guaradado, y el objeto que va a serializar

                persona2 = (Persona)xs.Deserialize(s);


            }


            Console.WriteLine("La edad de {0}  es  {1}", persona2.nombre, persona2.edad);
            Console.ReadKey();*/
            #endregion

            double Kilometros = 0.0;
            double Millas = 0.0;

            Console.WriteLine("***************Bienvenido a tu convertidor***************");
            Console.WriteLine("***************Ingresa tu Numero a convertir***************");
            int NmroInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************Elije tu Opcion***************");
            Console.WriteLine("*************** 1) Convertir de kilometros a millas --- 2) Convertir a Kilometros a millas ***************");
            int NmroInputOption = Convert.ToInt32(Console.ReadLine());
            if (NmroInputOption == 2)
            {

                Millas = Convert.ToDouble(NmroInput);
                Kilometros = Millas * 1.690;
                Console.WriteLine("La conversion de {0} Millas a  Km  es {1} ", Millas,  Kilometros );
             }
            else
            {

                Kilometros = Convert.ToDouble(NmroInput);
                Millas = Kilometros / 1.690;
                Console.WriteLine("La conversion de {0} Kilometros a Millas  es {1} ", Kilometros,  Millas);
            }

            Console.ReadKey();
        }
    }
}