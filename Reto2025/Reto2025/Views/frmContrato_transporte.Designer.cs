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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_importe = new System.Windows.Forms.Label();
            this.lbl_empresa = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lnklbl_presupuesto = new System.Windows.Forms.LinkLabel();
            this.lnklbl_factura = new System.Windows.Forms.LinkLabel();
            this.btn_crear = new System.Windows.Forms.Button();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(135, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 16;
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
            this.btn_crear.Location = new System.Drawing.Point(291, 208);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(75, 23);
            this.btn_crear.TabIndex = 20;
            this.btn_crear.Text = "Crear";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // FrmContrato_transporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 266);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.lnklbl_factura);
            this.Controls.Add(this.lnklbl_presupuesto);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lbl_empresa);
            this.Controls.Add(this.lbl_importe);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_actividad);
            this.Name = "FrmContrato_transporte";
            this.Text = "Contrato_transporte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_actividad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_importe;
        private System.Windows.Forms.Label lbl_empresa;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.LinkLabel lnklbl_presupuesto;
        private System.Windows.Forms.LinkLabel lnklbl_factura;
        private System.Windows.Forms.Button btn_crear;
    }
}