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
    }
}
