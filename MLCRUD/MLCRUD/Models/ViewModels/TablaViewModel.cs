using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MLCRUD.Models.ViewModels
{
    public class TablaViewModel
    {
            public int Id { get; set; }
            [Required]
            [Display(Name = "Nombre")]
            [StringLength(50)]
            public string Name { get; set; }
            //[Required]
            [Display(Name = "Tipo de documento")]
            //[StringLength(10)]
            //[DataType(List)]
            public string Doc_type { get; set; }
            //[Required]
            [Display(Name = "Número de documento")]
            public int Doc_num { get; set; }
           // [Required]
            [Display(Name = "Dirección de residencia")]
            [StringLength(50)]
            public string Address { get; set; }
            //[Required]
            [Display(Name = "Número de celular")]
            public int Phone { get; set; }
            //[Required]
            [Display(Name = "Correo Electrónico")]
            [EmailAddress]
            public string Email { get; set; }
            //[Required]
            [Display(Name = "Fecha de registro")]
          //  [DataType(DataType.Date)]
            public string  Date { get; set; }
    }
}