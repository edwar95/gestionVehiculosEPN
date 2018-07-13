using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Reserva
    {
        private int numeroPersonas;
        private string prioridad;
        private string fechaInicio;
        private string fechaFin;
        private Viaje viaje = new Viaje();
        

        public int NumeroPersonas
        {
            get
            {
                return numeroPersonas;
            }

            set
            {
                numeroPersonas = value;
            }
        }

        public string Prioridad
        {
            get
            {
                return prioridad;
            }

            set
            {
                prioridad = value;
            }
        }

        public string FechaInicio
        {
            get
            {
                return fechaInicio;
            }

            set
            {
                fechaInicio = value;
            }
        }

        public string FechaFin
        {
            get
            {
                return fechaFin;
            }

            set
            {
                fechaFin = value;
            }
        }

        

    }
}
