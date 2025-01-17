namespace Reto2025.Views
{
    partial class frmPerfil
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
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_apellidos = new System.Windows.Forms.Label();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_rol = new System.Windows.Forms.Label();
            this.lbl_departamento = new System.Windows.Forms.Label();
            this.lbl_foto = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.txt_departamento = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chk_activo = new System.Windows.Forms.CheckBox();
            this.cmb_rol = new System.Windows.Forms.ComboBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(308, 54);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(26, 13);
            this.lbl_dni.TabIndex = 0;
            this.lbl_dni.Text = "DNI";
            // 
            // lbl_apellidos
            // 
            this.lbl_apellidos.AutoSize = true;
            this.lbl_apellidos.Location = new System.Drawing.Point(308, 108);
            this.lbl_apellidos.Name = "lbl_apellidos";
            this.lbl_apellidos.Size = new System.Drawing.Size(49, 13);
            this.lbl_apellidos.TabIndex = 1;
            this.lbl_apellidos.Text = "Apellidos";
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Location = new System.Drawing.Point(308, 187);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(38, 13);
            this.lbl_correo.TabIndex = 2;
            this.lbl_correo.Text = "Correo";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(308, 160);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(61, 13);
            this.lbl_pass.TabIndex = 3;
            this.lbl_pass.Text = "Contraseña";
            // 
            // lbl_rol
            // 
            this.lbl_rol.AutoSize = true;
            this.lbl_rol.Location = new System.Drawing.Point(308, 216);
            this.lbl_rol.Name = "lbl_rol";
            this.lbl_rol.Size = new System.Drawing.Size(23, 13);
            this.lbl_rol.TabIndex = 4;
            this.lbl_rol.Text = "Rol";
            // 
            // lbl_departamento
            // 
            this.lbl_departamento.AutoSize = true;
            this.lbl_departamento.Location = new System.Drawing.Point(308, 134);
            this.lbl_departamento.Name = "lbl_departamento";
            this.lbl_departamento.Size = new System.Drawing.Size(74, 13);
            this.lbl_departamento.TabIndex = 5;
            this.lbl_departamento.Text = "Departamento";
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
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(308, 85);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 9;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(412, 51);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(100, 20);
            this.txt_dni.TabIndex = 10;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(412, 78);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 11;
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(412, 101);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(100, 20);
            this.txt_apellidos.TabIndex = 12;
            // 
            // txt_departamento
            // 
            this.txt_departamento.Location = new System.Drawing.Point(412, 127);
            this.txt_departamento.Name = "txt_departamento";
            this.txt_departamento.Size = new System.Drawing.Size(100, 20);
            this.txt_departamento.TabIndex = 13;
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(412, 180);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(100, 20);
            this.txt_correo.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(60, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 150);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // chk_activo
            // 
            this.chk_activo.AutoSize = true;
            this.chk_activo.Location = new System.Drawing.Point(113, 226);
            this.chk_activo.Name = "chk_activo";
            this.chk_activo.Size = new System.Drawing.Size(56, 17);
            this.chk_activo.TabIndex = 16;
            this.chk_activo.Text = "Activo";
            this.chk_activo.UseVisualStyleBackColor = true;
            // 
            // cmb_rol
            // 
            this.cmb_rol.FormattingEnabled = true;
            this.cmb_rol.Location = new System.Drawing.Point(412, 213);
            this.cmb_rol.Name = "cmb_rol";
            this.cmb_rol.Size = new System.Drawing.Size(100, 21);
            this.cmb_rol.TabIndex = 17;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(412, 153);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(100, 20);
            this.txt_contraseña.TabIndex = 18;
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(481, 285);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 19;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(365, 285);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 20;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // frmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 322);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.cmb_rol);
            this.Controls.Add(this.chk_activo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.txt_departamento);
            this.Controls.Add(this.txt_apellidos);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_foto);
            this.Controls.Add(this.lbl_departamento);
            this.Controls.Add(this.lbl_rol);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_correo);
            this.Controls.Add(this.lbl_apellidos);
            this.Controls.Add(this.lbl_dni);
            this.Name = "frmPerfil";
            this.Text = "Perfil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Label lbl_apellidos;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_rol;
        private System.Windows.Forms.Label lbl_departamento;
        private System.Windows.Forms.Label lbl_foto;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.TextBox txt_departamento;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chk_activo;
        private System.Windows.Forms.ComboBox cmb_rol;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_modificar;
    }
}