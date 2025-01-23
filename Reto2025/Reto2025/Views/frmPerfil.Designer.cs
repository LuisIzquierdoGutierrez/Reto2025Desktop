namespace Reto2025.Views
{
    partial class FrmPerfil
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
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lbl_foto = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(308, 111);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(55, 13);
            this.lblApellidos.TabIndex = 1;
            this.lblApellidos.Text = "Apellidos: ";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(308, 190);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(44, 13);
            this.lblCorreo.TabIndex = 2;
            this.lblCorreo.Text = "Correo: ";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(308, 164);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(29, 13);
            this.lblRol.TabIndex = 4;
            this.lblRol.Text = "Rol: ";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(308, 138);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(80, 13);
            this.lblDepartamento.TabIndex = 5;
            this.lblDepartamento.Text = "Departamento: ";
            // 
            // lbl_foto
            // 
            this.lbl_foto.AutoSize = true;
            this.lbl_foto.Location = new System.Drawing.Point(45, 26);
            this.lbl_foto.Name = "lbl_foto";
            this.lbl_foto.Size = new System.Drawing.Size(68, 13);
            this.lbl_foto.TabIndex = 7;
            this.lbl_foto.Text = "Foto de perfil";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(308, 85);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(60, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 150);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(609, 322);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lbl_foto);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblApellidos);
            this.Name = "FrmPerfil";
            this.Text = "Perfil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lbl_foto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}