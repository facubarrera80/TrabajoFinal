using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalLab2.Capa_logica
{
    public class Venta
    {
        public decimal pretotal, precio, preart;
        public int cantidad;
        public string prod;

        public decimal Suma()
        {
            pretotal = precio * cantidad + pretotal;
            return pretotal;
        }
    }
}
