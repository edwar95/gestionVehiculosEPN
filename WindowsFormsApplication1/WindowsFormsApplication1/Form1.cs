using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Reserva reserva = new Reserva();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tipoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void reservacion_Click(object sender, EventArgs e)
        {
            reserva.NumeroPersonas = Convert.ToInt32(numPersonas.Value);
            if (tipoUsr.GetItemText(tipoUsr.SelectedItem) == "Usuario Común")
            {
                reserva.Prioridad = "1";
            }
            else
            {
                reserva.Prioridad = "2";
            }
            reserva.FechaInicio = fechaIni.Value.ToString("yyyy-MM-dd");
            reserva.FechaFin = fechaFinaliza.Value.ToString("yyyy-MM-dd");
        }
    }
}
