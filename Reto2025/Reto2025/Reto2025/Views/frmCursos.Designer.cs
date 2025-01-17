namespace Reto2025.Views
{
    partial class frmCursos
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
            this.btn_volver = new System.Windows.Forms.Button();
            this.lwCursos = new System.Windows.Forms.ListView();
            this.Codigo_curso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Titulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Etapa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nivel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(657, 410);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 1;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // lwCursos
            // 
            this.lwCursos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo_curso,
            this.Titulo,
            this.Etapa,
            this.Nivel});
            this.lwCursos.HideSelection = false;
            this.lwCursos.Location = new System.Drawing.Point(12, 12);
            this.lwCursos.Name = "lwCursos";
            this.lwCursos.Size = new System.Drawing.Size(776, 378);
            this.lwCursos.TabIndex = 2;
            this.lwCursos.UseCompatibleStateImageBehavior = false;
            this.lwCursos.View = System.Windows.Forms.View.Details;
            // 
            // Codigo_curso
            // 
            this.Codigo_curso.Text = "Codigo curso";
            // 
            // Titulo
            // 
            this.Titulo.Text = "Titulo";
            this.Titulo.Width = 96;
            // 
            // Etapa
            // 
            this.Etapa.Text = "Etapa";
            this.Etapa.Width = 115;
            // 
            // Nivel
            // 
            this.Nivel.Text = "Nivel";
            this.Nivel.Width = 483;
            // 
            // frmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lwCursos);
            this.Controls.Add(this.btn_volver);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "frmCursos";
            this.Text = "Cursos";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.ListView lwCursos;
        private System.Windows.Forms.ColumnHeader Codigo_curso;
        private System.Windows.Forms.ColumnHeader Titulo;
        private System.Windows.Forms.ColumnHeader Etapa;
        private System.Windows.Forms.ColumnHeader Nivel;
    }
}