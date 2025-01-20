namespace Reto2025.Views
{
    partial class FrmControlCalendario
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
            this.lbl_dia = new System.Windows.Forms.Label();
            this.lbl_evento = new System.Windows.Forms.Label();
            this.lbl_idsActividades = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_dia
            // 
            this.lbl_dia.AutoSize = true;
            this.lbl_dia.Location = new System.Drawing.Point(3, 9);
            this.lbl_dia.Name = "lbl_dia";
            this.lbl_dia.Size = new System.Drawing.Size(19, 13);
            this.lbl_dia.TabIndex = 0;
            this.lbl_dia.Text = "00";
            // 
            // lbl_evento
            // 
            this.lbl_evento.AutoSize = true;
            this.lbl_evento.Location = new System.Drawing.Point(3, 59);
            this.lbl_evento.Name = "lbl_evento";
            this.lbl_evento.Size = new System.Drawing.Size(0, 16);
            this.lbl_evento.TabIndex = 1;
            this.lbl_evento.UseCompatibleTextRendering = true;
            // 
            // lbl_idsActividades
            // 
            this.lbl_idsActividades.AutoSize = true;
            this.lbl_idsActividades.Location = new System.Drawing.Point(70, 9);
            this.lbl_idsActividades.Name = "lbl_idsActividades";
            this.lbl_idsActividades.Size = new System.Drawing.Size(35, 13);
            this.lbl_idsActividades.TabIndex = 2;
            this.lbl_idsActividades.Text = "label1";
            this.lbl_idsActividades.Visible = false;
            // 
            // FrmControlCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_idsActividades);
            this.Controls.Add(this.lbl_evento);
            this.Controls.Add(this.lbl_dia);
            this.Name = "FrmControlCalendario";
            this.Size = new System.Drawing.Size(125, 88);
            this.Click += new System.EventHandler(this.frmControlCalendario_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dia;
        private System.Windows.Forms.Label lbl_evento;
        private System.Windows.Forms.Label lbl_idsActividades;
    }
}
