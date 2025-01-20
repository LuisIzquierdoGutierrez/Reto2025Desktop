namespace Reto2025.Views
{
    partial class FrmProfesores
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
            this.lwProfesores = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellidos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Correo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EsJefeDepartamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Departamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lwProfesores
            // 
            this.lwProfesores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Apellidos,
            this.Correo,
            this.Rol,
            this.EsJefeDepartamento,
            this.Departamento});
            this.lwProfesores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lwProfesores.HideSelection = false;
            this.lwProfesores.Location = new System.Drawing.Point(0, 0);
            this.lwProfesores.Margin = new System.Windows.Forms.Padding(2);
            this.lwProfesores.Name = "lwProfesores";
            this.lwProfesores.Size = new System.Drawing.Size(800, 450);
            this.lwProfesores.TabIndex = 2;
            this.lwProfesores.UseCompatibleStateImageBehavior = false;
            this.lwProfesores.View = System.Windows.Forms.View.Details;
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
            // Rol
            // 
            this.Rol.Text = "Rol";
            // 
            // EsJefeDepartamento
            // 
            this.EsJefeDepartamento.Text = "Jefe Departamento";
            // 
            // Departamento
            // 
            this.Departamento.Text = "Departamento";
            // 
            // FrmProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lwProfesores);
            this.Name = "FrmProfesores";
            this.Text = "Profesores";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lwProfesores;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Apellidos;
        private System.Windows.Forms.ColumnHeader Correo;
        private System.Windows.Forms.ColumnHeader Rol;
        private System.Windows.Forms.ColumnHeader EsJefeDepartamento;
        private System.Windows.Forms.ColumnHeader Departamento;
    }
}