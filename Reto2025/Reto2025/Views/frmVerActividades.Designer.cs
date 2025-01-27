namespace Reto2025.Views
{
    partial class FrmVerActividades
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
            this.lblFiltros = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblParticipacion = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbParticipacion = new System.Windows.Forms.ComboBox();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lwActividades
            // 
            this.lwActividades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lwActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lwActividades.HideSelection = false;
            this.lwActividades.Location = new System.Drawing.Point(173, 2);
            this.lwActividades.Margin = new System.Windows.Forms.Padding(2);
            this.lwActividades.Name = "lwActividades";
            this.lwActividades.Size = new System.Drawing.Size(571, 442);
            this.lwActividades.TabIndex = 5;
            this.lwActividades.UseCompatibleStateImageBehavior = false;
            this.lwActividades.View = System.Windows.Forms.View.Details;
            this.lwActividades.DoubleClick += new System.EventHandler(this.lwActividades_DoubleClick);
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
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFiltros.Location = new System.Drawing.Point(25, 32);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(56, 20);
            this.lblFiltros.TabIndex = 6;
            this.lblFiltros.Text = "Filtros:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEstado.Location = new System.Drawing.Point(26, 82);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(56, 17);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Estado:";
            // 
            // lblParticipacion
            // 
            this.lblParticipacion.AutoSize = true;
            this.lblParticipacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblParticipacion.Location = new System.Drawing.Point(26, 152);
            this.lblParticipacion.Name = "lblParticipacion";
            this.lblParticipacion.Size = new System.Drawing.Size(93, 17);
            this.lblParticipacion.TabIndex = 8;
            this.lblParticipacion.Text = "Participacion:";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCurso.Location = new System.Drawing.Point(26, 224);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(49, 17);
            this.lblCurso.TabIndex = 9;
            this.lblCurso.Text = "Curso:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Cualquiera",
            "Solicitada",
            "Denegada",
            "Aprobada",
            "Realizada",
            "Realizandose",
            "Cancelada"});
            this.cmbEstado.Location = new System.Drawing.Point(29, 102);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 24);
            this.cmbEstado.TabIndex = 10;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.filtrado);
            // 
            // cmbParticipacion
            // 
            this.cmbParticipacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParticipacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbParticipacion.FormattingEnabled = true;
            this.cmbParticipacion.Items.AddRange(new object[] {
            "Cualquiera",
            "Participante",
            "Responsable"});
            this.cmbParticipacion.Location = new System.Drawing.Point(29, 172);
            this.cmbParticipacion.Name = "cmbParticipacion";
            this.cmbParticipacion.Size = new System.Drawing.Size(121, 24);
            this.cmbParticipacion.TabIndex = 11;
            this.cmbParticipacion.SelectedIndexChanged += new System.EventHandler(this.filtrado);
            // 
            // cmbCurso
            // 
            this.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Items.AddRange(new object[] {
            "Cualquiera",
            "ESO1",
            "ESO2",
            "ESO3",
            "ESO4",
            "BACH1",
            "BACH2",
            "FPBIC1",
            "FPBFM1",
            "FPBIC2",
            "FPBFM2",
            "SMR1",
            "SMR2",
            "MEC1",
            "MEC2",
            "GAD1",
            "GAD2",
            "DAM1",
            "DAM2",
            "PPFM1",
            "PPFM2",
            "AYF1",
            "AYF2",
            "DPFM1",
            "DPFM2",
            "DAW1",
            "DAW2",
            "ASIR1",
            "ASIR2"});
            this.cmbCurso.Location = new System.Drawing.Point(29, 244);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(121, 24);
            this.cmbCurso.TabIndex = 12;
            this.cmbCurso.SelectedIndexChanged += new System.EventHandler(this.filtrado);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTipo.Location = new System.Drawing.Point(26, 300);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(40, 17);
            this.lblTipo.TabIndex = 13;
            this.lblTipo.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Cualquiera",
            "Complementaria",
            "Extraescolar"});
            this.cmbTipo.Location = new System.Drawing.Point(29, 320);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 24);
            this.cmbTipo.TabIndex = 14;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.filtrado);
            // 
            // FrmVerActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 442);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.cmbParticipacion);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblParticipacion);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFiltros);
            this.Controls.Add(this.lwActividades);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmVerActividades";
            this.Text = "Actividades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblParticipacion;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbParticipacion;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
    }
}