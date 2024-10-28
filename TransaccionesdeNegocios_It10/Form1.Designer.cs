namespace TransaccionesdeNegocios_It10
{
   partial class Form1
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         label1 = new Label();
         txtApellidoNombre = new TextBox();
         label2 = new Label();
         txtDNI = new TextBox();
         label3 = new Label();
         txtSueldoBruto = new TextBox();
         btnAgregar = new Button();
         btnConfirmar = new Button();
         dgvEmpleados = new DataGridView();
         ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
         SuspendLayout();
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Location = new Point(33, 99);
         label1.Name = "label1";
         label1.Size = new Size(125, 20);
         label1.TabIndex = 0;
         label1.Text = "Apellido Nombre";
         // 
         // txtApellidoNombre
         // 
         txtApellidoNombre.Location = new Point(178, 99);
         txtApellidoNombre.Name = "txtApellidoNombre";
         txtApellidoNombre.Size = new Size(125, 27);
         txtApellidoNombre.TabIndex = 1;
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.Location = new Point(123, 175);
         label2.Name = "label2";
         label2.Size = new Size(35, 20);
         label2.TabIndex = 2;
         label2.Text = "DNI";
         // 
         // txtDNI
         // 
         txtDNI.Location = new Point(178, 172);
         txtDNI.Name = "txtDNI";
         txtDNI.Size = new Size(125, 27);
         txtDNI.TabIndex = 3;
         // 
         // label3
         // 
         label3.AutoSize = true;
         label3.Location = new Point(63, 235);
         label3.Name = "label3";
         label3.Size = new Size(95, 20);
         label3.TabIndex = 4;
         label3.Text = "Sueldo Bruto";
         // 
         // txtSueldoBruto
         // 
         txtSueldoBruto.Location = new Point(178, 235);
         txtSueldoBruto.Name = "txtSueldoBruto";
         txtSueldoBruto.Size = new Size(125, 27);
         txtSueldoBruto.TabIndex = 5;
         // 
         // btnAgregar
         // 
         btnAgregar.Location = new Point(33, 310);
         btnAgregar.Name = "btnAgregar";
         btnAgregar.Size = new Size(101, 29);
         btnAgregar.TabIndex = 6;
         btnAgregar.Text = "AGREGAR";
         btnAgregar.UseVisualStyleBackColor = true;
         btnAgregar.Click += btnAgregar_Click;
         // 
         // btnConfirmar
         // 
         btnConfirmar.Location = new Point(207, 310);
         btnConfirmar.Name = "btnConfirmar";
         btnConfirmar.Size = new Size(121, 29);
         btnConfirmar.TabIndex = 7;
         btnConfirmar.Text = "CONFIRMAR";
         btnConfirmar.UseVisualStyleBackColor = true;
         btnConfirmar.Click += btnConfirmar_Click;
         // 
         // dgvEmpleados
         // 
         dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dgvEmpleados.Location = new Point(360, 50);
         dgvEmpleados.Name = "dgvEmpleados";
         dgvEmpleados.RowHeadersWidth = 51;
         dgvEmpleados.Size = new Size(411, 289);
         dgvEmpleados.TabIndex = 8;
         // 
         // Form1
         // 
         AutoScaleDimensions = new SizeF(8F, 20F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(800, 450);
         Controls.Add(dgvEmpleados);
         Controls.Add(btnConfirmar);
         Controls.Add(btnAgregar);
         Controls.Add(txtSueldoBruto);
         Controls.Add(label3);
         Controls.Add(txtDNI);
         Controls.Add(label2);
         Controls.Add(txtApellidoNombre);
         Controls.Add(label1);
         Name = "Form1";
         Text = "Form1";
         ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private Label label1;
      private TextBox txtApellidoNombre;
      private Label label2;
      private TextBox txtDNI;
      private Label label3;
      private TextBox txtSueldoBruto;
      private Button btnAgregar;
      private Button btnConfirmar;
      private DataGridView dgvEmpleados;
   }
}
