namespace Reto2025.Views
{
    partial class frmControlActividades
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_fechainicio = new System.Windows.Forms.Label();
            this.lbl_fechafin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Location = new System.Drawing.Point(52, 4);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(33, 13);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Titulo";
            // 
            // lbl_fechainicio
            // 
            this.lbl_fechainicio.AutoSize = true;
            this.lbl_fechainicio.Location = new System.Drawing.Point(4, 35);
            this.lbl_fechainicio.Name = "lbl_fechainicio";
            this.lbl_fechainicio.Size = new System.Drawing.Size(68, 13);
            this.lbl_fechainicio.TabIndex = 1;
            this.lbl_fechainicio.Text = "Fecha Inicio:";
            // 
            // lbl_fechafin
            // 
            this.lbl_fechafin.AutoSize = true;
            this.lbl_fechafin.Location = new System.Drawing.Point(7, 70);
            this.lbl_fechafin.Name = "lbl_fechafin";
            this.lbl_fechafin.Size = new System.Drawing.Size(57, 13);
            this.lbl_fechafin.TabIndex = 2;
            this.lbl_fechafin.Text = "Fecha Fin:";
            // 
            // frmControlActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_fechafin);
            this.Controls.Add(this.lbl_fechainicio);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "frmControlActividades";
            this.Size = new System.Drawing.Size(200, 103);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_fechainicio;
        private System.Windows.Forms.Label lbl_fechafin;
    }
}
