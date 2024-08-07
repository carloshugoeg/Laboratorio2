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
            AgregarHabitacion(Hotel);
            break;
        case "2":
            foreach (var device in electronicDevices)
            {
                device.ShowDevice();
            }
            Console.Write("Presione ENTER para continuar");
            Console.ReadLine();
            break;

        case "3":
            int index = electronicDevice.SearchDevice(electronicDevices);
            if (index != -1)
            {
                electronicDevices[index].ShowDevice();
            }
            else Console.WriteLine("Dicho dispositivo no existe");
            Console.Write("Presione ENTER para continuar");
            Console.ReadLine();
            break;
    }
} while (true);
void AgregarHabitacion(List<Habitacion> hotel)
{
    Console.WriteLine("-----AGREGAR HABITACION------");
    Console.WriteLine("\n     1. Habitacion Simple");
    Console.WriteLine("\n     2. Habitacion Doble");
    Console.WriteLine("\n     3. Suite");
    Console.WriteLine("\n     4. Habitacion Deluxe");
    string opcion = Console.ReadLine();
    Console.Write("\nNumero Habitacion: ");
    string name = Console.ReadLine();
    double precio = habitacion.PedirPrecio();
    switch (opcion)
    {
        case "1":
            Console.Write("Numero de Camas: ");
            int numCamas = PedirNumero();


            break;
        case "2":
            Console.WriteLine("");
            
        case "3":
          
    }
}

int PedirNumero()
{
    do
    {
        try
        {

            int numero;
            do
            {
                numero = int.Parse(Console.ReadLine());
                if (numero == 0 || numero == null)
                {
                    Console.WriteLine("Valor no puede ser 0");
                    Console.ReadLine();
                }
            } while (numero == 0);
            return numero;
        }
        catch (FormatException ex)
        {
            Console.WriteLine("INPUT INVALIDO");
            Console.WriteLine(ex.Message);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("-----Nueva Habitacion-----");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("EL numero es demasiado grande");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("-----Nueva Habitacion-----");
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR");
            Console.WriteLine(ex.Message);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("-----Nueva Habitacion-----");
        }
    } while (true);
}
