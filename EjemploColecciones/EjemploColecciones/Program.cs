using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploColecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------LIST------------------------------------");

            Console.WriteLine();

            //Declaro una lista de idiomas y agrego idiomas a la lista

            List<string> idiomas = new List<string>();
            idiomas.Add("Chino");
            idiomas.Add("Español");
            idiomas.Add("Ingles");
            idiomas.Add("Hindu");
            idiomas.Add("Arabe");
            idiomas.Add("Portugues");

            Console.WriteLine("Idiomas mas hablados:");

            foreach (string idioma in idiomas)
            {
                Console.WriteLine(idioma);
            }

            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Orden ascendente");

            //Ordeno la lista y vuelvo a mostrarla
            idiomas.Sort();

            foreach (string idioma in idiomas)
            {
                Console.WriteLine(idioma);
            }

            Console.ReadKey();

            //Ordeno la lista en forma descendente y la muestro

            Console.WriteLine();
            Console.WriteLine("Orden descendente");

            idiomas.Sort(Program.OrdenarDescendente);

            foreach (string idioma in idiomas)
            {
                Console.WriteLine(idioma);
            }

            Console.ReadKey();
            Console.Clear();

            //Crear una lista utilizando el inicializador de colecciones
            Console.WriteLine("Lenguas indigenas: ");

            List<string> lenguasIndigenas = new List<string> { "Quechua", "Guarani", "Aimara", "Nahuati", "Maya" };

            foreach (string lengua in lenguasIndigenas)
            {
                Console.WriteLine(lengua);
            }

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Quito un elemento: ");

            //Elimino el elemento que conicida con el que paso por paramtro
            lenguasIndigenas.Remove("Maya");

            foreach (string lengua in lenguasIndigenas)
            {
                Console.WriteLine("{1}{0}", lengua, lenguasIndigenas.IndexOf(lengua) + 1);
            }

            Console.ReadKey();


            //Quito un elemento en una posicion especifica
            Console.WriteLine();
            Console.WriteLine("Quito un elemento en una posicion específica: ");
            lenguasIndigenas.RemoveAt(3);

            foreach (var item in lenguasIndigenas)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("----------------------------DICTIONARY--------------------------------------------------");
            // Crea un nuevo diccionario de strings, con claves de tipo string
           
            Dictionary<string, string> abrirCon = new Dictionary<string, string>();

            // Agrega elementos al diccionario. Los valores pueden repetirse, pero no las claves

            abrirCon.Add("txt", "notepad.exe");
            abrirCon.Add("bmp", "paint.exe");
            abrirCon.Add("dib", "paint.exe");
            abrirCon.Add("rtf", "wordpad.exe");


            Console.WriteLine("Validacion de clave: ");

            // Sin la nueva clave ya existe, el metodo Add lanza una excepcion
            try
            {
                abrirCon.Add("txt", "winword.exe");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Ya existe un elemento con la clave txt.");
            }

            Console.ReadKey();

            // Modificacion de un valor asociado a una clave
            Console.WriteLine();
            Console.WriteLine("Modificar un valor:");

            abrirCon["rtf"] = "winword.exe";

            Console.WriteLine("Para la clave = \"rtf\", el valor es = {0}.", abrirCon["rtf"]);

            Console.ReadKey();


            // Si la clave no existe, se agrega un nuevo par de clave/valor
            abrirCon["doc"] = "winword.exe";


            // Se puede usar TryGetValue para intentar recuperar valores
            Console.WriteLine();
            Console.WriteLine("TryGetValue:");

            string value = "";
            if (abrirCon.TryGetValue("tif", out value))
            {
                Console.WriteLine("Para la clave = \"tif\", el valor es = {0}.", value);
            }
            else
            {
                Console.WriteLine("Clave = \"tif\" no encontrada.");
            }

            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("ContainsKey:");

            // ContainsKey puede usarse para testear claves antes de insertarlas
            if (!abrirCon.ContainsKey("ht"))
            {
                abrirCon.Add("ht", "hypertrm.exe");
                Console.WriteLine("Valor agregado para la clave = \"ht\": {0}", abrirCon["ht"]);
            }

            Console.ReadKey();


            // Se recorre el diccionario con un foreach, y los elementos se devuelven como pares de clave valor
            Console.WriteLine();
            Console.WriteLine("Abrir archivos con: ");

            foreach (KeyValuePair<string, string> kvp in abrirCon)
            {
                Console.WriteLine("Clave = {0}, Valor = {1}", kvp.Key, kvp.Value);
            }

            Console.ReadKey();

            // Se usa el metodo Remove para eliminar elementos
            Console.WriteLine();
            Console.WriteLine("\nEliminar clave: (\"doc\")");

            // Se le pasa como parametro la clave
            abrirCon.Remove("doc");

            if (!abrirCon.ContainsKey("doc"))
            {
                Console.WriteLine("La clave \"doc\" no fue encontrada.");
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("-------------------------------------QUEUE------------------------------------------------");

            //Agrego elementos a la fila y los muestro
            Console.WriteLine("Numeros:");

            Queue <string> numeros = new Queue<string>();
            numeros.Enqueue("uno");
            numeros.Enqueue("dos");
            numeros.Enqueue("tres");
            numeros.Enqueue("cuatro");
            numeros.Enqueue("cinco");
           
            foreach (string numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.ReadKey();

            //Devuelve y elimina el primer elemento
            Console.WriteLine("\nQuitando el primer elemento: '{0}'", numeros.Dequeue());
            //Devuelve el primer elemento sin eliminarlo
            Console.WriteLine("Devolviendo el primer elemento: {0}", numeros.Peek());
            Console.WriteLine("Quitando el primer elemento: '{0}'", numeros.Dequeue());
            Console.WriteLine("Devolviendo el primer elemento: {0}", numeros.Peek());
            Console.WriteLine("Quitando el primer elemento: '{0}'", numeros.Dequeue());

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("----------------------------SORTED LIST------------------------------------------");
            Console.WriteLine();

            //Declaro una lista ordenada y agrego elementos

            Console.WriteLine("Fechas Historicas: ");

            SortedList<int, string> fechasHistoricas = new SortedList<int, string>();

            fechasHistoricas.Add(1789, "Revolucion Francesa");
            fechasHistoricas.Add(1989, "Caida del muro de Berlin");
            fechasHistoricas.Add(1492, "Llegada de Colon a America");
            fechasHistoricas.Add(1929, "La gran depresion");
            fechasHistoricas.Add(1917, "Revolucion Rusa");

            foreach (KeyValuePair<int, string> fh in fechasHistoricas)
            {
                Console.WriteLine("{0}: {1}", fh.Key, fh.Value);
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("-----------------------------------STACK-----------------------------------------------");

            Console.WriteLine("Cajas: ");
            Stack<string> cajas = new Stack<string>();

            cajas.Push("caja 1");
            cajas.Push("caja 2");
            cajas.Push("caja 3");
            cajas.Push("caja 4");
            cajas.Push("caja 5");

            foreach (string caja in cajas)
            {
                Console.WriteLine(caja);
            }

            Console.ReadKey();
            Console.WriteLine();

            Random r = new Random();

            while(cajas.Count > 0)
            {
                Console.WriteLine("Llevar: {0}. Quedan {1} cajas en la pila.", cajas.Pop(), cajas.Count);
                // Demoro la iteración entre 1 y 3 segundos
                System.Threading.Thread.Sleep(r.Next(1000, 3000));
            }
        }



        private static int OrdenarDescendente(string s1, string s2)
        {
            return -s1.CompareTo(s2);
        }
    }
}
