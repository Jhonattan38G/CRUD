using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MLCRUD.Models.ViewModels
{
    public class ListTablaViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Doc_type { get; set; }
        public int Doc_num { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Date { get; set; }
    }
}