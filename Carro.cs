using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoU1P2
{
    public partial class Carrocvja : Form
    {
        public Carrocvja(List<String> ListaObjetos, List<double> ListaPrecios)
        {
            InitializeComponent();
            lbcvjaProductos.DataSource = ListaObjetos;
            lbcvjaPrecios.DataSource = ListaPrecios;
        }

        private void btncvjaRegresar_Click(object sender, EventArgs e)
        {
            Program.f3.Hide();
            Program.f3 = null;
        }
    }
}
