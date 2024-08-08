using Laboratorio2;
using System.Runtime.InteropServices;

List<Habitacion> Hotel = new List<Habitacion>();
Habitacion habitacion = new Habitacion(0, 0);
do
{
    Console.Clear();
    Console.WriteLine("------Hotel------");
    Console.WriteLine("\n     1. Agregar Habitacion");
    Console.WriteLine("\n     2. Eliminar Habitacion");
    Console.WriteLine("\n     3. Mostrar Habitaciones");
    Console.WriteLine("\n     4. Asignar Cliente");
    Console.WriteLine("\n     5. Liberar Habitacion");


    string opcion = Console.ReadLine();
    switch (opcion)
    {
        case "1":
            Console.Clear();
            AgregarHabitacion(Hotel);
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("--------ELIMINAR HABITACION-------\n\n");
            habitacion.EliminarHabitacion(Hotel);
            Console.Write("\nPresione ENTER para continuar");
            Console.ReadLine();
            break;
        case "3":
            foreach (var Habitacion in Hotel)
            {
                Habitacion.MostrarInformacion();
            }
            Console.Write("\nPresione ENTER para continuar");
            Console.ReadLine();
            break;
        case "4":
            Console.Clear();
            Console.WriteLine("-------ASIGNAR CLIENTE-------");
            Console.WriteLine("\nAntes porfavor indique que habitacion\n\n");
            int indice = habitacion.BuscarHabitacion(Hotel);
            if (indice >= 0)
            {
                if (!Hotel[indice].Disponible)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("La habitacion no se encuentra disponible");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    break;
                }
                Console.Write("Ingrese nombre del cliente: ");
                string cliente = Console.ReadLine();
                Hotel[indice].AsignarCliente(cliente);
                break;
            }
            else Console.WriteLine("No se encontro habitacion");
            Console.ReadLine();
            break;
            
        case "5":

            Console.Clear();
            Console.WriteLine("-------LIBERAR HABITACION-------");
            Console.WriteLine("\nAntes porfavor indique que habitacion\n\n");
            indice = habitacion.BuscarHabitacion(Hotel);
            if (indice >= 0)
            {
                if (!Hotel[indice].Disponible)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("La habitacion se encuentra disponible a partir de ahora");
                    Hotel[indice].CambiarDisponibilidad(true);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    break;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("La habitacion no contiene ningun huesped actualmente");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
                break;
            }
            else Console.WriteLine("No se encontro habitacion");
            Console.ReadLine();
            break;

    }
} while (true);
void AgregarHabitacion(List<Habitacion> hotel)
{
    Console.Clear();
    Console.WriteLine("-----AGREGAR HABITACION------");
    Console.WriteLine("\n     1. Habitacion Simple");
    Console.WriteLine("\n     2. Habitacion Doble");
    Console.WriteLine("\n     3. Suite");
    Console.WriteLine("\n     4. Habitacion Deluxe");
    string opcion = Console.ReadLine();
    int numero;
    do
    {
        Console.Write("\n\nNumero Habitacion: ");
        numero = habitacion.PedirNumero(); 
    } while (numero < 0 );
    double precio = habitacion.PedirPrecio();
    switch (opcion)
    {
        case "1":
            int numCamas;
            do
            {
                Console.Write("Numero de Camas: ");
                numCamas = habitacion.PedirNumero(); 
            } while (numCamas<0);
            HabitacionSimple habitacionSimple = new HabitacionSimple(numero, precio, numCamas);
            hotel.Add(habitacionSimple);
            Console.WriteLine("HABITACION SIMPLE INGRESADA CORRECTAMENTE");
            Console.ReadLine() ;
            break;
        case "2":
            bool vistaMar;
            do
            {
                Console.Write("Numero de Camas: ");
                numCamas = habitacion.PedirNumero();
            } while (numCamas < 0);
            do
            {
                Console.WriteLine("Vista al mar?: s/n  ");
                string si_no = Console.ReadLine().ToLower().Trim();
                if (si_no.Equals("s"))
                {
                    vistaMar = true;
                    break;
                }
                else if (si_no.Equals("n"))
                {
                    vistaMar= false;
                    break;
                }
            }while (true);
            HabitacionDoble habitacionDoble = new HabitacionDoble(numero, precio, numCamas,vistaMar);
            hotel.Add(habitacionDoble);
            Console.WriteLine("HABITACION DOBLE INGRESADA CORRECTAMENTE");
            Console.ReadLine();
            Console.WriteLine("");
            break;
        case "3":
            bool tieneJacuzzi;
            int numHabitaciones;
            do
            {
                Console.Write("Numero de Habitaciones: ");
                numHabitaciones = habitacion.PedirNumero();
            } while (numHabitaciones < 0);
            do
            {
                Console.Write("Tiene Jacuzzi?: s/n  ");
                string si_no = Console.ReadLine().ToLower().Trim();
                if (si_no.Equals("s"))
                {
                    tieneJacuzzi = true;
                    break;
                }
                else if (si_no.Equals("n"))
                {
                    tieneJacuzzi = false;
                    break;
                }
            } while (true);
            Suite suite = new Suite(numero, precio, numHabitaciones, tieneJacuzzi);
            hotel.Add(suite);
            Console.WriteLine("HABITACION DOBLE INGRESADA CORRECTAMENTE");
            Console.ReadLine();
            Console.WriteLine("");
            break;
        case "4":
            do
            {
                Console.Write("Numero de Camas: ");
                numCamas = habitacion.PedirNumero();
            } while (numCamas < 0);
            HabitacionDeluxe habitacionDeluxe = new HabitacionDeluxe(numero, precio, numCamas);
            habitacionDeluxe.AgregarServicios();
            hotel.Add(habitacionDeluxe);
            Console.WriteLine("HABITACION SIMPLE INGRESADA CORRECTAMENTE");
            Console.ReadLine();
            break;

    }
}
