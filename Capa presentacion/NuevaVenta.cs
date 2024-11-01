using ProyectoFinalLab2.Capa_de_datos;
using ProyectoFinalLab2.Capa_logica;
using ProyectoFinalLab2.Capa_presentacion;
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
    public partial class NuevaVenta : Form
    {
        Venta venta = new Venta();
        public NuevaVenta()
        {
            InitializeComponent();
            
        }
        ProductoD prod = new ProductoD();
        private void NuevaVenta_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = prod.RellenarDG();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int a = dgvCompra.RowCount - 1;
            int b = Convert.ToInt32(TxtCantidad.Text);
            
            if (TxtCantidad.Text == "")
            {
                MessageBox.Show("Ingrese la cantidad a llevar");
            }
            else
            {
                if (lbProducto.Text == "" || lbPrecio.Text == "")
                {
                    MessageBox.Show("Seleccione el artículo");
                }
                else
                    dgvCompra.Rows.Add(lbProducto.Text, lbPrecio.Text, TxtCantidad.Text);
                    
                for(int i = 0; i<=a; i++)
                {
                    venta.precio = Convert.ToDecimal(dgvCompra[1, i].Value);
                    venta.cantidad = Convert.ToInt32(dgvCompra[2, i].Value);
                    lbTotal.Text = Convert.ToString(venta.Suma());
                }
                venta.pretotal = 0;
            }
        }
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Hide();
            menu.Show();
            
        }

        private void NuevaVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            var ok = MessageBox.Show("Presione aceptar cuando ingrese el dinero en la caja registradora, el cliente debe abonar $" + lbTotal.Text, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (ok == DialogResult.OK)
            {
                if (lbTotal.Text == "")
                {
                    MessageBox.Show("No seleccionó ningún artículo");
                }
                else
                {
                    bool stockSuficiente = true;
                    List<(int codigo, int cantidad)> productosAActualizar = new List<(int codigo, int cantidad)>();

                    foreach (DataGridViewRow row in dgvCompra.Rows)
                    {
                        if (row.Cells[0].Value != null) // Asegurarse de no procesar una fila vacía
                        {
                            string producto = row.Cells[0].Value.ToString();
                            int cantidad = Convert.ToInt32(row.Cells[2].Value);

                            // Obtener el código del producto desde dgvProductos basado en el nombre del producto
                            int codigo = ObtenerCodigoProducto(producto);

                            // Verificar si hay suficiente stock antes de intentar actualizar
                            int stockActual = prod.ObtenerStockActual(codigo);
                            if (stockActual < cantidad)
                            {
                                stockSuficiente = false;
                                MessageBox.Show("No hay suficiente stock para el producto " + producto + ". Stock disponible: " + stockActual);
                                break;
                            }
                            else
                            {
                                productosAActualizar.Add((codigo, cantidad));
                            }
                        }
                    }

                    if (stockSuficiente)
                    {
                        foreach (var (codigo, cantidad) in productosAActualizar)
                        {
                            // Actualizar el stock en la base de datos
                            prod.ActualizarStock(codigo, cantidad);
                        }

                        dgvCompra.Rows.Clear();
                        dgvProductos.DataSource= prod.RellenarDG();
                        lbTotal.Text = "0";
                        lbProducto.Text="0";
                        lbPrecio.Text="0";
                        MessageBox.Show("Compra realizada con éxito y stock actualizado.");
                    }
                }
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lbProducto.Visible = true;
                lbPrecio.Visible = true;
                lbProducto.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
                lbPrecio.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();

            }
            catch (Exception)
            {
                throw;
            }
        }

        // Método para obtener el código del producto desde dgvProductos
        private int ObtenerCodigoProducto(string nombreProducto)
        {
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (row.Cells[1].Value.ToString() == nombreProducto)
                {
                    return Convert.ToInt32(row.Cells[0].Value);
                }
            }
            return -1; // En caso de no encontrar el producto, retorna un valor inválido
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvCompra.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvCompra.SelectedRows)
                {
                    if (!row.IsNewRow) // Asegurarse de no borrar la fila nueva predeterminada
                    {
                        dgvCompra.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione el producto que desea borrar.");
            }

            // Actualizar el total después de borrar el producto
            CalcularTotal();

            void CalcularTotal()
            {
                decimal total = 0;
                foreach (DataGridViewRow row in dgvCompra.Rows)
                {
                    if (row.Cells[1].Value != null && row.Cells[2].Value != null)
                    {
                        decimal precio = Convert.ToDecimal(row.Cells[1].Value);
                        int cantidad = Convert.ToInt32(row.Cells[2].Value);
                        total += precio * cantidad;
                    }
                }
                lbTotal.Text = total.ToString();
            }
        }
    }
}
