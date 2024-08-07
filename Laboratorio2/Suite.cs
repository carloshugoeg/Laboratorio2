using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    internal class Suite : Habitacion
    {
        public int NumeroHabitaciones { get; set; }
        public bool TieneJacuzzi {  get; set; }
        public Suite(int numero, double precioNoche, int numeroHabitaciones, bool tieneJacuzzi) : base(numero, precioNoche)
        {
            NumeroHabitaciones = numeroHabitaciones;
            TieneJacuzzi = tieneJacuzzi;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Numero de Habitaciones: ");
            Console.Write("Tiene Jacuzzi: ");
            if (TieneJacuzzi)
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
