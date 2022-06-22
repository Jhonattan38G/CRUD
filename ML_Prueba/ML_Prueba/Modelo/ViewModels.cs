using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ML_Prueba.Modelo
{
    public class ViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Type_doc { get; set; }
        public int Num_doc { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }
        public DateTime Fecha { get; set; }

    }
}