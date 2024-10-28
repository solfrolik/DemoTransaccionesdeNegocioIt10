using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
   public class EmpleadoBLL
   {
      private readonly EmpleadoDAL empleadoDAL = new(); 
      private const double SALARIO_MINIMO = 100000;

      public double CalcularSueldoNeto(double sueldoBruto)
      {
         return sueldoBruto - (sueldoBruto * 0.17);
      }

      public void Crear(Empleado empleado)
      {
         using (var trx = new TransactionScope())
         {
            
            if (empleado.ApellidoNombre.Length <= 5)
               throw new Exception("El nombre y apellido deben tener más de 5 caracteres.");
            if (empleado.DNI.ToString().Length != 11)
               throw new Exception("El DNI debe tener exactamente 11 caracteres.");
            if (empleado.SueldoBruto < SALARIO_MINIMO)
               throw new Exception("El sueldo bruto no puede ser menor al salario mínimo vital y móvil.");

            empleadoDAL.Crear(empleado);
            trx.Complete();
         }
      }

      public void CrearVarios(List<Empleado> empleados)
      {
         using (var trx = new TransactionScope())
         {
            foreach (var empleado in empleados)
            {
               Crear(empleado); 

            trx.Complete();
         }
         }
      }

      public List<Empleado> Listar()
      {
         return empleadoDAL.Listar();
      }
   }
}

