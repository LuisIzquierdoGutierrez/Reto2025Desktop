namespace Reto2025.Views
{
    partial class FrmCursos
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
            this.lwCursos = new System.Windows.Forms.ListView();
            this.Codigo_curso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Titulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Etapa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lwCursos
            // 
            this.lwCursos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo_curso,
            this.Titulo,
            this.Etapa});
            this.lwCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lwCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lwCursos.HideSelection = false;
            this.lwCursos.Location = new System.Drawing.Point(0, 0);
            this.lwCursos.Name = "lwCursos";
            this.lwCursos.Size = new System.Drawing.Size(584, 461);
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
            // FrmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.lwCursos);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "FrmCursos";
            this.Text = "Cursos";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lwCursos;
        private System.Windows.Forms.ColumnHeader Codigo_curso;
        private System.Windows.Forms.ColumnHeader Titulo;
        private System.Windows.Forms.ColumnHeader Etapa;
    }
}