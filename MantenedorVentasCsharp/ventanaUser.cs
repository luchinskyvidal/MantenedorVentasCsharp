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
    public partial class ventanaUser : FormBase
    {
        public ventanaUser()
        {
            InitializeComponent();
        }

        private void ventanaUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ventanaUser_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM USUARIOS WHERE ID_USUARIO=" + Login.codigo;
            DataSet DS = Utilidades.Ejecutar(cmd);

            lblNombre.Text = DS.Tables[0].Rows[0]["Nom_usu"].ToString();
            lblUsuario.Text = DS.Tables[0].Rows[0]["account"].ToString();
            lblCodigo.Text = DS.Tables[0].Rows[0]["id_usuario"].ToString();

            string url = DS.Tables[0].Rows[0]["foto"].ToString();
            pictureBox1.Image = Image.FromFile(url);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal ConP = new ContenedorPrincipal();
            this.Hide();
            ConP.Show();
        }
    }
}
