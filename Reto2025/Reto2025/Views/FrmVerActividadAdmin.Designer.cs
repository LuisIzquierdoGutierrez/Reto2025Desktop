namespace Reto2025.Views
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
            this.lvwGeneral = new System.Windows.Forms.ListView();
            this.btnProfesores = new System.Windows.Forms.Button();
            this.btnGrupos = new System.Windows.Forms.Button();
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
            this.button1 = new System.Windows.Forms.Button();
            this.rtxIncidencias = new System.Windows.Forms.RichTextBox();
            this.lblIncidencias = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxAlojamiento
            // 
            this.rtxAlojamiento.BackColor = System.Drawing.SystemColors.Control;
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
            this.rtxTransporte.BackColor = System.Drawing.SystemColors.Control;
            this.rtxTransporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtxTransporte.Location = new System.Drawing.Point(30, 562);
            this.rtxTransporte.Name = "rtxTransporte";
            this.rtxTransporte.Size = new System.Drawing.Size(230, 140);
            this.rtxTransporte.TabIndex = 36;
            this.rtxTransporte.Text = "";
            // 
            // lvwGeneral
            // 
            this.lvwGeneral.HideSelection = false;
            this.lvwGeneral.Location = new System.Drawing.Point(584, 149);
            this.lvwGeneral.Name = "lvwGeneral";
            this.lvwGeneral.Size = new System.Drawing.Size(300, 140);
            this.lvwGeneral.TabIndex = 35;
            this.lvwGeneral.UseCompatibleStateImageBehavior = false;
            this.lvwGeneral.View = System.Windows.Forms.View.Details;
            // 
            // btnProfesores
            // 
            this.btnProfesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnProfesores.Location = new System.Drawing.Point(778, 321);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Size = new System.Drawing.Size(86, 30);
            this.btnProfesores.TabIndex = 34;
            this.btnProfesores.Text = "Profesores";
            this.btnProfesores.UseVisualStyleBackColor = true;
            // 
            // btnGrupos
            // 
            this.btnGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGrupos.Location = new System.Drawing.Point(584, 321);
            this.btnGrupos.Name = "btnGrupos";
            this.btnGrupos.Size = new System.Drawing.Size(86, 30);
            this.btnGrupos.TabIndex = 33;
            this.btnGrupos.Text = "Grupos";
            this.btnGrupos.UseVisualStyleBackColor = true;
            this.btnGrupos.Click += new System.EventHandler(this.btnGrupos_Click);
            // 
            // lblSolicitante
            // 
            this.lblSolicitante.AutoSize = true;
            this.lblSolicitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSolicitante.Location = new System.Drawing.Point(27, 109);
            this.lblSolicitante.Name = "lblSolicitante";
            this.lblSolicitante.Size = new System.Drawing.Size(73, 17);
            this.lblSolicitante.TabIndex = 32;
            this.lblSolicitante.Text = "Solicitante";
            // 
            // rtxEstado
            // 
            this.rtxEstado.BackColor = System.Drawing.SystemColors.Control;
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
            this.lblComentarios.Location = new System.Drawing.Point(27, 343);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(87, 17);
            this.lblComentarios.TabIndex = 29;
            this.lblComentarios.Text = "Comentarios";
            // 
            // rtxComentarios
            // 
            this.rtxComentarios.BackColor = System.Drawing.SystemColors.Control;
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
            this.lblDescripcion.Location = new System.Drawing.Point(27, 144);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 17);
            this.lblDescripcion.TabIndex = 23;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // rtxDescripcion
            // 
            this.rtxDescripcion.BackColor = System.Drawing.SystemColors.Control;
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
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTitulo.Location = new System.Drawing.Point(30, 19);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(413, 26);
            this.txtTitulo.TabIndex = 42;
            this.txtTitulo.Text = "Titulo";
            // 
            // rtxTransporteFalso
            // 
            this.rtxTransporteFalso.BackColor = System.Drawing.SystemColors.Control;
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
            this.rtxAlojamientoFalso.BackColor = System.Drawing.SystemColors.Control;
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
            this.btnActualizar.Location = new System.Drawing.Point(305, 772);
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
            this.lblImporte.Location = new System.Drawing.Point(27, 727);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(130, 17);
            this.lblImporte.TabIndex = 52;
            this.lblImporte.Text = "Importe por alumno";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(266, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 30);
            this.button1.TabIndex = 57;
            this.button1.Text = "Grupos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rtxIncidencias
            // 
            this.rtxIncidencias.BackColor = System.Drawing.SystemColors.Control;
            this.rtxIncidencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxIncidencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtxIncidencias.Location = new System.Drawing.Point(307, 363);
            this.rtxIncidencias.Name = "rtxIncidencias";
            this.rtxIncidencias.ReadOnly = true;
            this.rtxIncidencias.Size = new System.Drawing.Size(230, 140);
            this.rtxIncidencias.TabIndex = 59;
            this.rtxIncidencias.Text = "Incidencias";
            // 
            // lblIncidencias
            // 
            this.lblIncidencias.AutoSize = true;
            this.lblIncidencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblIncidencias.Location = new System.Drawing.Point(304, 343);
            this.lblIncidencias.Name = "lblIncidencias";
            this.lblIncidencias.Size = new System.Drawing.Size(78, 17);
            this.lblIncidencias.TabIndex = 58;
            this.lblIncidencias.Text = "Incidencias";
            // 
            // FrmVerActividadAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 761);
            this.Controls.Add(this.rtxIncidencias);
            this.Controls.Add(this.lblIncidencias);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.lvwGeneral);
            this.Controls.Add(this.btnProfesores);
            this.Controls.Add(this.btnGrupos);
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
            this.Text = "FrmVerActividadAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxAlojamiento;
        private System.Windows.Forms.RichTextBox rtxTransporte;
        private System.Windows.Forms.ListView lvwGeneral;
        private System.Windows.Forms.Button btnProfesores;
        private System.Windows.Forms.Button btnGrupos;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtxIncidencias;
        private System.Windows.Forms.Label lblIncidencias;
    }
}