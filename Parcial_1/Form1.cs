using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Parcial_1
{
    public partial class Form1 : Form
    {
        private SqlConnection Conexion = new SqlConnection("server=DESKTOP-DHSOO9J\\SQLEXPRESS01; database=RegistroEstudiante ; integrated security = true");
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("server=DESKTOP-DHSOO9J\\SQLEXPRESS01; database=RegistroEstudiante ; integrated security = true");
            Conexion.Open();
            MessageBox.Show("Se abrio la conexion con el servidor Sql Server y se selecciono la base de datos");
            Conexion.Close();
            MessageBox.Show("Se cerro la conexion");



        }

        private void insertarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //INSERTAR DATOS
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();

        }

        private void mostrarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            form3.Show();
        }

        private void eliminarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.MdiParent = this;
            form4.Show();

        }

        private void editarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.MdiParent = this;
            form5.Show();
        }
    }
}
