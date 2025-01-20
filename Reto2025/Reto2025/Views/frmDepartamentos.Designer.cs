namespace Reto2025.Views
{
    partial class FrmDepartamentos
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
            this.lwDepartamentos = new System.Windows.Forms.ListView();
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lwDepartamentos
            // 
            this.lwDepartamentos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo,
            this.Nombre});
            this.lwDepartamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lwDepartamentos.HideSelection = false;
            this.lwDepartamentos.Location = new System.Drawing.Point(0, 0);
            this.lwDepartamentos.Name = "lwDepartamentos";
            this.lwDepartamentos.Size = new System.Drawing.Size(184, 211);
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
            // FrmDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 211);
            this.Controls.Add(this.lwDepartamentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(200, 250);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 250);
            this.Name = "FrmDepartamentos";
            this.Text = "Departamentos";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lwDepartamentos;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader Nombre;
    }
}