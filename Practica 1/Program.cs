using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            List<Aula> listaAula;
            listaAula = new List<Aula>();

            #region menu principal
            Console.ForegroundColor = ConsoleColor.White;
            string menu = "tevoyadecirunacosa";
            string salir = "hulio";
            do
            {
                Console.Clear();
                Console.WriteLine("  == Gestión de ordenadores == ");
                Console.WriteLine();
                Console.WriteLine(" 1. Aulas/Salas del centro.\n");
                Console.WriteLine(" 2. Ordenadores.\n");
                Console.WriteLine(" 3. Búsquedas.\n");
                Console.WriteLine(" 4. Listados.\n");
                Console.WriteLine(" 5. Configuración.\n");
                Console.WriteLine(" 0. Salir");
                Console.WriteLine("-----------------------------------\n");
                Console.Write(" Por favor, elija una opción: ");
                Console.ForegroundColor = ConsoleColor.Green;
                menu = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                switch (menu)
                {
                    case "1":
                        System.Threading.Thread.Sleep(600);
                        MenuAulas();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "0":
                        Console.Write("\n ¿Confirma que desea salir? (S/N): ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        salir = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (salir == "S" || salir == "s")
                        {
                            Environment.Exit(0);
                        }
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nOpción incorrecta.\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        System.Threading.Thread.Sleep(800);
                        break;

                }


            } while (menu != "1" || menu != "2" || menu != "3" || menu != "4" || menu != "5");
            #endregion
        }
        #region aulas
        static void MenuAulas()
        {
            string menu = "tevoyadecirunacosa";
            do
            {
                Console.Clear();
                Console.WriteLine("  == Gestión de aulas == ");
                Console.WriteLine();
                Console.WriteLine(" 1. Ver aulas.\n");
                Console.WriteLine(" 2. Añadir aulas.\n");
                Console.WriteLine(" 3. Borrar aula.\n");
                Console.WriteLine(" 4. Modificar aula.\n");
                Console.WriteLine(" 0. Salir");
                Console.WriteLine("-----------------------------------\n");
                Console.Write(" Por favor, elija una opción: ");
                Console.ForegroundColor = ConsoleColor.Green;
                menu = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                switch (menu)
                {
                    case "1":
                        System.Threading.Thread.Sleep(500);
                        AnadirAula();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "0":
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nOpción incorrecta.\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        System.Threading.Thread.Sleep(800);
                        break;

                }


            } while (menu != "0");
        }
        static void AnadirAula()
        {
            int num;
            string nom;
            Aula aula;
            Console.Clear();
            Console.WriteLine(" == Añadir aula ==");
            Console.WriteLine();
            Console.Write("Identificador (0 para ver lista de aulas): ");
            Console.ForegroundColor = ConsoleColor.Green;
            num = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            while (num < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t == DEBE SER UN NUMERO POSITIVO ==\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Identificador (0 para ver lista de aulas): ");
                Console.ForegroundColor = ConsoleColor.Green;
                num = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
            if (num == 0)
            {

            }
            Console.Write("Nombre: ");
            Console.ForegroundColor = ConsoleColor.Green;
            nom = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            while (nom.Length > 40)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t == DEBE SER UN VALOR MENOR DE 40 CARACTERES ==\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Nombre: ");
                Console.ForegroundColor = ConsoleColor.Green;
                nom = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
            Console.WriteLine();
            aula = new Aula(num, nom, DateTime.Now);
        }
        #endregion
        #region metodos
       public bool ListAulasVacia(List<Aula> l) //metodo que comprueba que la lista de aulas está vacía para el listado de aulas.
        {
            if(l.Count == 0)
            return true;
            else
            return false;
        }
        #endregion
    }
}
