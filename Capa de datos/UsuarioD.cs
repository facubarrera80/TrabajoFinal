using ProyectoFinalLab2.Capa_logica;
using ProyectoFinalLab2.Capa_presentacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalLab2.Capa_de_datos
{
    public class UsuarioD
    {
        SqlConnection cnx = new SqlConnection("server=FACUNDO-WIN11\\MSSQLSERVER01;database=DBPanaderia; integrated security=true");
        public static int e;
        public void comprobar(Usuario usar)
        {
            cnx.Open();
            // Defino la consulta que le haré a la tabla
            string consulta = "SELECT * FROM usuarios WHERE usuario ='"+usar.user+"' and contraseña ='"+usar.contraseña+"'";

            // Le mando la consulta a la tabla
            SqlCommand cmd = new SqlCommand(consulta, cnx);

            // Leo la respuesta de la tabla
            SqlDataReader lector;
            lector = cmd.ExecuteReader();
            if (lector.HasRows == true) // HasRows -> TieneFilas
            {
                // Si el usuario existe y la contraseña esta bien, se ejecuta esta parte del código
                MenuPrincipal menu = new MenuPrincipal();
                menu.Show(); // Mostrar menu principal
                e = 1;   
            }
            else
            {
                // Si el usuario ingreso datos incorrectos, le aviso que no ingreso bien los datos
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
            cnx.Close();
        }
        public void registrar(Usuario user1)
        {
            cnx.Open();
            string consulta = "Select * from usuarios where usuario ='" + user1.user + "' and contraseña ='" + user1.contraseña + "'";
            SqlCommand cmd = new SqlCommand(consulta, cnx);
            SqlDataReader lector;
            lector = cmd.ExecuteReader();
            if (lector.HasRows == true)
            {
                MessageBox.Show("El usuario ya se encuentra registrado, pruebe con otro nombre de usuario", "Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                cnx.Close();
                cnx.Open();
                string consulta2 = "Insert into usuarios(usuario, contraseña,nombre) values('" + user1.user + "','" + user1.contraseña + "','"+user1.nombre+"')";
                SqlCommand cmd2 = new SqlCommand(consulta2, cnx);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Usuario registrado con éxito!");
                Alta_de_usuario.ActiveForm.Hide();
                MenuPrincipal men = new MenuPrincipal();
                men.Show();
            }
            cnx.Close();
        }

        public DataTable Rellenar()
        {
            string consulta = "Select nombre, usuario, contraseña from Usuarios";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cnx);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }
        public void eliminarU(Usuario user1)
        {
            try
            {

                string eliminar = "Delete from Usuarios where Usuario='"+user1.user+"'";
                cnx.Open();
                SqlCommand cm2 = new SqlCommand(eliminar, cnx);
                cm2.Parameters.AddWithValue("@Usuario", user1.user);
                cm2.ExecuteNonQuery();
                cnx.Close();
                MessageBox.Show("El empleado fue eliminado con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar al empleado" + ex.ToString());
                throw;
            }
        }
    }
}
