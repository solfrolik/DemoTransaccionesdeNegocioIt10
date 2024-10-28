using Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class EmpleadoDAL
   {
      private readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["EmpleadosDBConnection"].ConnectionString;

      public void Crear(Empleado empleado)
      {
         using (var conexion = new SqlConnection(cadenaConexion))
         {
            conexion.Open();

            using (var comando = new SqlCommand(
                "INSERT INTO Empleado (DNI, APELLIDO_NOMBRE, SUELDO_BRUTO) VALUES (@DNI, @ApellidoNombre, @SueldoBruto);",
                conexion))
            {
               comando.Parameters.AddWithValue("@DNI", empleado.DNI);
               comando.Parameters.AddWithValue("@ApellidoNombre", empleado.ApellidoNombre);
               comando.Parameters.AddWithValue("@SueldoBruto", empleado.SueldoBruto);

               comando.ExecuteNonQuery();
            }
         }
      }

      public List<Empleado> Listar()
      {
         List<Empleado> empleados = new();

         using (var conexion = new SqlConnection(cadenaConexion))
         {
            conexion.Open();

            var transaccion = conexion.BeginTransaction(IsolationLevel.ReadUncommitted);

            using (var comando = new SqlCommand("SELECT * FROM Empleado", conexion, transaccion))
            {
               using (var adapter = new SqlDataAdapter(comando))
               {
                  var dataset = new DataSet();
                  adapter.Fill(dataset);

                  foreach (DataRow row in dataset.Tables[0].Rows)
                  {
                     Empleado empleado = new()
                     {
                        DNI = Convert.ToInt32(row["DNI"]),
                        ApellidoNombre = row["APELLIDO_NOMBRE"].ToString(),
                        SueldoBruto = Convert.ToDouble(row["SUELDO_BRUTO"])
                     };
                     empleados.Add(empleado);
                  }
               }
            }

            transaccion.Commit();
         }

         return empleados;
      }
   }
}
