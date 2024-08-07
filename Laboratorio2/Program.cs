using Laboratorio2;

List<Habitacion> Hotel = new List<Habitacion>();
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
            AddDevice(electronicDevices);
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