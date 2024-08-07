using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    internal class HabitacionDeluxe : HabitacionSimple
    {
        public List<string> ServiciosExtra { get; set; }
        public HabitacionDeluxe(int numero, double precioNoche, int numeroCamas) : base(numero, precioNoche, numeroCamas)
        {

        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            foreach (string s in ServiciosExtra)
            {
                Console.WriteLine("Extra: ");
            }
        }

        public override void CambiarDisponibilidad(bool disponible) => base.CambiarDisponibilidad(disponible);

        public override void AsignarCliente(string cliente) => base.AsignarCliente(cliente);
        public override double PedirPrecio()
        {
            return base.PedirPrecio();
        }
        public override int BuscarHabitacion(List<Habitacion> habitaciones)
        {
            return base.BuscarHabitacion(habitaciones);
        }
        public void AgregarServicios()
        {
            List<string> servicios = new List<string>();
            do
            {
                Console.Write("Servicio Extra: ");
                string servicio = Console.ReadLine();
                servicios.Add(servicio);
                Console.Write("\nDesea Agregar otro servicio? y/n  ");
                string opcion = Console.ReadLine().ToLower().Trim();
                if(opcion.Equals("y"))
                {
                    break;
                }
            } while(true);
        }
    }
}
