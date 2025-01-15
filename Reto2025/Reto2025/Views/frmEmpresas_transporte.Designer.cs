namespace Reto2025.Views
{
    partial class frmEmpresas_transporte
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
            this.lwEmpTransporte = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Contacto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Localidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Direccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CIF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(682, 410);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 1;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // lwEmpTransporte
            // 
            this.lwEmpTransporte.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Contacto,
            this.Localidad,
            this.Direccion,
            this.CP,
            this.CIF});
            this.lwEmpTransporte.HideSelection = false;
            this.lwEmpTransporte.Location = new System.Drawing.Point(12, 12);
            this.lwEmpTransporte.Name = "lwEmpTransporte";
            this.lwEmpTransporte.Size = new System.Drawing.Size(776, 380);
            this.lwEmpTransporte.TabIndex = 2;
            this.lwEmpTransporte.UseCompatibleStateImageBehavior = false;
            this.lwEmpTransporte.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            // 
            // Contacto
            // 
            this.Contacto.Text = "Contacto";
            // 
            // Localidad
            // 
            this.Localidad.Text = "Localidad";
            // 
            // Direccion
            // 
            this.Direccion.Text = "Direccion";
            // 
            // CP
            // 
            this.CP.Text = "CP";
            // 
            // CIF
            // 
            this.CIF.Text = "CIF";
            // 
            // frmEmpresas_transporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lwEmpTransporte);
            this.Controls.Add(this.btn_volver);
            this.Name = "frmEmpresas_transporte";
            this.Text = "Empresas de transporte";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.ListView lwEmpTransporte;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Contacto;
        private System.Windows.Forms.ColumnHeader Localidad;
        private System.Windows.Forms.ColumnHeader Direccion;
        private System.Windows.Forms.ColumnHeader CP;
        private System.Windows.Forms.ColumnHeader CIF;
    }
}