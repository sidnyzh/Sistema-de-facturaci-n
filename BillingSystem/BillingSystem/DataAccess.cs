using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace BillingSystem
{
    public class DataAccess
    {
        SqlConnection conexion; // se define la variable para la conexión de tipo SqlConnection
        SqlCommand cmd; // se defie la variable para realizar comandos en la BD
        SqlDataReader LectorDatos = null;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        public void AbrirBd() // método para abrir la base de datos
        {
            try // permite captura de un error en caso que se presente
            {
                // creamos un objeto de tipo conexión a la base de datos y se pasa como parámetro la cadena de conexión
                conexion = new SqlConnection("Server=AFDGRTR45\\MSSQLSERVER1;Database=DBFACTURAS;Trusted_Connection=True;");
            conexion.Open(); // invocamos método para abrir la base de datos
            }
            catch (Exception ex)// si hay error presenta el siguiente mensaje
            {
                MessageBox.Show("falló conexión " + ex);
            }
        }
        public void CerrarBd() // método para cerrar la base de datos
        {
            try // permite captura de un error en caso que se presente
            {
                conexion.Close(); // invocamos método para cerrar la base de datos
            }
            catch (Exception ex)// si hay error presenta el siguiente mensaje
            {
                MessageBox.Show("falló cerrar conexión " + ex);
            }
        }

        // ============== Método para validar el ingreso del usuario al sistema ===============================
        public string ValidarUsuario(string StrUsuario, string StrClave)
        {
            try
            {
                string strEmpleado = "";

                string sentencia = $"select e.strNombre, e.IdRolEmpleado from TBLSEGURIDAD s JOIN TBLEMPLEADO e ON s.IdEmpleado = e.IdEmpleado where StrUsuario = '{StrUsuario}' and StrClave = '{StrClave}'";
                AbrirBd();
                cmd = new SqlCommand();
                // utilizamos las propiedades de SqlCommand esta es una forma extendidas con mas parámetros decontrol
                cmd.Connection = conexion;
                cmd.CommandText = sentencia;
                cmd.CommandType = CommandType.Text; // otros tipos son :CommandType.StoredProcedureCommandType.TableDirect
                cmd.CommandTimeout = 10;
                LectorDatos = cmd.ExecuteReader(); // ejecuta y retorna un conjunto de datos no actualizable
                while (LectorDatos.Read()) // recorremos los datos consultados
                {
                    strEmpleado = Convert.ToString(LectorDatos.GetValue(0));
                }
                if (LectorDatos != null) // cerramos el lector de datos
                {
                    LectorDatos.Close();
                }
                return strEmpleado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("FALLA LECTURA: " + ex.Message);
                return "";
            }
        }

        public string EjecutarComando(string sentencia)
        {
            string salida = "LOS DATOS SE ACTUALIZARON SATISF*CTORIN4ENTE1";
            try
            {
                int retornado;
                AbrirBd();
                cmd = new SqlCommand(sentencia, conexion);
                retornado = cmd.ExecuteNonQuery(); 
            CerrarBd();
                if (retornado > 0)
                {
                    salida = "Los datos fueron Actualizados";
                }
                else
                {
                    salida = "Los datos no fueron Actualizados";
                }
            }
            catch (Exception ex)
            {
                salida = "Falló inserción: " + ex; 
            }
            return salida; 
            }

        public DataTable CargarTabla(string tabla, string strCondicion)
        {
            try
            {
                // Aseguramos que la conexión está abierta
                AbrirBd();

                // Construcción segura de la consulta
                string sql = $"SELECT * FROM {tabla} {strCondicion}";

                using (SqlDataAdapter da = new SqlDataAdapter(sql, conexion))
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds, tabla);

                    // Verificamos que la tabla exista antes de retornarla
                    if (ds.Tables.Contains(tabla))
                    {
                        return ds.Tables[tabla];
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la tabla en el DataSet.");
                        return new DataTable();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR EN LA CONSULTA: " + ex.Message);
                return null;
            }
            finally
            {
                CerrarBd(); // Asegura que la conexión siempre se cierre
            }
        }

        public DataTable EjecutarComandoDatos(string cmd)
        {
            try
            {
                AbrirBd(); // Asegurar que la conexión se abre correctamente

                using (SqlDataAdapter da = new SqlDataAdapter(cmd, conexion))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ FALLO OPERACIÓN: " + ex.Message);
                return null;
            }
            finally
            {
                CerrarBd(); // Asegurar que la conexión se cierre siempre
            }
        }


    }
}
