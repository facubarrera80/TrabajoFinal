using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalLab2.Capa_presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            NuevaVenta nv = new NuevaVenta();
            nv.Show();
            this.Hide();
        }

        private void BtnCRUD_Click(object sender, EventArgs e)
        {
            this.Hide(); // Esconder la ventana de menu principal
            CRUD crud = new CRUD();
            crud.Show(); // Mostrar la ventana de productos
        }

        private void BtnAltaUsuario_Click(object sender, EventArgs e)
        {
            Alta_de_usuario adu = new Alta_de_usuario();
            adu.Show();
            this.Hide();
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
