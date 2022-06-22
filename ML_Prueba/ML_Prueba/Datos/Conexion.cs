using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ML_Prueba.Datos
{
    public class Conexion
    {
        protected SqlConnection cxn;
        protected void Conectar()
        {
            try
            {
                cxn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\jhona\\source\\repos\\ML_Prueba\\ML_Prueba\\App_Data\\dbML.mdf;Integrated Security=True");
                cxn.Open();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.StackTrace);
            }
        }
        protected void Desconectar()
        {
            try
            {
                cxn.Close();
                cxn.Dispose();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.StackTrace);
            }
        }


    }
}