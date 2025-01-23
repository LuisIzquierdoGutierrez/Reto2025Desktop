namespace Reto2025.Views
{
    partial class FrmContratoActividad
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
            this.cmbEmpresas = new System.Windows.Forms.ComboBox();
            this.cmbActividades = new System.Windows.Forms.ComboBox();
            this.nudImporte = new System.Windows.Forms.NumericUpDown();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblActividades = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.cmbIdEmpresas = new System.Windows.Forms.ComboBox();
            this.cmbIdActividades = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEmpresas
            // 
            this.cmbEmpresas.FormattingEnabled = true;
            this.cmbEmpresas.Location = new System.Drawing.Point(97, 47);
            this.cmbEmpresas.Name = "cmbEmpresas";
            this.cmbEmpresas.Size = new System.Drawing.Size(121, 21);
            this.cmbEmpresas.TabIndex = 0;
            // 
            // cmbActividades
            // 
            this.cmbActividades.FormattingEnabled = true;
            this.cmbActividades.Location = new System.Drawing.Point(502, 42);
            this.cmbActividades.Name = "cmbActividades";
            this.cmbActividades.Size = new System.Drawing.Size(251, 21);
            this.cmbActividades.TabIndex = 1;
            // 
            // nudImporte
            // 
            this.nudImporte.DecimalPlaces = 2;
            this.nudImporte.Location = new System.Drawing.Point(98, 145);
            this.nudImporte.Name = "nudImporte";
            this.nudImporte.Size = new System.Drawing.Size(120, 20);
            this.nudImporte.TabIndex = 2;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(678, 387);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(27, 50);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(53, 13);
            this.lblEmpresa.TabIndex = 6;
            this.lblEmpresa.Text = "Empresas";
            // 
            // lblActividades
            // 
            this.lblActividades.AutoSize = true;
            this.lblActividades.Location = new System.Drawing.Point(394, 45);
            this.lblActividades.Name = "lblActividades";
            this.lblActividades.Size = new System.Drawing.Size(62, 13);
            this.lblActividades.TabIndex = 7;
            this.lblActividades.Text = "Actividades";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(27, 147);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(42, 13);
            this.lblImporte.TabIndex = 8;
            this.lblImporte.Text = "Importe";
            // 
            // cmbIdEmpresas
            // 
            this.cmbIdEmpresas.FormattingEnabled = true;
            this.cmbIdEmpresas.Location = new System.Drawing.Point(97, 97);
            this.cmbIdEmpresas.Name = "cmbIdEmpresas";
            this.cmbIdEmpresas.Size = new System.Drawing.Size(121, 21);
            this.cmbIdEmpresas.TabIndex = 9;
            this.cmbIdEmpresas.Visible = false;
            // 
            // cmbIdActividades
            // 
            this.cmbIdActividades.FormattingEnabled = true;
            this.cmbIdActividades.Location = new System.Drawing.Point(502, 97);
            this.cmbIdActividades.Name = "cmbIdActividades";
            this.cmbIdActividades.Size = new System.Drawing.Size(121, 21);
            this.cmbIdActividades.TabIndex = 10;
            this.cmbIdActividades.Visible = false;
            // 
            // FrmContratoActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbIdActividades);
            this.Controls.Add(this.cmbIdEmpresas);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.lblActividades);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.nudImporte);
            this.Controls.Add(this.cmbActividades);
            this.Controls.Add(this.cmbEmpresas);
            this.Name = "FrmContratoActividad";
            this.Text = "FrmContratoActividad";
            this.Load += new System.EventHandler(this.FrmContratoActividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEmpresas;
        private System.Windows.Forms.ComboBox cmbActividades;
        private System.Windows.Forms.NumericUpDown nudImporte;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblActividades;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.ComboBox cmbIdEmpresas;
        private System.Windows.Forms.ComboBox cmbIdActividades;
    }
}