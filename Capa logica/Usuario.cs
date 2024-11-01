using ProyectoFinalLab2.Capa_de_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalLab2.Capa_logica
{
    public class Usuario
    {
        public string user, contraseña, nombre;
        UsuarioD use = new UsuarioD();

        public void comprobarU(Usuario usuario)
        {
            
            use.comprobar(usuario);
        }

        public void registrarU(Usuario usuario) 
        {
            use.registrar(usuario);
        }
    }
}
