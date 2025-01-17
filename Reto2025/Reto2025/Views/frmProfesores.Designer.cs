namespace Reto2025.Views
{
    partial class frmProfesores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_volver = new System.Windows.Forms.Button();
            this.lwProfesores = new System.Windows.Forms.ListView();
            this.Dni_Profesor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellidos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Correo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Activo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Url_Foto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Es_Jefe_Departamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id_Departamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(931, 503);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(100, 28);
            this.btn_volver.TabIndex = 1;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // lwProfesores
            // 
            this.lwProfesores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Dni_Profesor,
            this.Nombre,
            this.Apellidos,
            this.Correo,
            this.Password,
            this.Rol,
            this.Activo,
            this.Url_Foto,
            this.Es_Jefe_Departamento,
            this.Id_Departamento});
            this.lwProfesores.HideSelection = false;
            this.lwProfesores.Location = new System.Drawing.Point(12, 21);
            this.lwProfesores.Name = "lwProfesores";
            this.lwProfesores.Size = new System.Drawing.Size(1033, 464);
            this.lwProfesores.TabIndex = 2;
            this.lwProfesores.UseCompatibleStateImageBehavior = false;
            this.lwProfesores.View = System.Windows.Forms.View.Details;
            // 
            // Dni_Profesor
            // 
            this.Dni_Profesor.Text = "Dni";
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            // 
            // Apellidos
            // 
            this.Apellidos.Text = "Apellidos";
            // 
            // Correo
            // 
            this.Correo.Text = "Correo";
            // 
            // Password
            // 
            this.Password.Text = "Password";
            // 
            // Rol
            // 
            this.Rol.Text = "Rol";
            // 
            // Activo
            // 
            this.Activo.Text = "Activo";
            // 
            // Url_Foto
            // 
            this.Url_Foto.Text = "Url Foto";
            // 
            // Es_Jefe_Departamento
            // 
            this.Es_Jefe_Departamento.Text = "Jefe Departamento";
            // 
            // Id_Departamento
            // 
            this.Id_Departamento.Text = "Id Departamento";
            // 
            // frmProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lwProfesores);
            this.Controls.Add(this.btn_volver);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmProfesores";
            this.Text = "Profesores";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.ListView lwProfesores;
        private System.Windows.Forms.ColumnHeader Dni_Profesor;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Apellidos;
        private System.Windows.Forms.ColumnHeader Correo;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader Rol;
        private System.Windows.Forms.ColumnHeader Activo;
        private System.Windows.Forms.ColumnHeader Url_Foto;
        private System.Windows.Forms.ColumnHeader Es_Jefe_Departamento;
        private System.Windows.Forms.ColumnHeader Id_Departamento;
    }
}