using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MLCRUD.Models;
using System.Data.Entity;
using MLCRUD.Models.ViewModels;


namespace MLCRUD.Controllers
{
    public class dbController : Controller
    {
        // GET: db
        public ActionResult Index()
        {
            List<ListTablaViewModel> lst;
            using (dataMLEntities db = new dataMLEntities())
            {
                lst = (from d in db.db
                           select new ListTablaViewModel
                           {
                               Id = d.id,
                               Name = d.name,
                               Doc_type = d.doc_type,
                               Doc_num = d.doc_num,
                               Address = d.address,
                               Phone = d.phone,
                               Email = d.email,
                               Date = d.date
                           }).ToList();
            }
            return View(lst);
        }
        public ActionResult Nuevo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Nuevo(TablaViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using(dataMLEntities db = new dataMLEntities())
                    {
                        db.spInsertarUsuarios(model.Name, model.Doc_type, model.Doc_num, model.Address, model.Phone, model.Email, DateTime.Now.ToString());
                        db.SaveChanges();
                    }
                    return Redirect("~/db/");
                }
                else
                {

                    return View(model);
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public ActionResult Editar(int id)
        {
            TablaViewModel model = new TablaViewModel();
            using (dataMLEntities db = new dataMLEntities())
            {
                var oTabla = db.db.Find(id);
                model.Name = oTabla.name;
                model.Doc_type = oTabla.doc_type;
                model.Doc_num = oTabla.doc_num;
                model.Address = oTabla.address;
                model.Phone = oTabla.phone;
                model.Email = oTabla.email;

            }
            return View(model);
        }


        [HttpPost]
        public ActionResult Editar(TablaViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (dataMLEntities db = new dataMLEntities())
                    {
                        var oTabla = db.db.Find(model.Id);
                        oTabla.name = model.Name;
                        oTabla.doc_type = model.Doc_type;
                        oTabla.doc_num = model.Doc_num;
                        oTabla.address = model.Address;
                        oTabla.phone = model.Phone;
                        oTabla.email = model.Email;
                        oTabla.date = DateTime.Now.ToString();
                        db.Entry(oTabla).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                    return Redirect("~/db/");
                }
                else
                {
                    return View(model);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}