using ML_Prueba.Modelo;
using ML_Prueba.Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

namespace ML_Prueba.Datos
{
    public class Cliente : Conexion
    {
        public void Insertar(CreateModel modelo)
        {
            Conectar();
            try
            {
                SqlCommand comando = new SqlCommand("spInsertar", cxn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.Add(new SqlParameter("@nombre", modelo.Nombre));
                comando.Parameters.Add(new SqlParameter("@doc_type", modelo.Type_doc));
                comando.Parameters.Add(new SqlParameter("@num_type", modelo.Num_doc));
                comando.Parameters.Add(new SqlParameter("@direccion", modelo.Direccion));
                comando.Parameters.Add(new SqlParameter("@telefono", modelo.Telefono));
                comando.Parameters.Add(new SqlParameter("@correo", modelo.Correo));
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.StackTrace);
            }
            finally
            {
                Desconectar();

            }
        }
        
        public List<ViewModel> Consultar()
        {
            List<ViewModel> lista = new List<ViewModel>();
            Conectar();
            try
            {
                SqlCommand comando = new SqlCommand("spConsulta", cxn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    ViewModel modelo = new ViewModel()
                    {
                        Id = int.Parse(lector[0] + ""),
                        Nombre = lector[1] + "",
                        Type_doc = lector[2] + "",
                        Num_doc = int.Parse(lector[3] + ""),
                        Direccion = lector[4] + "",
                        Telefono = int.Parse(lector[5] + ""),
                        Correo = lector[6] + "",
                        Fecha = DateTime.Parse(lector[7] + ""),
                    };
                    lista.Add(modelo);
                }
            }
            catch (Exception exp)
            {

                Console.WriteLine(exp.StackTrace);
            }
            finally
            {
                Desconectar();
            }
            return lista;
        }

        public SqlCommand Editar()
        {
            

            Conectar();
            SqlCommand comando = new SqlCommand("spConsulta", cxn);
            try
            {
                
                

            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.StackTrace);
            }
            return comando;

        }
        public void Desc() { Desconectar(); }

        public void Update(CreateModel modelo)
        {
            Conectar();
            try
            {
                SqlCommand comando = new SqlCommand("spEditar", cxn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.Add(new SqlParameter("@id", modelo.Id));
                comando.Parameters.Add(new SqlParameter("@nombre", modelo.Nombre));
                comando.Parameters.Add(new SqlParameter("@doc_type", modelo.Type_doc));
                comando.Parameters.Add(new SqlParameter("@num_type", modelo.Num_doc));
                comando.Parameters.Add(new SqlParameter("@direccion", modelo.Direccion));
                comando.Parameters.Add(new SqlParameter("@telefono", modelo.Telefono));
                comando.Parameters.Add(new SqlParameter("@correo", modelo.Correo));
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.StackTrace);
            }
            finally
            {
                Desconectar();

            }

        }
        
        public void Eliminar(CreateModel modelo)
        {
            Conectar();
            try
            {
                SqlCommand comando = new SqlCommand("spEliminar", cxn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.Add(new SqlParameter("@id", modelo.Id));
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.StackTrace);
            }
            finally
            {
                Desconectar();
            }
        }
    }
}   