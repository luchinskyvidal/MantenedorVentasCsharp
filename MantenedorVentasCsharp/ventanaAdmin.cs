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
    public partial class ventanaAdmin : FormBase
    {
        public ventanaAdmin()
        {
            InitializeComponent();
        }

        private void ventanaAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ventanaAdmin_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM USUARIOS WHERE ID_USUARIO=" + Login.codigo;
            DataSet DS = Utilidades.Ejecutar(cmd);

            lblNomAD.Text = DS.Tables[0].Rows[0]["Nom_usu"].ToString();
            lblUsA.Text = DS.Tables[0].Rows[0]["account"].ToString();
            lblCod.Text = DS.Tables[0].Rows[0]["id_usuario"].ToString();

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
