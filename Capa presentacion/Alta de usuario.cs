using ProyectoFinalLab2.Capa_de_datos;
using ProyectoFinalLab2.Capa_logica;
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
    public partial class Alta_de_usuario : Form
    {
        Usuario us = new Usuario();
        UsuarioD usd = new UsuarioD();
        public Alta_de_usuario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(TxtContraseña.Text == "" || TxtUser.Text == "")
            {
                MessageBox.Show("Ingrese el nombre de usuario y/o la contraseña", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            us.registrarU(recinfo());
        }
        public Usuario recinfo()
        {
            us.user = TxtUser.Text;
            us.contraseña = TxtContraseña.Text;
            us.nombre = TxtNombre.Text;
            return us;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var se = MessageBox.Show("Seguro desea cancelar? En caso de hacer click en Ok regresará al menú principal", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (se == DialogResult.OK)
            {
                MenuPrincipal men = new MenuPrincipal();
                men.Show();
                this.Hide();
            }
        }

        private void Alta_de_usuario_Load(object sender, EventArgs e)
        {
            dgvListaEmpleados.DataSource = usd.Rellenar();
        }

        private void dgvListaEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtNombre.Text = dgvListaEmpleados.CurrentRow.Cells[0].Value.ToString();
                TxtUser.Text = dgvListaEmpleados.CurrentRow.Cells[1].Value.ToString();
                TxtContraseña.Text = dgvListaEmpleados.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(TxtNombre.Text == "" || TxtContraseña.Text == "" || TxtUser.Text == "")
            {
                MessageBox.Show("Seleccione el empleado a eliminar");
            }
            else
            {
                us.eliminar(recinfo());
                dgvListaEmpleados.DataSource = usd.Rellenar();
            }
        }

        private void dgvListaEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
