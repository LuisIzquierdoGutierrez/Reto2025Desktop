﻿namespace Reto2025.Views
{
    partial class FrmActividades
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFechaini = new System.Windows.Forms.Label();
            this.lblFechafin = new System.Windows.Forms.Label();
            this.lblHoraini = new System.Windows.Forms.Label();
            this.lblHorafin = new System.Windows.Forms.Label();
            this.lbl_fechaProv = new System.Windows.Forms.Label();
            this.lbl_comentTransp = new System.Windows.Forms.Label();
            this.lbl_comentAloj = new System.Windows.Forms.Label();
            this.lbl_comentGen = new System.Windows.Forms.Label();
            this.lbl_incidencias = new System.Windows.Forms.Label();
            this.lbl_importe = new System.Windows.Forms.Label();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_cometariosGenerales = new System.Windows.Forms.TextBox();
            this.txt_comentTransp = new System.Windows.Forms.TextBox();
            this.txt_comentAloj = new System.Windows.Forms.TextBox();
            this.txt_incidencias = new System.Windows.Forms.TextBox();
            this.cmb_tipos = new System.Windows.Forms.ComboBox();
            this.dtp_fechaIni = new System.Windows.Forms.DateTimePicker();
            this.dtp_fechafin = new System.Windows.Forms.DateTimePicker();
            this.chck_transporte = new System.Windows.Forms.CheckBox();
            this.chk_alojamiento = new System.Windows.Forms.CheckBox();
            this.dtp_horaini = new System.Windows.Forms.DateTimePicker();
            this.dtp_horafin = new System.Windows.Forms.DateTimePicker();
            this.cmb_tipo_transporte = new System.Windows.Forms.ComboBox();
            this.lbl_tipoTransp = new System.Windows.Forms.Label();
            this.dtp_fechaProvista = new System.Windows.Forms.DateTimePicker();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_fotos = new System.Windows.Forms.Button();
            this.btn_aprobar = new System.Windows.Forms.Button();
            this.btn_rechazar = new System.Windows.Forms.Button();
            this.btn_verGrupos = new System.Windows.Forms.Button();
            this.chk_discapacidad = new System.Windows.Forms.CheckBox();
            this.txt_importe = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txt_importe)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Location = new System.Drawing.Point(323, 15);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(106, 13);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Titulo de la Actividad";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(91, 55);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(100, 13);
            this.lbl_tipo.TabIndex = 1;
            this.lbl_tipo.Text = "Tipo de la actividad";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(413, 46);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblFechaini
            // 
            this.lblFechaini.AutoSize = true;
            this.lblFechaini.Location = new System.Drawing.Point(91, 102);
            this.lblFechaini.Name = "lblFechaini";
            this.lblFechaini.Size = new System.Drawing.Size(64, 13);
            this.lblFechaini.TabIndex = 3;
            this.lblFechaini.Text = "Fecha inicio";
            // 
            // lblFechafin
            // 
            this.lblFechafin.AutoSize = true;
            this.lblFechafin.Location = new System.Drawing.Point(91, 140);
            this.lblFechafin.Name = "lblFechafin";
            this.lblFechafin.Size = new System.Drawing.Size(51, 13);
            this.lblFechafin.TabIndex = 4;
            this.lblFechafin.Text = "Fecha fin";
            // 
            // lblHoraini
            // 
            this.lblHoraini.AutoSize = true;
            this.lblHoraini.Location = new System.Drawing.Point(91, 175);
            this.lblHoraini.Name = "lblHoraini";
            this.lblHoraini.Size = new System.Drawing.Size(57, 13);
            this.lblHoraini.TabIndex = 5;
            this.lblHoraini.Text = "Hora inicio";
            // 
            // lblHorafin
            // 
            this.lblHorafin.AutoSize = true;
            this.lblHorafin.Location = new System.Drawing.Point(91, 215);
            this.lblHorafin.Name = "lblHorafin";
            this.lblHorafin.Size = new System.Drawing.Size(44, 13);
            this.lblHorafin.TabIndex = 6;
            this.lblHorafin.Text = "Hora fin";
            // 
            // lbl_fechaProv
            // 
            this.lbl_fechaProv.AutoSize = true;
            this.lbl_fechaProv.Location = new System.Drawing.Point(87, 264);
            this.lbl_fechaProv.Name = "lbl_fechaProv";
            this.lbl_fechaProv.Size = new System.Drawing.Size(104, 13);
            this.lbl_fechaProv.TabIndex = 7;
            this.lbl_fechaProv.Text = "Fecha provista inicio";
            // 
            // lbl_comentTransp
            // 
            this.lbl_comentTransp.AutoSize = true;
            this.lbl_comentTransp.Location = new System.Drawing.Point(413, 222);
            this.lbl_comentTransp.Name = "lbl_comentTransp";
            this.lbl_comentTransp.Size = new System.Drawing.Size(131, 13);
            this.lbl_comentTransp.TabIndex = 9;
            this.lbl_comentTransp.Text = "Comentario del Transporte";
            // 
            // lbl_comentAloj
            // 
            this.lbl_comentAloj.AutoSize = true;
            this.lbl_comentAloj.Location = new System.Drawing.Point(413, 379);
            this.lbl_comentAloj.Name = "lbl_comentAloj";
            this.lbl_comentAloj.Size = new System.Drawing.Size(133, 13);
            this.lbl_comentAloj.TabIndex = 11;
            this.lbl_comentAloj.Text = "Comentario del alojamiento";
            // 
            // lbl_comentGen
            // 
            this.lbl_comentGen.AutoSize = true;
            this.lbl_comentGen.Location = new System.Drawing.Point(91, 300);
            this.lbl_comentGen.Name = "lbl_comentGen";
            this.lbl_comentGen.Size = new System.Drawing.Size(116, 13);
            this.lbl_comentGen.TabIndex = 12;
            this.lbl_comentGen.Text = "Comentarios Generales";
            // 
            // lbl_incidencias
            // 
            this.lbl_incidencias.AutoSize = true;
            this.lbl_incidencias.Location = new System.Drawing.Point(413, 495);
            this.lbl_incidencias.Name = "lbl_incidencias";
            this.lbl_incidencias.Size = new System.Drawing.Size(61, 13);
            this.lbl_incidencias.TabIndex = 13;
            this.lbl_incidencias.Text = "Incidencias";
            // 
            // lbl_importe
            // 
            this.lbl_importe.AutoSize = true;
            this.lbl_importe.Location = new System.Drawing.Point(96, 461);
            this.lbl_importe.Name = "lbl_importe";
            this.lbl_importe.Size = new System.Drawing.Size(42, 13);
            this.lbl_importe.TabIndex = 14;
            this.lbl_importe.Text = "Importe";
            // 
            // txt_titulo
            // 
            this.txt_titulo.Location = new System.Drawing.Point(480, 12);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(100, 20);
            this.txt_titulo.TabIndex = 15;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(416, 78);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(376, 82);
            this.txt_descripcion.TabIndex = 16;
            // 
            // txt_cometariosGenerales
            // 
            this.txt_cometariosGenerales.Location = new System.Drawing.Point(90, 332);
            this.txt_cometariosGenerales.Multiline = true;
            this.txt_cometariosGenerales.Name = "txt_cometariosGenerales";
            this.txt_cometariosGenerales.Size = new System.Drawing.Size(282, 93);
            this.txt_cometariosGenerales.TabIndex = 17;
            // 
            // txt_comentTransp
            // 
            this.txt_comentTransp.Location = new System.Drawing.Point(416, 247);
            this.txt_comentTransp.Multiline = true;
            this.txt_comentTransp.Name = "txt_comentTransp";
            this.txt_comentTransp.Size = new System.Drawing.Size(376, 79);
            this.txt_comentTransp.TabIndex = 18;
            // 
            // txt_comentAloj
            // 
            this.txt_comentAloj.Location = new System.Drawing.Point(416, 410);
            this.txt_comentAloj.Multiline = true;
            this.txt_comentAloj.Name = "txt_comentAloj";
            this.txt_comentAloj.Size = new System.Drawing.Size(376, 63);
            this.txt_comentAloj.TabIndex = 20;
            // 
            // txt_incidencias
            // 
            this.txt_incidencias.Location = new System.Drawing.Point(416, 526);
            this.txt_incidencias.Multiline = true;
            this.txt_incidencias.Name = "txt_incidencias";
            this.txt_incidencias.Size = new System.Drawing.Size(376, 60);
            this.txt_incidencias.TabIndex = 21;
            // 
            // cmb_tipos
            // 
            this.cmb_tipos.FormattingEnabled = true;
            this.cmb_tipos.Location = new System.Drawing.Point(220, 55);
            this.cmb_tipos.Name = "cmb_tipos";
            this.cmb_tipos.Size = new System.Drawing.Size(121, 21);
            this.cmb_tipos.TabIndex = 22;
            // 
            // dtp_fechaIni
            // 
            this.dtp_fechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaIni.Location = new System.Drawing.Point(220, 96);
            this.dtp_fechaIni.Name = "dtp_fechaIni";
            this.dtp_fechaIni.Size = new System.Drawing.Size(95, 20);
            this.dtp_fechaIni.TabIndex = 23;
            // 
            // dtp_fechafin
            // 
            this.dtp_fechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechafin.Location = new System.Drawing.Point(220, 140);
            this.dtp_fechafin.Name = "dtp_fechafin";
            this.dtp_fechafin.Size = new System.Drawing.Size(95, 20);
            this.dtp_fechafin.TabIndex = 24;
            // 
            // chck_transporte
            // 
            this.chck_transporte.AutoSize = true;
            this.chck_transporte.Location = new System.Drawing.Point(416, 185);
            this.chck_transporte.Name = "chck_transporte";
            this.chck_transporte.Size = new System.Drawing.Size(77, 17);
            this.chck_transporte.TabIndex = 25;
            this.chck_transporte.Text = "Transporte";
            this.chck_transporte.UseVisualStyleBackColor = true;
            // 
            // chk_alojamiento
            // 
            this.chk_alojamiento.AutoSize = true;
            this.chk_alojamiento.Location = new System.Drawing.Point(430, 346);
            this.chk_alojamiento.Name = "chk_alojamiento";
            this.chk_alojamiento.Size = new System.Drawing.Size(80, 17);
            this.chk_alojamiento.TabIndex = 26;
            this.chk_alojamiento.Text = "Alojamiento";
            this.chk_alojamiento.UseVisualStyleBackColor = true;
            // 
            // dtp_horaini
            // 
            this.dtp_horaini.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_horaini.Location = new System.Drawing.Point(220, 169);
            this.dtp_horaini.Name = "dtp_horaini";
            this.dtp_horaini.Size = new System.Drawing.Size(95, 20);
            this.dtp_horaini.TabIndex = 27;
            // 
            // dtp_horafin
            // 
            this.dtp_horafin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_horafin.Location = new System.Drawing.Point(220, 215);
            this.dtp_horafin.Name = "dtp_horafin";
            this.dtp_horafin.Size = new System.Drawing.Size(95, 20);
            this.dtp_horafin.TabIndex = 28;
            // 
            // cmb_tipo_transporte
            // 
            this.cmb_tipo_transporte.FormattingEnabled = true;
            this.cmb_tipo_transporte.Location = new System.Drawing.Point(671, 185);
            this.cmb_tipo_transporte.Name = "cmb_tipo_transporte";
            this.cmb_tipo_transporte.Size = new System.Drawing.Size(121, 21);
            this.cmb_tipo_transporte.TabIndex = 29;
            // 
            // lbl_tipoTransp
            // 
            this.lbl_tipoTransp.AutoSize = true;
            this.lbl_tipoTransp.Location = new System.Drawing.Point(546, 186);
            this.lbl_tipoTransp.Name = "lbl_tipoTransp";
            this.lbl_tipoTransp.Size = new System.Drawing.Size(97, 13);
            this.lbl_tipoTransp.TabIndex = 30;
            this.lbl_tipoTransp.Text = "Tipo de Transporte";
            // 
            // dtp_fechaProvista
            // 
            this.dtp_fechaProvista.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaProvista.Location = new System.Drawing.Point(220, 264);
            this.dtp_fechaProvista.Name = "dtp_fechaProvista";
            this.dtp_fechaProvista.Size = new System.Drawing.Size(95, 20);
            this.dtp_fechaProvista.TabIndex = 31;
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(416, 604);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(75, 23);
            this.btn_borrar.TabIndex = 32;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(568, 604);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 33;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_fotos
            // 
            this.btn_fotos.Location = new System.Drawing.Point(90, 537);
            this.btn_fotos.Name = "btn_fotos";
            this.btn_fotos.Size = new System.Drawing.Size(170, 23);
            this.btn_fotos.TabIndex = 35;
            this.btn_fotos.Text = "Ver Fotos";
            this.btn_fotos.UseVisualStyleBackColor = true;
            this.btn_fotos.Click += new System.EventHandler(this.btn_fotos_Click);
            // 
            // btn_aprobar
            // 
            this.btn_aprobar.Location = new System.Drawing.Point(48, 604);
            this.btn_aprobar.Name = "btn_aprobar";
            this.btn_aprobar.Size = new System.Drawing.Size(75, 23);
            this.btn_aprobar.TabIndex = 36;
            this.btn_aprobar.Text = "Aprobar";
            this.btn_aprobar.UseVisualStyleBackColor = true;
            // 
            // btn_rechazar
            // 
            this.btn_rechazar.Location = new System.Drawing.Point(163, 604);
            this.btn_rechazar.Name = "btn_rechazar";
            this.btn_rechazar.Size = new System.Drawing.Size(75, 23);
            this.btn_rechazar.TabIndex = 37;
            this.btn_rechazar.Text = "Rechazar";
            this.btn_rechazar.UseVisualStyleBackColor = true;
            // 
            // btn_verGrupos
            // 
            this.btn_verGrupos.Location = new System.Drawing.Point(90, 495);
            this.btn_verGrupos.Name = "btn_verGrupos";
            this.btn_verGrupos.Size = new System.Drawing.Size(170, 23);
            this.btn_verGrupos.TabIndex = 38;
            this.btn_verGrupos.Text = "Ver Grupos participantes";
            this.btn_verGrupos.UseVisualStyleBackColor = true;
            this.btn_verGrupos.Click += new System.EventHandler(this.btn_verGrupos_Click);
            // 
            // chk_discapacidad
            // 
            this.chk_discapacidad.AutoSize = true;
            this.chk_discapacidad.Location = new System.Drawing.Point(568, 221);
            this.chk_discapacidad.Name = "chk_discapacidad";
            this.chk_discapacidad.Size = new System.Drawing.Size(91, 17);
            this.chk_discapacidad.TabIndex = 39;
            this.chk_discapacidad.Text = "Discapacidad";
            this.chk_discapacidad.UseVisualStyleBackColor = true;
            // 
            // txt_importe
            // 
            this.txt_importe.DecimalPlaces = 2;
            this.txt_importe.Location = new System.Drawing.Point(163, 461);
            this.txt_importe.Name = "txt_importe";
            this.txt_importe.Size = new System.Drawing.Size(120, 20);
            this.txt_importe.TabIndex = 40;
            // 
            // FrmActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 639);
            this.Controls.Add(this.txt_importe);
            this.Controls.Add(this.chk_discapacidad);
            this.Controls.Add(this.btn_verGrupos);
            this.Controls.Add(this.btn_rechazar);
            this.Controls.Add(this.btn_aprobar);
            this.Controls.Add(this.btn_fotos);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.dtp_fechaProvista);
            this.Controls.Add(this.lbl_tipoTransp);
            this.Controls.Add(this.cmb_tipo_transporte);
            this.Controls.Add(this.dtp_horafin);
            this.Controls.Add(this.dtp_horaini);
            this.Controls.Add(this.chk_alojamiento);
            this.Controls.Add(this.chck_transporte);
            this.Controls.Add(this.dtp_fechafin);
            this.Controls.Add(this.dtp_fechaIni);
            this.Controls.Add(this.cmb_tipos);
            this.Controls.Add(this.txt_incidencias);
            this.Controls.Add(this.txt_comentAloj);
            this.Controls.Add(this.txt_comentTransp);
            this.Controls.Add(this.txt_cometariosGenerales);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.lbl_importe);
            this.Controls.Add(this.lbl_incidencias);
            this.Controls.Add(this.lbl_comentGen);
            this.Controls.Add(this.lbl_comentAloj);
            this.Controls.Add(this.lbl_comentTransp);
            this.Controls.Add(this.lbl_fechaProv);
            this.Controls.Add(this.lblHorafin);
            this.Controls.Add(this.lblHoraini);
            this.Controls.Add(this.lblFechafin);
            this.Controls.Add(this.lblFechaini);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "FrmActividades";
            this.Text = "Actividades";
            ((System.ComponentModel.ISupportInitialize)(this.txt_importe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFechaini;
        private System.Windows.Forms.Label lblFechafin;
        private System.Windows.Forms.Label lblHoraini;
        private System.Windows.Forms.Label lblHorafin;
        private System.Windows.Forms.Label lbl_fechaProv;
        private System.Windows.Forms.Label lbl_comentTransp;
        private System.Windows.Forms.Label lbl_comentAloj;
        private System.Windows.Forms.Label lbl_comentGen;
        private System.Windows.Forms.Label lbl_incidencias;
        private System.Windows.Forms.Label lbl_importe;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_cometariosGenerales;
        private System.Windows.Forms.TextBox txt_comentTransp;
        private System.Windows.Forms.TextBox txt_comentAloj;
        private System.Windows.Forms.TextBox txt_incidencias;
        private System.Windows.Forms.ComboBox cmb_tipos;
        private System.Windows.Forms.DateTimePicker dtp_fechaIni;
        private System.Windows.Forms.DateTimePicker dtp_fechafin;
        private System.Windows.Forms.CheckBox chck_transporte;
        private System.Windows.Forms.CheckBox chk_alojamiento;
        private System.Windows.Forms.DateTimePicker dtp_horaini;
        private System.Windows.Forms.DateTimePicker dtp_horafin;
        private System.Windows.Forms.ComboBox cmb_tipo_transporte;
        private System.Windows.Forms.Label lbl_tipoTransp;
        private System.Windows.Forms.DateTimePicker dtp_fechaProvista;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_fotos;
        private System.Windows.Forms.Button btn_aprobar;
        private System.Windows.Forms.Button btn_rechazar;
        private System.Windows.Forms.Button btn_verGrupos;
        private System.Windows.Forms.CheckBox chk_discapacidad;
        private System.Windows.Forms.NumericUpDown txt_importe;
    }
}