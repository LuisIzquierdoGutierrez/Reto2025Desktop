namespace Reto2025.Views
{
    partial class FrmContrato_transporte
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
            this.lbl_actividad = new System.Windows.Forms.Label();
            this.lbl_importe = new System.Windows.Forms.Label();
            this.lbl_empresa = new System.Windows.Forms.Label();
            this.lnklbl_presupuesto = new System.Windows.Forms.LinkLabel();
            this.lnklbl_factura = new System.Windows.Forms.LinkLabel();
            this.btn_crear = new System.Windows.Forms.Button();
            this.cmbActividad = new System.Windows.Forms.ComboBox();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.mudImporte = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.mudImporte)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_actividad
            // 
            this.lbl_actividad.AutoSize = true;
            this.lbl_actividad.Location = new System.Drawing.Point(43, 46);
            this.lbl_actividad.Name = "lbl_actividad";
            this.lbl_actividad.Size = new System.Drawing.Size(51, 13);
            this.lbl_actividad.TabIndex = 1;
            this.lbl_actividad.Text = "Actividad";
            // 
            // lbl_importe
            // 
            this.lbl_importe.AutoSize = true;
            this.lbl_importe.Location = new System.Drawing.Point(43, 131);
            this.lbl_importe.Name = "lbl_importe";
            this.lbl_importe.Size = new System.Drawing.Size(42, 13);
            this.lbl_importe.TabIndex = 13;
            this.lbl_importe.Text = "Importe";
            // 
            // lbl_empresa
            // 
            this.lbl_empresa.AutoSize = true;
            this.lbl_empresa.Location = new System.Drawing.Point(43, 89);
            this.lbl_empresa.Name = "lbl_empresa";
            this.lbl_empresa.Size = new System.Drawing.Size(48, 13);
            this.lbl_empresa.TabIndex = 15;
            this.lbl_empresa.Text = "Empresa";
            // 
            // lnklbl_presupuesto
            // 
            this.lnklbl_presupuesto.AutoSize = true;
            this.lnklbl_presupuesto.Location = new System.Drawing.Point(380, 65);
            this.lnklbl_presupuesto.Name = "lnklbl_presupuesto";
            this.lnklbl_presupuesto.Size = new System.Drawing.Size(85, 13);
            this.lnklbl_presupuesto.TabIndex = 17;
            this.lnklbl_presupuesto.TabStop = true;
            this.lnklbl_presupuesto.Text = "Ver Presupuesto";
            // 
            // lnklbl_factura
            // 
            this.lnklbl_factura.AutoSize = true;
            this.lnklbl_factura.Location = new System.Drawing.Point(380, 115);
            this.lnklbl_factura.Name = "lnklbl_factura";
            this.lnklbl_factura.Size = new System.Drawing.Size(62, 13);
            this.lnklbl_factura.TabIndex = 18;
            this.lnklbl_factura.TabStop = true;
            this.lnklbl_factura.Text = "Ver Factura";
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(383, 218);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(75, 23);
            this.btn_crear.TabIndex = 20;
            this.btn_crear.Text = "Crear";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // cmbActividad
            // 
            this.cmbActividad.FormattingEnabled = true;
            this.cmbActividad.Location = new System.Drawing.Point(100, 43);
            this.cmbActividad.Name = "cmbActividad";
            this.cmbActividad.Size = new System.Drawing.Size(121, 21);
            this.cmbActividad.TabIndex = 21;
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(100, 86);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(121, 21);
            this.cmbEmpresa.TabIndex = 22;
            // 
            // mudImporte
            // 
            this.mudImporte.DecimalPlaces = 2;
            this.mudImporte.Location = new System.Drawing.Point(100, 129);
            this.mudImporte.Name = "mudImporte";
            this.mudImporte.Size = new System.Drawing.Size(120, 20);
            this.mudImporte.TabIndex = 23;
            // 
            // FrmContrato_transporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 266);
            this.Controls.Add(this.mudImporte);
            this.Controls.Add(this.cmbEmpresa);
            this.Controls.Add(this.cmbActividad);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.lnklbl_factura);
            this.Controls.Add(this.lnklbl_presupuesto);
            this.Controls.Add(this.lbl_empresa);
            this.Controls.Add(this.lbl_importe);
            this.Controls.Add(this.lbl_actividad);
            this.Name = "FrmContrato_transporte";
            this.Text = "Contrato_transporte";
            ((System.ComponentModel.ISupportInitialize)(this.mudImporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_actividad;
        private System.Windows.Forms.Label lbl_importe;
        private System.Windows.Forms.Label lbl_empresa;
        private System.Windows.Forms.LinkLabel lnklbl_presupuesto;
        private System.Windows.Forms.LinkLabel lnklbl_factura;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.ComboBox cmbActividad;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.NumericUpDown mudImporte;
    }
}