using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;



namespace Lab1.Models
{
    public class PersonaModel
    {
        public PersonaModel()
        {
            lstVentas = new List<Ventas>();
            lstVentas.Add(new Ventas { ID= 1, Descripcion= "arroz", Monto= 2.3, Tipo= "comida" });
            lstVentas.Add(new Ventas { ID = 2, Descripcion = "arroz", Monto = 2.3, Tipo = "comida" });
            lstVentas.Add(new Ventas { ID = 3, Descripcion = "arroz", Monto = 2.3, Tipo = "comida" });
           
        }

        public int ID { get; set; }

        public string Nombre { get; set; }

        public string ApellidoPaterno { get; set; }

        public string ApellidoMaterno { get; set; }

        public string Foto { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Telefono { get; set; }

        public List<Ventas> lstVentas { get; set; } 







        public static async Task<ObservableCollection<PersonaModel>> ObtenerPersonas()
        {

            ObservableCollection<PersonaModel> lstPersonas = new ObservableCollection<PersonaModel>();


            lstPersonas.Add(new PersonaModel { ID = 1, Nombre = "Carlos", ApellidoPaterno = "Bejarano", ApellidoMaterno = "Alpizar", Telefono = "89667186"});
            lstPersonas.Add(new PersonaModel { ID = 2, Nombre = "Yendry", ApellidoPaterno = "Bejarano", ApellidoMaterno = "Alpizar",  Telefono = "89667186" });
            lstPersonas.Add(new PersonaModel { ID = 3, Nombre = "Natasha", ApellidoPaterno = "Bejarano", ApellidoMaterno = "Alpizar",  Telefono = "89667186" });
            lstPersonas.Add(new PersonaModel { ID = 4, Nombre = "Jose", ApellidoPaterno = "Bejarano", ApellidoMaterno = "Alpizar",  Telefono = "89667186" });
            lstPersonas.Add(new PersonaModel { ID = 5, Nombre = "Andres", ApellidoPaterno = "Bejarano", ApellidoMaterno = "Alpizar",  Telefono = "89667186" });
            lstPersonas.Add(new PersonaModel { ID = 6, Nombre = "Natalia", ApellidoPaterno = "Bejarano", ApellidoMaterno = "Alpizar",  Telefono = "89667186" });
            lstPersonas.Add(new PersonaModel { ID = 7, Nombre = "Benjamin", ApellidoPaterno = "Bejarano", ApellidoMaterno = "Alpizar",  Telefono = "89667186" });
            lstPersonas.Add(new PersonaModel { ID = 8, Nombre = "Johan", ApellidoPaterno = "Bejarano", ApellidoMaterno = "Alpizar",  Telefono = "89667186" });
            lstPersonas.Add(new PersonaModel { ID = 9, Nombre = "Marcela", ApellidoPaterno = "Bejarano", ApellidoMaterno = "Alpizar",  Telefono = "89667186" });
            lstPersonas.Add(new PersonaModel { ID = 10, Nombre = "Irene", ApellidoPaterno = "Bejarano", ApellidoMaterno = "Alpizar",  Telefono = "89667186" });

            Task.Delay(1000);


            return lstPersonas;

        }

    }
}
