using ML_Prueba.Datos;
using ML_Prueba.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ML_Prueba.Vista
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Cliente admin = new Cliente();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            CreateModel modelo = new CreateModel()
            {
                Nombre = txtNombre.Text,
                Type_doc = dpwCedula.Text,
                Num_doc = int.Parse(txtCedula.Text),
                Direccion = txtDireccion.Text,
                Telefono = int.Parse(txtTelefono.Text),
                Correo = txtCorreo.Text
            };
            admin.Insertar(modelo);
            Response.Redirect("View.aspx");
        }
    }
}