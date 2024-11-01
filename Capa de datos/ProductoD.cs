using ProyectoFinalLab2.Capa_logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalLab2.Capa_de_datos
{
    public class ProductoD
    {
        SqlConnection cnx = new SqlConnection("server=FACUNDO-WIN11\\MSSQLSERVER01;database=DBPanaderia; integrated security=true");

        public void agregar(Producto prod)
        {
            cnx.Open();

            // Genero mi consulta hacia la base de datos
            string cadena = "INSERT INTO Productos(Codigo,Producto,Precio,Stock) VALUES ('" + prod.codigo + "','" + prod.tipo + "','" + prod.precio + "','" + prod.stock + "')";
            
            // Ejecuto la consulta
            SqlCommand cmd = new SqlCommand(cadena, cnx);
            cmd.ExecuteNonQuery();

            // Le aviso al usuario que el producto se añadio correctamente
            MessageBox.Show("Producto guardado correctamente");
            cnx.Close();

        }

        public DataTable RellenarDG()
        {
            string consulta = "Select Codigo,Producto,Precio,Stock from Productos";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cnx);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }
        
       
        public void modificar(Producto produ)
        {
            try // TRY significa INTENTAR
            {
                cnx.Open();

                // Consulta SQL
                string caden = "UPDATE Productos SET Codigo = '" + produ.codigo + "', Producto = '" + produ.tipo + "', Precio = '" + produ.precio + "', Stock = '" + produ.stock + "' WHERE Codigo = '"+produ.codigo+"'"; // Modifico UNA SOLA FILA
                
                // Ejecuto la consulta SQL
                SqlCommand cmd = new SqlCommand(caden, cnx);
                cmd.ExecuteNonQuery();

                // Le aviso al usuario que se modifico correctamente
                MessageBox.Show("El producto fue modificado correctamente");
                cnx.Close();
            }
            catch (Exception ex) // CATCH significa AGARRAR, Agarro el error y le aviso al usuario
            {
                MessageBox.Show("No se pudo modificar el producto" + ex.ToString());
                throw;
            }
        }

        public void eliminar(int prode)
        {
            try
            {
                
                string eliminar = "Delete from Productos where codigo=@Codigo";
                cnx.Open();
                SqlCommand cm2 = new SqlCommand(eliminar, cnx);
                cm2.Parameters.AddWithValue("@Codigo", prode);
                cm2.ExecuteNonQuery();
                cnx.Close();
                MessageBox.Show("El producto fue eliminado con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el producto" + ex.ToString());
                throw;
            }
            
        }

        public int ObtenerStockActual(int codigo)
        {
            try
            {
                cnx.Open();
                string cadena = "SELECT Stock FROM Productos WHERE Codigo = @Codigo";
                SqlCommand cmd = new SqlCommand(cadena, cnx);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                int stockActual = (int)cmd.ExecuteScalar();
                cnx.Close();
                return stockActual;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener el stock actual: " + ex.ToString());
                throw;
            }
        }

        public void ActualizarStock(int codigo, int cantidad)
        {
            try
            {
                cnx.Open();
                string cadena = "UPDATE Productos SET Stock = Stock - @Cantidad WHERE Codigo = @Codigo";
                SqlCommand cmd = new SqlCommand(cadena, cnx);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                cmd.ExecuteNonQuery();
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar el stock: " + ex.ToString());
                throw;
            }
        }




    }
}