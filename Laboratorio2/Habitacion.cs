using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    public class Habitacion
    {
        public Habitacion(int numero, double precioNoche)
        {
            Numero = numero;
            PrecioNoche = precioNoche;
            Disponible = true;
        }

        public int Numero { get; set; }
        public  double  PrecioNoche { get; set; }
        public  bool Disponible { get; set; }
        public  string ClienteAsignado { get; set; }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("--------------");
            Console.WriteLine("Numero de habitaccion: " + Numero);
            Console.WriteLine("Precio habitacion: " + PrecioNoche);
            Console.Write("Disponible: ");
            if (Disponible)
            {
                Console.WriteLine("Si");
            }
            else Console.WriteLine("No");

            if (ClienteAsignado != null)
            {
                Console.WriteLine("Cliente Asignado: " + ClienteAsignado);
            }
        }

        public virtual void CambiarDisponibilidad(bool disponible) => Disponible = disponible;

        public virtual void AsignarCliente(string cliente)
        {
            ClienteAsignado = cliente;
            Console.ForegroundColor  = ConsoleColor.Green;
            Console.WriteLine($"\n\nCliente: {cliente}");
            Console.Write("Cliente asignado correctamente");
            CambiarDisponibilidad(false);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
            Console.Clear();
        }
        public virtual double PedirPrecio()
        {
            do
            {
                try
                {

                    double precio;
                    do
                    {
                        Console.Write("Ingrese el precio de habitacion: Q.");
                        precio = Math.Abs(double.Parse(Console.ReadLine()));
                        if (precio == 0 || precio == null)
                        {
                            Console.WriteLine("Valor no puede ser 0");
                            Console.ReadLine();
                        }
                    } while (precio == 0);
                    return precio;
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

        public virtual int BuscarHabitacion(List<Habitacion> habitaciones)
        {
            Console.WriteLine("--------BUSCAR HABITACION---------");
            int habitacionBuscada;
            do
            {
                Console.Write("Ingrese Numero de habitacion: ");
                habitacionBuscada = PedirNumero();
                if (habitacionBuscada >= 0)
                {
                    break;
                }

            } while (true);
            int indice = 0;
            bool encontrada = false;
            foreach (Habitacion habitacion in habitaciones)
            {
                if (habitacion.Numero != habitacionBuscada)
                {
                    indice++;
                }
                else
                {
                    encontrada = true;
                    break;
                }
            }
            if (encontrada) return indice;
            else return -1;
        }
        public int PedirNumero()
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
                    return -1;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("EL numero es demasiado grande");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("-----Nueva Habitacion-----");
                    return -1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR");
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("-----Nueva Habitacion-----");
                    return -1;
                }
            } while (true);
        }
        public virtual void LiberarHabitacion(List<Habitacion> habitaciones)
        {
            int indice = BuscarHabitacion(habitaciones);
            if (indice >= 0)
            {
                Console.WriteLine("Habitacion Liberada Correctamente");
                Console.ReadLine();
                habitaciones[indice].CambiarDisponibilidad(false);
                habitaciones[indice].ClienteAsignado = "";
                return;
            }
            else Console.WriteLine("No se encontro habitacion");
        }
        public virtual void EliminarHabitacion(List<Habitacion> habitaciones)
        {
            int indice = BuscarHabitacion(habitaciones);
            if (indice >= 0)
            {
                Console.WriteLine("Habitacion Eliminada Correctamente");
                Console.ReadLine();
                habitaciones.RemoveAt(indice);
                return;
            }
            else Console.WriteLine("No se encontro habitacion");
        }
    }
}
