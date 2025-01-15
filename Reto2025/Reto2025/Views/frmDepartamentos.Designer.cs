namespace Reto2025.Views
{
    partial class frmDepartamentos
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
            this.lwDepartamentos = new System.Windows.Forms.ListView();
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(691, 412);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 1;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // lwDepartamentos
            // 
            this.lwDepartamentos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo,
            this.Nombre});
            this.lwDepartamentos.HideSelection = false;
            this.lwDepartamentos.Location = new System.Drawing.Point(12, 12);
            this.lwDepartamentos.Name = "lwDepartamentos";
            this.lwDepartamentos.Size = new System.Drawing.Size(776, 385);
            this.lwDepartamentos.TabIndex = 2;
            this.lwDepartamentos.UseCompatibleStateImageBehavior = false;
            this.lwDepartamentos.View = System.Windows.Forms.View.Details;
            // 
            // codigo
            // 
            this.codigo.Text = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            // 
            // frmDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lwDepartamentos);
            this.Controls.Add(this.btn_volver);
            this.Name = "frmDepartamentos";
            this.Text = "Departamentos";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.ListView lwDepartamentos;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader Nombre;
    }
}