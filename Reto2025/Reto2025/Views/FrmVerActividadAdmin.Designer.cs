﻿namespace Reto2025.Views
{
    partial class FrmVerActividadAdmin
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
            this.rtxAlojamiento = new System.Windows.Forms.RichTextBox();
            this.rtxTransporte = new System.Windows.Forms.RichTextBox();
            this.lblSolicitante = new System.Windows.Forms.Label();
            this.rtxEstado = new System.Windows.Forms.RichTextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.rtxComentarios = new System.Windows.Forms.RichTextBox();
            this.lblFfni = new System.Windows.Forms.Label();
            this.lblFini = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.rtxDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.chkTransporte = new System.Windows.Forms.CheckBox();
            this.chkAlojamiento = new System.Windows.Forms.CheckBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.rtxTransporteFalso = new System.Windows.Forms.RichTextBox();
            this.rtxAlojamientoFalso = new System.Windows.Forms.RichTextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.dtpFini = new System.Windows.Forms.DateTimePicker();
            this.dtpHini = new System.Windows.Forms.DateTimePicker();
            this.dtpHfin = new System.Windows.Forms.DateTimePicker();
            this.dtpFfin = new System.Windows.Forms.DateTimePicker();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.nudImporte = new System.Windows.Forms.NumericUpDown();
            this.lblImporte = new System.Windows.Forms.Label();
            this.rtxIncidencias = new System.Windows.Forms.RichTextBox();
            this.lblIncidencias = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnFotos = new System.Windows.Forms.Button();
            this.btnContratos = new System.Windows.Forms.Button();
            this.lvwgrupos = new System.Windows.Forms.ListView();
            this.lvwProfesores = new System.Windows.Forms.ListView();
            this.lblProfesores = new System.Windows.Forms.Label();
            this.lblGrupos = new System.Windows.Forms.Label();
            this.btnAddGrupo = new System.Windows.Forms.Button();
            this.btnAddProfesor = new System.Windows.Forms.Button();
            this.cmbProfesores = new System.Windows.Forms.ComboBox();
            this.lblNumALumnos = new System.Windows.Forms.Label();
            this.nudAlumnos = new System.Windows.Forms.NumericUpDown();
            this.cmbGrupos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxAlojamiento
            // 
            this.rtxAlojamiento.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rtxAlojamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxAlojamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtxAlojamiento.Location = new System.Drawing.Point(307, 562);
            this.rtxAlojamiento.Name = "rtxAlojamiento";
            this.rtxAlojamiento.Size = new System.Drawing.Size(230, 140);
            this.rtxAlojamiento.TabIndex = 39;
            this.rtxAlojamiento.Text = "";
            // 
            // rtxTransporte
            // 
            this.rtxTransporte.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rtxTransporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtxTransporte.Location = new System.Drawing.Point(30, 562);
            this.rtxTransporte.Name = "rtxTransporte";
            this.rtxTransporte.Size = new System.Drawing.Size(230, 140);
            this.rtxTransporte.TabIndex = 36;
            this.rtxTransporte.Text = "";
            // 
            // lblSolicitante
            // 
            this.lblSolicitante.AutoSize = true;
            this.lblSolicitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSolicitante.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSolicitante.Location = new System.Drawing.Point(27, 109);
            this.lblSolicitante.Name = "lblSolicitante";
            this.lblSolicitante.Size = new System.Drawing.Size(73, 17);
            this.lblSolicitante.TabIndex = 32;
            this.lblSolicitante.Text = "Solicitante";
            // 
            // rtxEstado
            // 
            this.rtxEstado.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rtxEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtxEstado.Location = new System.Drawing.Point(307, 164);
            this.rtxEstado.Name = "rtxEstado";
            this.rtxEstado.Size = new System.Drawing.Size(230, 140);
            this.rtxEstado.TabIndex = 31;
            this.rtxEstado.Text = "Comentario estado";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEstado.Location = new System.Drawing.Point(304, 140);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(56, 17);
            this.lblEstado.TabIndex = 30;
            this.lblEstado.Text = "Estado:";
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblComentarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblComentarios.Location = new System.Drawing.Point(27, 343);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(87, 17);
            this.lblComentarios.TabIndex = 29;
            this.lblComentarios.Text = "Comentarios";
            // 
            // rtxComentarios
            // 
            this.rtxComentarios.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rtxComentarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxComentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtxComentarios.Location = new System.Drawing.Point(30, 363);
            this.rtxComentarios.Name = "rtxComentarios";
            this.rtxComentarios.Size = new System.Drawing.Size(230, 140);
            this.rtxComentarios.TabIndex = 28;
            this.rtxComentarios.Text = "Comentarios";
            // 
            // lblFfni
            // 
            this.lblFfni.AutoSize = true;
            this.lblFfni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFfni.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFfni.Location = new System.Drawing.Point(730, 82);
            this.lblFfni.Name = "lblFfni";
            this.lblFfni.Size = new System.Drawing.Size(74, 17);
            this.lblFfni.TabIndex = 25;
            this.lblFfni.Text = "Fecha Fin:";
            // 
            // lblFini
            // 
            this.lblFini.AutoSize = true;
            this.lblFini.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFini.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFini.Location = new System.Drawing.Point(717, 20);
            this.lblFini.Name = "lblFini";
            this.lblFini.Size = new System.Drawing.Size(87, 17);
            this.lblFini.TabIndex = 24;
            this.lblFini.Text = "Fecha Inicio:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescripcion.Location = new System.Drawing.Point(27, 144);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 17);
            this.lblDescripcion.TabIndex = 23;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // rtxDescripcion
            // 
            this.rtxDescripcion.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rtxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtxDescripcion.Location = new System.Drawing.Point(30, 164);
            this.rtxDescripcion.Name = "rtxDescripcion";
            this.rtxDescripcion.Size = new System.Drawing.Size(230, 140);
            this.rtxDescripcion.TabIndex = 22;
            this.rtxDescripcion.Text = "Descripcion";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTipo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTipo.Location = new System.Drawing.Point(27, 74);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(69, 17);
            this.lblTipo.TabIndex = 21;
            this.lblTipo.Text = "Actividad:";
            // 
            // chkTransporte
            // 
            this.chkTransporte.AutoSize = true;
            this.chkTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkTransporte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkTransporte.Location = new System.Drawing.Point(30, 535);
            this.chkTransporte.Name = "chkTransporte";
            this.chkTransporte.Size = new System.Drawing.Size(97, 21);
            this.chkTransporte.TabIndex = 40;
            this.chkTransporte.Text = "Transporte";
            this.chkTransporte.UseVisualStyleBackColor = true;
            this.chkTransporte.CheckedChanged += new System.EventHandler(this.chkTransporte_CheckedChanged);
            // 
            // chkAlojamiento
            // 
            this.chkAlojamiento.AutoSize = true;
            this.chkAlojamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkAlojamiento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkAlojamiento.Location = new System.Drawing.Point(307, 535);
            this.chkAlojamiento.Name = "chkAlojamiento";
            this.chkAlojamiento.Size = new System.Drawing.Size(100, 21);
            this.chkAlojamiento.TabIndex = 41;
            this.chkAlojamiento.Text = "Alojamiento";
            this.chkAlojamiento.UseVisualStyleBackColor = true;
            this.chkAlojamiento.CheckedChanged += new System.EventHandler(this.chkAlojamiento_CheckedChanged);
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTitulo.Location = new System.Drawing.Point(30, 19);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(413, 26);
            this.txtTitulo.TabIndex = 42;
            this.txtTitulo.Text = "Titulo";
            // 
            // rtxTransporteFalso
            // 
            this.rtxTransporteFalso.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rtxTransporteFalso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxTransporteFalso.Enabled = false;
            this.rtxTransporteFalso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtxTransporteFalso.Location = new System.Drawing.Point(30, 562);
            this.rtxTransporteFalso.Name = "rtxTransporteFalso";
            this.rtxTransporteFalso.ReadOnly = true;
            this.rtxTransporteFalso.Size = new System.Drawing.Size(230, 140);
            this.rtxTransporteFalso.TabIndex = 43;
            this.rtxTransporteFalso.Text = "Transporte no requerido";
            // 
            // rtxAlojamientoFalso
            // 
            this.rtxAlojamientoFalso.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rtxAlojamientoFalso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxAlojamientoFalso.Enabled = false;
            this.rtxAlojamientoFalso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtxAlojamientoFalso.Location = new System.Drawing.Point(307, 562);
            this.rtxAlojamientoFalso.Name = "rtxAlojamientoFalso";
            this.rtxAlojamientoFalso.ReadOnly = true;
            this.rtxAlojamientoFalso.Size = new System.Drawing.Size(230, 140);
            this.rtxAlojamientoFalso.TabIndex = 44;
            this.rtxAlojamientoFalso.Text = "Alojamiento no requerido";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "solicitada",
            "denegada",
            "aprobada",
            "realizada",
            "realizandose",
            "cancelada"});
            this.cmbEstado.Location = new System.Drawing.Point(362, 137);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 24);
            this.cmbEstado.TabIndex = 45;
            // 
            // dtpFini
            // 
            this.dtpFini.CustomFormat = "dd/MM/yy";
            this.dtpFini.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpFini.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFini.Location = new System.Drawing.Point(810, 19);
            this.dtpFini.Name = "dtpFini";
            this.dtpFini.Size = new System.Drawing.Size(74, 23);
            this.dtpFini.TabIndex = 46;
            // 
            // dtpHini
            // 
            this.dtpHini.CustomFormat = "HH:mm";
            this.dtpHini.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpHini.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHini.Location = new System.Drawing.Point(822, 48);
            this.dtpHini.Name = "dtpHini";
            this.dtpHini.ShowUpDown = true;
            this.dtpHini.Size = new System.Drawing.Size(62, 23);
            this.dtpHini.TabIndex = 47;
            // 
            // dtpHfin
            // 
            this.dtpHfin.CustomFormat = "HH:mm";
            this.dtpHfin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpHfin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHfin.Location = new System.Drawing.Point(822, 110);
            this.dtpHfin.Name = "dtpHfin";
            this.dtpHfin.ShowUpDown = true;
            this.dtpHfin.Size = new System.Drawing.Size(62, 23);
            this.dtpHfin.TabIndex = 49;
            // 
            // dtpFfin
            // 
            this.dtpFfin.CustomFormat = "dd/MM/yy";
            this.dtpFfin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpFfin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFfin.Location = new System.Drawing.Point(810, 81);
            this.dtpFfin.Name = "dtpFfin";
            this.dtpFfin.Size = new System.Drawing.Size(74, 23);
            this.dtpFfin.TabIndex = 48;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "extraescolar",
            "complementaria"});
            this.cmbTipo.Location = new System.Drawing.Point(91, 71);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 24);
            this.cmbTipo.TabIndex = 50;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnActualizar.Location = new System.Drawing.Point(418, 771);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(86, 30);
            this.btnActualizar.TabIndex = 51;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // nudImporte
            // 
            this.nudImporte.DecimalPlaces = 2;
            this.nudImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nudImporte.Location = new System.Drawing.Point(190, 725);
            this.nudImporte.Name = "nudImporte";
            this.nudImporte.Size = new System.Drawing.Size(120, 23);
            this.nudImporte.TabIndex = 53;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblImporte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblImporte.Location = new System.Drawing.Point(27, 727);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(130, 17);
            this.lblImporte.TabIndex = 52;
            this.lblImporte.Text = "Importe por alumno";
            // 
            // rtxIncidencias
            // 
            this.rtxIncidencias.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rtxIncidencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxIncidencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtxIncidencias.Location = new System.Drawing.Point(307, 363);
            this.rtxIncidencias.Name = "rtxIncidencias";
            this.rtxIncidencias.Size = new System.Drawing.Size(230, 140);
            this.rtxIncidencias.TabIndex = 59;
            this.rtxIncidencias.Text = "Incidencias";
            // 
            // lblIncidencias
            // 
            this.lblIncidencias.AutoSize = true;
            this.lblIncidencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblIncidencias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIncidencias.Location = new System.Drawing.Point(304, 343);
            this.lblIncidencias.Name = "lblIncidencias";
            this.lblIncidencias.Size = new System.Drawing.Size(78, 17);
            this.lblIncidencias.TabIndex = 58;
            this.lblIncidencias.Text = "Incidencias";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnImprimir.Location = new System.Drawing.Point(727, 718);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(157, 30);
            this.btnImprimir.TabIndex = 60;
            this.btnImprimir.Text = "Imprimir Autorizacion";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnFotos
            // 
            this.btnFotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFotos.Location = new System.Drawing.Point(810, 635);
            this.btnFotos.Name = "btnFotos";
            this.btnFotos.Size = new System.Drawing.Size(62, 30);
            this.btnFotos.TabIndex = 63;
            this.btnFotos.Text = "Fotos";
            this.btnFotos.UseVisualStyleBackColor = true;
            this.btnFotos.Click += new System.EventHandler(this.btnFotos_Click);
            // 
            // btnContratos
            // 
            this.btnContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnContratos.Location = new System.Drawing.Point(659, 635);
            this.btnContratos.Name = "btnContratos";
            this.btnContratos.Size = new System.Drawing.Size(85, 30);
            this.btnContratos.TabIndex = 64;
            this.btnContratos.Text = "Contratos";
            this.btnContratos.UseVisualStyleBackColor = true;
            this.btnContratos.Click += new System.EventHandler(this.btnContratos_Click);
            // 
            // lvwgrupos
            // 
            this.lvwgrupos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lvwgrupos.HideSelection = false;
            this.lvwgrupos.Location = new System.Drawing.Point(584, 164);
            this.lvwgrupos.Name = "lvwgrupos";
            this.lvwgrupos.Size = new System.Drawing.Size(300, 140);
            this.lvwgrupos.TabIndex = 65;
            this.lvwgrupos.UseCompatibleStateImageBehavior = false;
            this.lvwgrupos.View = System.Windows.Forms.View.Details;
            // 
            // lvwProfesores
            // 
            this.lvwProfesores.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lvwProfesores.HideSelection = false;
            this.lvwProfesores.Location = new System.Drawing.Point(584, 416);
            this.lvwProfesores.Name = "lvwProfesores";
            this.lvwProfesores.Size = new System.Drawing.Size(300, 140);
            this.lvwProfesores.TabIndex = 66;
            this.lvwProfesores.UseCompatibleStateImageBehavior = false;
            this.lvwProfesores.View = System.Windows.Forms.View.Details;
            // 
            // lblProfesores
            // 
            this.lblProfesores.AutoSize = true;
            this.lblProfesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProfesores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProfesores.Location = new System.Drawing.Point(581, 393);
            this.lblProfesores.Name = "lblProfesores";
            this.lblProfesores.Size = new System.Drawing.Size(163, 17);
            this.lblProfesores.TabIndex = 67;
            this.lblProfesores.Text = "Profesores Participantes";
            // 
            // lblGrupos
            // 
            this.lblGrupos.AutoSize = true;
            this.lblGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGrupos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGrupos.Location = new System.Drawing.Point(581, 140);
            this.lblGrupos.Name = "lblGrupos";
            this.lblGrupos.Size = new System.Drawing.Size(141, 17);
            this.lblGrupos.TabIndex = 68;
            this.lblGrupos.Text = "Grupos Participantes";
            // 
            // btnAddGrupo
            // 
            this.btnAddGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddGrupo.Location = new System.Drawing.Point(755, 343);
            this.btnAddGrupo.Name = "btnAddGrupo";
            this.btnAddGrupo.Size = new System.Drawing.Size(129, 42);
            this.btnAddGrupo.TabIndex = 69;
            this.btnAddGrupo.Text = "Añadir/Modificar/ Quitar";
            this.btnAddGrupo.UseVisualStyleBackColor = true;
            this.btnAddGrupo.Click += new System.EventHandler(this.btnAddGrupo_Click);
            // 
            // btnAddProfesor
            // 
            this.btnAddProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddProfesor.Location = new System.Drawing.Point(781, 562);
            this.btnAddProfesor.Name = "btnAddProfesor";
            this.btnAddProfesor.Size = new System.Drawing.Size(103, 35);
            this.btnAddProfesor.TabIndex = 70;
            this.btnAddProfesor.Text = "Añadir/Quitar";
            this.btnAddProfesor.UseVisualStyleBackColor = true;
            this.btnAddProfesor.Click += new System.EventHandler(this.btnAddProfesor_Click);
            // 
            // cmbProfesores
            // 
            this.cmbProfesores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbProfesores.FormattingEnabled = true;
            this.cmbProfesores.Location = new System.Drawing.Point(584, 566);
            this.cmbProfesores.Name = "cmbProfesores";
            this.cmbProfesores.Size = new System.Drawing.Size(191, 24);
            this.cmbProfesores.TabIndex = 71;
            // 
            // lblNumALumnos
            // 
            this.lblNumALumnos.AutoSize = true;
            this.lblNumALumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNumALumnos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumALumnos.Location = new System.Drawing.Point(581, 350);
            this.lblNumALumnos.Name = "lblNumALumnos";
            this.lblNumALumnos.Size = new System.Drawing.Size(120, 17);
            this.lblNumALumnos.TabIndex = 72;
            this.lblNumALumnos.Text = "Numero Alumnos:";
            // 
            // nudAlumnos
            // 
            this.nudAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nudAlumnos.Location = new System.Drawing.Point(699, 348);
            this.nudAlumnos.Name = "nudAlumnos";
            this.nudAlumnos.Size = new System.Drawing.Size(45, 23);
            this.nudAlumnos.TabIndex = 73;
            // 
            // cmbGrupos
            // 
            this.cmbGrupos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbGrupos.FormattingEnabled = true;
            this.cmbGrupos.Location = new System.Drawing.Point(584, 313);
            this.cmbGrupos.Name = "cmbGrupos";
            this.cmbGrupos.Size = new System.Drawing.Size(208, 24);
            this.cmbGrupos.TabIndex = 74;
            // 
            // FrmVerActividadAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(899, 813);
            this.Controls.Add(this.cmbGrupos);
            this.Controls.Add(this.nudAlumnos);
            this.Controls.Add(this.lblNumALumnos);
            this.Controls.Add(this.cmbProfesores);
            this.Controls.Add(this.btnAddProfesor);
            this.Controls.Add(this.btnAddGrupo);
            this.Controls.Add(this.lblGrupos);
            this.Controls.Add(this.lblProfesores);
            this.Controls.Add(this.lvwProfesores);
            this.Controls.Add(this.lvwgrupos);
            this.Controls.Add(this.btnContratos);
            this.Controls.Add(this.btnFotos);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.rtxIncidencias);
            this.Controls.Add(this.lblIncidencias);
            this.Controls.Add(this.nudImporte);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.dtpHfin);
            this.Controls.Add(this.dtpFfin);
            this.Controls.Add(this.dtpHini);
            this.Controls.Add(this.dtpFini);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.rtxAlojamientoFalso);
            this.Controls.Add(this.rtxTransporteFalso);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.chkAlojamiento);
            this.Controls.Add(this.chkTransporte);
            this.Controls.Add(this.rtxAlojamiento);
            this.Controls.Add(this.rtxTransporte);
            this.Controls.Add(this.lblSolicitante);
            this.Controls.Add(this.rtxEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblComentarios);
            this.Controls.Add(this.rtxComentarios);
            this.Controls.Add(this.lblFfni);
            this.Controls.Add(this.lblFini);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.rtxDescripcion);
            this.Controls.Add(this.lblTipo);
            this.Name = "FrmVerActividadAdmin";
            this.Text = "Actividad";
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxAlojamiento;
        private System.Windows.Forms.RichTextBox rtxTransporte;
        private System.Windows.Forms.Label lblSolicitante;
        private System.Windows.Forms.RichTextBox rtxEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.RichTextBox rtxComentarios;
        private System.Windows.Forms.Label lblFfni;
        private System.Windows.Forms.Label lblFini;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.RichTextBox rtxDescripcion;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.CheckBox chkTransporte;
        private System.Windows.Forms.CheckBox chkAlojamiento;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.RichTextBox rtxTransporteFalso;
        private System.Windows.Forms.RichTextBox rtxAlojamientoFalso;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DateTimePicker dtpFini;
        private System.Windows.Forms.DateTimePicker dtpHini;
        private System.Windows.Forms.DateTimePicker dtpHfin;
        private System.Windows.Forms.DateTimePicker dtpFfin;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.NumericUpDown nudImporte;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.RichTextBox rtxIncidencias;
        private System.Windows.Forms.Label lblIncidencias;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnFotos;
        private System.Windows.Forms.Button btnContratos;
        private System.Windows.Forms.ListView lvwgrupos;
        private System.Windows.Forms.ListView lvwProfesores;
        private System.Windows.Forms.Label lblProfesores;
        private System.Windows.Forms.Label lblGrupos;
        private System.Windows.Forms.Button btnAddGrupo;
        private System.Windows.Forms.Button btnAddProfesor;
        private System.Windows.Forms.ComboBox cmbProfesores;
        private System.Windows.Forms.Label lblNumALumnos;
        private System.Windows.Forms.NumericUpDown nudAlumnos;
        private System.Windows.Forms.ComboBox cmbGrupos;
    }
}