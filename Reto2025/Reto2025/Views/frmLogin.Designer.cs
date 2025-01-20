namespace Reto2025
{
    partial class FrmLogin
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Correo = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(86, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 111);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Correo
            // 
            this.lbl_Correo.AutoSize = true;
            this.lbl_Correo.Location = new System.Drawing.Point(27, 174);
            this.lbl_Correo.Name = "lbl_Correo";
            this.lbl_Correo.Size = new System.Drawing.Size(94, 13);
            this.lbl_Correo.TabIndex = 1;
            this.lbl_Correo.Text = "Correo Electronico";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(27, 210);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(61, 13);
            this.lbl_pass.TabIndex = 2;
            this.lbl_pass.Text = "Contraseña";
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(127, 171);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(219, 20);
            this.txt_correo.TabIndex = 3;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(127, 207);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(219, 20);
            this.txt_pass.TabIndex = 4;
            // 
            // btn_inicio
            // 
            this.btn_inicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_inicio.Location = new System.Drawing.Point(140, 250);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(89, 23);
            this.btn_inicio.TabIndex = 5;
            this.btn_inicio.Text = "Iniciar Sesion";
            this.btn_inicio.UseVisualStyleBackColor = true;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 326);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_inicio);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_Correo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Correo;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Button button1;
    }
}

