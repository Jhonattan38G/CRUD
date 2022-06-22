using ML_Prueba.Modelo;
using ML_Prueba.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace ML_Prueba.Vista
{
    public partial class View : System.Web.UI.Page
    {
        Cliente admin = new Cliente();
        
        private void Consultar()
        {
            grilla.DataSource = admin.Consultar();
            grilla.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Consultar();
        }

        protected void gvbind()
        {
            SqlDataAdapter da = new SqlDataAdapter(admin.Editar());
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                grilla.DataSource = ds;
                grilla.DataBind();
            }
            admin.Desc();
            Consultar();
        }
        protected void grilla_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)grilla.Rows[e.RowIndex];
            Label lbldeleteid = (Label)row.FindControl("lblID");
            int A = Convert.ToInt32(grilla.DataKeys[e.RowIndex].Value.ToString());
            CreateModel modelo = new CreateModel()
            {
                Id = A
            };

            admin.Eliminar(modelo);
            gvbind();


        }
        protected void grilla_RowEditing(object sender, GridViewEditEventArgs e)
        {
            
            grilla.EditIndex = e.NewEditIndex;
            gvbind();
        }
        protected void grilla_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            
            GridViewRow row = (GridViewRow)grilla.Rows[e.RowIndex];
            Label lblID = (Label)row.FindControl("lblID");
            TextBox userid = (TextBox)row.Cells[1].Controls[0];            TextBox txtName = (TextBox)row.Cells[2].Controls[0];
            TextBox txtDocType = (TextBox)row.Cells[3].Controls[0];
            TextBox txtDocNum = (TextBox)row.Cells[4].Controls[0];
            TextBox txtDireccion = (TextBox)row.Cells[5].Controls[0];
            TextBox txtTel = (TextBox)row.Cells[6].Controls[0];
            TextBox txtCorreo = (TextBox)row.Cells[7].Controls[0];
            grilla.EditIndex = -1;

            CreateModel modelo = new CreateModel()
            {
                Id = int.Parse(userid.Text),
                Nombre = txtName.Text,
                Type_doc = txtDocType.Text,
                Num_doc = int.Parse(txtDocNum.Text),
                Direccion = txtDireccion.Text,
                Telefono = int.Parse(txtTel.Text),
                Correo = txtCorreo.Text
            };
            admin.Update(modelo);

            gvbind();
        }
        protected void grilla_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grilla.PageIndex = e.NewPageIndex;
            gvbind();
        }
        protected void grilla_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grilla.EditIndex = -1;
            gvbind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
}