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
            Console.Write("Vista al Mar: ");
            if (VistaMar)
            {
                Console.WriteLine("Si");
            }
            else Console.WriteLine("No");
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
    }
}
