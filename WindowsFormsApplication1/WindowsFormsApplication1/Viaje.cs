using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Viaje
    {
        private string tipoVehiculo;
        private string chofer;

        public string TipoVehiculo
        {
            get
            {
                return tipoVehiculo;
            }

            set
            {
                tipoVehiculo = value;
            }
        }

        public string Chofer
        {
            get
            {
                return chofer;
            }

            set
            {
                chofer = value;
            }
        }

        private bool verificarDisponibilidadVehiculo(){


            return false;
        }

        public void asignarChofer()
        {
            Chofer chofer = new Chofer();
            int cont = 0;

            if (this.NumeroPersonas <= 5)
            {

                foreach (string line in File.ReadLines(@"Choferes.txt"))
                {
                    Char delimiter = ';';
                    String[] substrings = line.Split(delimiter);

                    if (substrings[1] == "B" && cont == 0)
                    {
                        chofer.NombreChofer = substrings[0];
                        cont += 1;
                    }

                }
            }
            else if (this.NumeroPersonas > 5)
            {

                foreach (string line in File.ReadLines(@"Choferes.txt"))
                {
                    Char delimiter = ';';
                    String[] substrings = line.Split(delimiter);

                    if (substrings[1] == "C" && cont == 0)
                    {
                        chofer.NombreChofer = substrings[0];
                        cont += 1;
                    }

                }
            }
            Console.WriteLine(chofer.NombreChofer);


        }
    }
}
