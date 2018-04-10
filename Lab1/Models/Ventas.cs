using System;
namespace Lab1.Models
{
    public class Ventas
    {
        public Ventas()
        {

        }

        public int ID { get; set; }
        public string Descripcion { get; set; }
        public double Monto { get; set; }
        public string Tipo { get; set; }
    }
}
