using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ML_Prueba.Modelo
{
    public class CreateModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        public string Type_doc { get; set; }
        [Required]
        public int Num_doc { get; set; }
        [StringLength(30)]
        public string Direccion { get; set; }
        [Required]
        public int Telefono { get; set; }
        [EmailAddress]
        public string Correo { get; set; }
        public DateTime Fecha { get; set; }
    }
}