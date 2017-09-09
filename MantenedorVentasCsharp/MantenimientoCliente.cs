using MiLibreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantenedorVentasCsharp
{
    public partial class MantenimientoCliente : Mantenimiento
    {
        public MantenimientoCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public override bool Guardar()
        {
            try
            {
                string cmd = string.Format("EXEC ActualizaClientes '{0}','{1}','{2}'", txtIdCli.Text.Trim(), txtNombre.Text.Trim(), txtApellido.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("se ha guardado correctamente..");
                return true;
            }
            catch (Exception error)
            {

                MessageBox.Show("Ha ocurrido un error..: " + error.Message);
                return false;
            }
        }

        public override void Eliminar()
        {
            try
            {
                string cmd = string.Format("EXEC EliminarCliente '{0}'", txtIdCli.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("se ha eliminado correctamente..");

            }
            catch (Exception error)
            {

                MessageBox.Show("Ha ocurrido un error..: " + error.Message);

            }
        }
    }
}
