using System;
namespace Lab1.Models
{
    public class Ventas
    {
        public Ventas(int id, string des, double mon, string tip)
        {
            ID = id;
            Descripcion = des;
            Monto = mon;
            Tipo = tip;

        }

        public int ID { get; set; }
        public string Descripcion { get; set; }
        public double Monto { get; set; }
        public string Tipo { get; set; }
    }
}
