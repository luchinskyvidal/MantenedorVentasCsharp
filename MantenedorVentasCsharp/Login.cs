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
using MiLibreria;


namespace MantenedorVentasCsharp
{
    public partial class Login : FormBase
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string codigo="";

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string CMD = string.Format("SELECT * FROM USUARIOS WHERE ACCOUNT='{0}' and password='{1}'", txtNomAcc.Text.Trim(), txtPass.Text.Trim());
                DataSet ds = Utilidades.Ejecutar(CMD);

                codigo = ds.Tables[0].Rows[0]["id_usuario"].ToString().Trim();

                string cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["password"].ToString().Trim();

                if (cuenta == txtNomAcc.Text.Trim() && contra == txtPass.Text.Trim())
                {
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["StatusAdmin"]) == true)
                    {
                        ventanaAdmin VentAd = new ventanaAdmin();
                        this.Hide();
                        VentAd.Show();
                    }
                    else
                    {
                        ventanaUser venUs = new ventanaUser();
                        this.Hide();
                        venUs.Show();
                    }
                }
                
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: "+error.Message);
                throw;
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
