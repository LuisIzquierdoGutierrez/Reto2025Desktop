namespace Reto2025.Views
{
    partial class frmVerActividades
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.lwActividades = new System.Windows.Forms.ListView();
            this.Titulo_Actividad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fecha_Inicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fecha_Fin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hora_Inicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hora_Fin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prevista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Transporte_Requerido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Comentario_Transporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Alojamiento_Requerido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Comentario_Alojamiento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Comentarios = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Comentario_Estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Incidencias = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Url_Folleto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id_Solicitante = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Importe_Por_Alumno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(927, 505);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(86, 29);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lwActividades
            // 
            this.lwActividades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Titulo_Actividad,
            this.Tipo,
            this.Descripcion,
            this.Fecha_Inicio,
            this.Fecha_Fin,
            this.Hora_Inicio,
            this.Hora_Fin,
            this.Prevista,
            this.Transporte_Requerido,
            this.Comentario_Transporte,
            this.Alojamiento_Requerido,
            this.Comentario_Alojamiento,
            this.Comentarios,
            this.Estado,
            this.Comentario_Estado,
            this.Incidencias,
            this.Url_Folleto,
            this.Id_Solicitante,
            this.Importe_Por_Alumno});
            this.lwActividades.HideSelection = false;
            this.lwActividades.Location = new System.Drawing.Point(12, 23);
            this.lwActividades.Name = "lwActividades";
            this.lwActividades.Size = new System.Drawing.Size(1033, 464);
            this.lwActividades.TabIndex = 5;
            this.lwActividades.UseCompatibleStateImageBehavior = false;
            this.lwActividades.View = System.Windows.Forms.View.Details;
            // 
            // Titulo_Actividad
            // 
            this.Titulo_Actividad.Text = "Titulo";
            // 
            // Tipo
            // 
            this.Tipo.Text = "Tipo";
            // 
            // Descripcion
            // 
            this.Descripcion.Text = "Descripcion";
            // 
            // Fecha_Inicio
            // 
            this.Fecha_Inicio.Text = "Fecha Inicio";
            // 
            // Fecha_Fin
            // 
            this.Fecha_Fin.Text = "Fecha Fin";
            // 
            // Hora_Inicio
            // 
            this.Hora_Inicio.Text = "Hora Inicio";
            // 
            // Hora_Fin
            // 
            this.Hora_Fin.Text = "Hora Fin";
            // 
            // Prevista
            // 
            this.Prevista.Text = "Prevista";
            // 
            // Transporte_Requerido
            // 
            this.Transporte_Requerido.Text = "Transporte Requerido";
            // 
            // Comentario_Transporte
            // 
            this.Comentario_Transporte.Text = "Comentario Transporte";
            // 
            // Alojamiento_Requerido
            // 
            this.Alojamiento_Requerido.Text = "Alojamiento Requerido";
            // 
            // Comentario_Alojamiento
            // 
            this.Comentario_Alojamiento.Text = "Comentario Alojamiento";
            // 
            // Comentarios
            // 
            this.Comentarios.Text = "Comentarios";
            // 
            // Estado
            // 
            this.Estado.Text = "Estado";
            // 
            // Comentario_Estado
            // 
            this.Comentario_Estado.Text = "Comentario Estado";
            // 
            // Incidencias
            // 
            this.Incidencias.Text = "Incidencias";
            // 
            // Url_Folleto
            // 
            this.Url_Folleto.Text = "Url Folleto";
            // 
            // Id_Solicitante
            // 
            this.Id_Solicitante.Text = "Id Solicitante";
            // 
            // Importe_Por_Alumno
            // 
            this.Importe_Por_Alumno.Text = "Importe Por Alumno";
            // 
            // frmVerActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 544);
            this.Controls.Add(this.lwActividades);
            this.Controls.Add(this.btnVolver);
            this.Name = "frmVerActividades";
            this.Text = "frmVerActividades";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ListView lwActividades;
        private System.Windows.Forms.ColumnHeader Titulo_Actividad;
        private System.Windows.Forms.ColumnHeader Tipo;
        private System.Windows.Forms.ColumnHeader Descripcion;
        private System.Windows.Forms.ColumnHeader Fecha_Inicio;
        private System.Windows.Forms.ColumnHeader Fecha_Fin;
        private System.Windows.Forms.ColumnHeader Hora_Inicio;
        private System.Windows.Forms.ColumnHeader Hora_Fin;
        private System.Windows.Forms.ColumnHeader Prevista;
        private System.Windows.Forms.ColumnHeader Transporte_Requerido;
        private System.Windows.Forms.ColumnHeader Comentario_Transporte;
        private System.Windows.Forms.ColumnHeader Alojamiento_Requerido;
        private System.Windows.Forms.ColumnHeader Comentario_Alojamiento;
        private System.Windows.Forms.ColumnHeader Comentarios;
        private System.Windows.Forms.ColumnHeader Estado;
        private System.Windows.Forms.ColumnHeader Comentario_Estado;
        private System.Windows.Forms.ColumnHeader Incidencias;
        private System.Windows.Forms.ColumnHeader Url_Folleto;
        private System.Windows.Forms.ColumnHeader Id_Solicitante;
        private System.Windows.Forms.ColumnHeader Importe_Por_Alumno;
    }
}