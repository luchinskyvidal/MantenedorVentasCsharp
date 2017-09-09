using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;

namespace MantenedorVentasCsharp
{
    public partial class MantenimientoProductos : Mantenimiento
    {
        public MantenimientoProductos()
        {
            InitializeComponent();
        }

        private void MantenimientoProductos_Load(object sender, EventArgs e)
        {

        }

        public override bool Guardar()
        {
            try
            {
                string cmd = string.Format("EXEC ActualizaArticulo '{0}','{1}','{2}'", txtIdPro.Text.Trim(),txtDesc.Text.Trim(),txtPrecio.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("se ha guardado correctamente..");
                return true;
            }
            catch (Exception error)
            {

                MessageBox.Show("Ha ocurrido un error..: "+ error.Message);
                return false;
            }
        }

        public override void Eliminar()
        {
            try
            {
                string cmd = string.Format("EXEC EliminarArticulo '{0}'", txtIdPro.Text.Trim());
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
