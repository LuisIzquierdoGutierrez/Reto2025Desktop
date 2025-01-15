namespace Reto2025.Views
{
    partial class frmGrupos
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
            this.lbl_curso = new System.Windows.Forms.Label();
            this.lbl_numAlumnos = new System.Windows.Forms.Label();
            this.lbl_profesor = new System.Windows.Forms.Label();
            this.btn_crear = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.cmb_cursos = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmb_prof1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_curso
            // 
            this.lbl_curso.AutoSize = true;
            this.lbl_curso.Location = new System.Drawing.Point(29, 53);
            this.lbl_curso.Name = "lbl_curso";
            this.lbl_curso.Size = new System.Drawing.Size(34, 13);
            this.lbl_curso.TabIndex = 0;
            this.lbl_curso.Text = "Curso";
            // 
            // lbl_numAlumnos
            // 
            this.lbl_numAlumnos.AutoSize = true;
            this.lbl_numAlumnos.Location = new System.Drawing.Point(29, 92);
            this.lbl_numAlumnos.Name = "lbl_numAlumnos";
            this.lbl_numAlumnos.Size = new System.Drawing.Size(102, 13);
            this.lbl_numAlumnos.TabIndex = 1;
            this.lbl_numAlumnos.Text = "Numero de Alumnos";
            // 
            // lbl_profesor
            // 
            this.lbl_profesor.AutoSize = true;
            this.lbl_profesor.Location = new System.Drawing.Point(29, 139);
            this.lbl_profesor.Name = "lbl_profesor";
            this.lbl_profesor.Size = new System.Drawing.Size(46, 13);
            this.lbl_profesor.TabIndex = 2;
            this.lbl_profesor.Text = "Profesor";
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(42, 290);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(75, 23);
            this.btn_crear.TabIndex = 3;
            this.btn_crear.Text = "Crear";
            this.btn_crear.UseVisualStyleBackColor = true;
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(233, 290);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 4;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // cmb_cursos
            // 
            this.cmb_cursos.FormattingEnabled = true;
            this.cmb_cursos.Location = new System.Drawing.Point(187, 50);
            this.cmb_cursos.Name = "cmb_cursos";
            this.cmb_cursos.Size = new System.Drawing.Size(121, 21);
            this.cmb_cursos.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 6;
            // 
            // cmb_prof1
            // 
            this.cmb_prof1.FormattingEnabled = true;
            this.cmb_prof1.Location = new System.Drawing.Point(187, 136);
            this.cmb_prof1.Name = "cmb_prof1";
            this.cmb_prof1.Size = new System.Drawing.Size(121, 21);
            this.cmb_prof1.TabIndex = 7;
            // 
            // Grupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 340);
            this.Controls.Add(this.cmb_prof1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmb_cursos);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.lbl_profesor);
            this.Controls.Add(this.lbl_numAlumnos);
            this.Controls.Add(this.lbl_curso);
            this.Name = "Grupos";
            this.Text = "Grupos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_curso;
        private System.Windows.Forms.Label lbl_numAlumnos;
        private System.Windows.Forms.Label lbl_profesor;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.ComboBox cmb_cursos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmb_prof1;
    }
}