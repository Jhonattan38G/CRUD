//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MLCRUD.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dataMLEntities : DbContext
    {
        public dataMLEntities()
            : base("name=dataMLEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<db> db { get; set; }
    
        public virtual int spInsertarUsuarios(string name, string doc_type, Nullable<int> doc_num, string address, Nullable<int> phone, string email, string date)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var doc_typeParameter = doc_type != null ?
                new ObjectParameter("doc_type", doc_type) :
                new ObjectParameter("doc_type", typeof(string));
    
            var doc_numParameter = doc_num.HasValue ?
                new ObjectParameter("doc_num", doc_num) :
                new ObjectParameter("doc_num", typeof(int));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            var phoneParameter = phone.HasValue ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(int));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var dateParameter = date != null ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertarUsuarios", nameParameter, doc_typeParameter, doc_numParameter, addressParameter, phoneParameter, emailParameter, dateParameter);
        }
    }
}
