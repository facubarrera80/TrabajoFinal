using ProyectoFinalLab2.Capa_de_datos;
using ProyectoFinalLab2.Capa_logica;
using ProyectoFinalLab2.Capa_presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalLab2
{
    public partial class Form1 : Form
    {
        Usuario us = new Usuario();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var c = MessageBox.Show("Seguro desea cancelar el ingreso?", "Atención",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (c == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            us.comprobarU(recinfo());
            if(UsuarioD.e == 1)
            {
                
                this.Hide();
            }
            UsuarioD.e = 0;
        }

        
        private Usuario recinfo()
        {
            us.user = txtUsuario.Text;
            us.contraseña = txtContraseña.Text;
            return us;
        }

        
    }
}
