using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    internal class HabitacionSimple : Habitacion
    {
        public int NumeroCamas { get; set; }
        public HabitacionSimple(int numero, double precioNoche, int numeroCamas) : base(numero, precioNoche)
        {
            NumeroCamas = numeroCamas;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Numero de camas: " + NumeroCamas);
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
        public override void LiberarHabitacion(List<Habitacion> habitaciones) => base.LiberarHabitacion(habitaciones);
        public override void EliminarHabitacion(List<Habitacion> habitaciones) => base.EliminarHabitacion(habitaciones);
    }
}
