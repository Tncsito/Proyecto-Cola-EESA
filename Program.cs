namespace Proyecto_Cola_EESA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool p = true;
            int n = 99;
            Cola a = new Cola(n); // Inicializa la pila fuera del bucle

            while (p)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    Console.WriteLine("\tMenu");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("1.- Set Size");              //Prueba
                    Console.WriteLine("2.- Insert");                //Prueba
                    Console.WriteLine("3.- Extract");               //Prueba
                    Console.WriteLine("4.- Print");                 //Prueba
                    Console.WriteLine("5.- Exit");                  //Prueba
                    Console.WriteLine("-------------------------");
                    Console.Write("Select Option => ");
                    int opc = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (opc)
                    {
                        case 1: //Set Size
                            Console.Write("Escribe el tamaño de la cola => ");
                            n = Convert.ToInt32(Console.ReadLine());
                            a.Size(n);
                            Console.Clear();
                            Console.WriteLine("¡Tamaño de Cola ajustado correctamente! \n");
                            break;
                        case 2: //Insert
                            Console.Write("Escribe numero a insertar => ");
                            int nn = Convert.ToInt32(Console.ReadLine());
                            if (a.Insert(nn))
                                Console.WriteLine("¡Numero agregado correctamente!");
                            else
                                Console.WriteLine("Numero no Agregado");
                            break;
                        case 3: //Extract
                            int v = a.Extract();
                            Console.WriteLine($"Numero {v} sacado correctamente");
                            break;
                        case 4: //Print
                            a.Print();
                            break;
                        case 5: //Salir
                            p = false;
                            return;
                        default:
                            Console.WriteLine("\nPor favor Seleccione una Opción");
                            break;

                    }
                    Console.Write("\n\n\n\n\n\n\t<Presiona cualquier tecla para continuar>");
                    Console.ReadKey();
                }
                catch (Exception e)
                {
                    Console.WindowHeight = 10;
                    Console.WindowWidth = 60;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n\tCaracter no válido <ENTER PARA CONTINUAR>");
                    Console.ReadKey();
                }
            }
        }
    }
}