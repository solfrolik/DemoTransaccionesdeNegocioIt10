using BLL;
using Entity;

namespace TransaccionesdeNegocios_It10
{
   public partial class Form1 : Form
   {
      private EmpleadoBLL empleadoBusiness = new();
      private List<Empleado> listaEmpleados = new List<Empleado>();
      public Form1()
      {
         InitializeComponent();
      }
      private void btnAgregar_Click(object sender, EventArgs e)
      {
         try
         {

            Empleado empleado = new Empleado
            {
               ApellidoNombre = txtApellidoNombre.Text,
               DNI = long.Parse(txtDNI.Text), 
               SueldoBruto = double.Parse(txtSueldoBruto.Text)
            };

            double sueldoNeto = empleadoBusiness.CalcularSueldoNeto(empleado.SueldoBruto);
            MessageBox.Show($"El sueldo neto es: {sueldoNeto}");

            listaEmpleados.Add(empleado);
            MessageBox.Show("Empleado agregado al borrador.");

           /* txtApellidoNombre.Clear();
            txtDNI.Clear();
            txtSueldoBruto.Clear();*/
         }
         catch (Exception ex)
         {
            MessageBox.Show($"Error: {ex.Message}");
         }
      }

      private void btnConfirmar_Click(object sender, EventArgs e)
      {
         try
         {
 
            if (listaEmpleados.Count > 0)
            {
              
               empleadoBusiness.CrearVarios(listaEmpleados);

               MessageBox.Show("Empleados guardados exitosamente en la base de datos.");
               listaEmpleados.Clear();
            }
            else
            {
               MessageBox.Show("No hay empleados en la lista para confirmar.");
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show($"Error al guardar empleados: {ex.Message}");
         }
      }
      private void btnListar_Click(object sender, EventArgs e)
      {
         dgvEmpleados.DataSource = empleadoBusiness.Listar();
      }
   }
}
