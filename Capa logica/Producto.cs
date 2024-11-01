using ProyectoFinalLab2.Capa_de_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalLab2.Capa_logica
{
    public class Producto
    {
        public string codigo;
        public int stock;
        public decimal precio;
        public string tipo;
        ProductoD produ = new ProductoD();

        public void agregar(Producto prod)
        {
            produ.agregar(prod);
        }

        public void modificar(Producto prodd)
        {
            produ.modificar(prodd);
        }

        public void eliminar(int prode)
        {
            produ.eliminar(prode);

        }
    }
}
