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
    public partial class CRUD : Form
    {
        Producto prod = new Producto();
        ProductoD proDatos = new ProductoD();
        public CRUD()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtCodigo.Text == "" || TxtPrecio.Text == "" || TxtProducto.Text == "" || TxtStock.Text == "") // || significa ó
            {
                // Si el usuario no ingreso algun dato, le aviso para que lo agregue
                MessageBox.Show("Ingrese los datos del producto a agregar");
            }
            else
            {
                // Si no falta ningun dato, agrego el producto a la base de datos
                prod.agregar(recinform());
                dgvCrud.DataSource = proDatos.RellenarDG();
                limpiartxt();
            }
            
        }

        public Producto recinform()
        {
            // Junto todos los datos en una sola clase

            prod.codigo = TxtCodigo.Text;
            prod.precio = Convert.ToDecimal(TxtPrecio.Text);
            prod.tipo = TxtProducto.Text;
            prod.stock = Convert.ToInt32(TxtStock.Text);
            return prod;
            
        }

        private void CRUD_Load(object sender, EventArgs e)
        {
            dgvCrud.DataSource=proDatos.RellenarDG();

        }

        

        private void CRUD_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            
            if(TxtCodigo.Text == "")
            {
                MessageBox.Show("Ingrese el código del producto a eliminar");
            }else
            prod.eliminar(Convert.ToInt32(TxtCodigo.Text));
            dgvCrud.DataSource = proDatos.RellenarDG();

        }

       
        private void limpiartxt()
        {
            TxtCodigo.Text = "";
            TxtPrecio.Text = "";
            TxtProducto.Text = "";
            TxtStock.Text = "";
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if(TxtCodigo.Text == "" || TxtPrecio.Text == "" || TxtProducto.Text == "" || TxtStock.Text == "")
            {
                MessageBox.Show("Ingrese los datos del producto a modificar");
            }
            else
            {
                prod.modificar(recinform());
                dgvCrud.DataSource = proDatos.RellenarDG(); // Una vez que se modifico el producto, actualizar la tabla
                limpiartxt();
            }
        }
                

        // VALIDACIÓN SOLO NÚMEROS CODIGO ASCII
        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TxtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Hide();
            menu.Show();
        }

        private void dgvCrud_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtCodigo.Text = dgvCrud.CurrentRow.Cells[0].Value.ToString();
                TxtProducto.Text = dgvCrud.CurrentRow.Cells[1].Value.ToString();
                TxtPrecio.Text = dgvCrud.CurrentRow.Cells[2].Value.ToString();
                TxtStock.Text = dgvCrud.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
