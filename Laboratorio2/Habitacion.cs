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
            Console.WriteLine("Disponible: " + Disponible);
            if (ClienteAsignado != null)
            {
                Console.WriteLine("Cliente Asignado: " + ClienteAsignado);
            }
        }

        public virtual void CambiarDisponibilidad(bool disponible) => Disponible = disponible;

        public virtual void AsignarCliente(string cliente)
        {
            ClienteAsignado = cliente;
            Console.WriteLine($"Cliente: {cliente}");
            Console.WriteLine("CLiente asignado correctamente");
            Console.ReadLine();
            Console.Clear();
        }

        public virtual int BuscarHabitacion(List<Habitacion> habitaciones)
        {
            Console.WriteLine("--------BUSCAR HABITACION---------");
            Console.Write("Ingrese Numero de habitacion: ");
            string habitacionBuscada = Console.ReadLine();
            int indice = 0;
            bool encontrada = false;
            foreach (Habitacion habitacion in habitaciones)
            {
                if (habitacion.Numero != Numero)
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
    }
}
