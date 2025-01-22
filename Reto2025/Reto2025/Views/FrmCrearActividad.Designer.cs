namespace Reto2025.Views
{
    partial class FrmCrearActividad
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFechaIni = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblHoraIni = new System.Windows.Forms.Label();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.lblComentTransp = new System.Windows.Forms.Label();
            this.lblComentAloj = new System.Windows.Forms.Label();
            this.lblComentGen = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCometariosGenerales = new System.Windows.Forms.TextBox();
            this.txtComentTransp = new System.Windows.Forms.TextBox();
            this.txtComentAloj = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.dtpFini = new System.Windows.Forms.DateTimePicker();
            this.dtpFfin = new System.Windows.Forms.DateTimePicker();
            this.chkTransporte = new System.Windows.Forms.CheckBox();
            this.chkAlojamiento = new System.Windows.Forms.CheckBox();
            this.dtpHini = new System.Windows.Forms.DateTimePicker();
            this.dtpHfin = new System.Windows.Forms.DateTimePicker();
            this.nudImporte = new System.Windows.Forms.NumericUpDown();
            this.chkInicioPrevisto = new System.Windows.Forms.CheckBox();
            this.btnCrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTitulo.Location = new System.Drawing.Point(44, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(153, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo de la Actividad";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTipo.Location = new System.Drawing.Point(45, 96);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(131, 17);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo de la actividad";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDescripcion.Location = new System.Drawing.Point(45, 424);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(142, 17);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion actividad";
            // 
            // lblFechaIni
            // 
            this.lblFechaIni.AutoSize = true;
            this.lblFechaIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFechaIni.Location = new System.Drawing.Point(45, 151);
            this.lblFechaIni.Name = "lblFechaIni";
            this.lblFechaIni.Size = new System.Drawing.Size(83, 17);
            this.lblFechaIni.TabIndex = 3;
            this.lblFechaIni.Text = "Fecha inicio";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFechaFin.Location = new System.Drawing.Point(45, 180);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(66, 17);
            this.lblFechaFin.TabIndex = 4;
            this.lblFechaFin.Text = "Fecha fin";
            // 
            // lblHoraIni
            // 
            this.lblHoraIni.AutoSize = true;
            this.lblHoraIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHoraIni.Location = new System.Drawing.Point(45, 209);
            this.lblHoraIni.Name = "lblHoraIni";
            this.lblHoraIni.Size = new System.Drawing.Size(75, 17);
            this.lblHoraIni.TabIndex = 5;
            this.lblHoraIni.Text = "Hora inicio";
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHoraFin.Location = new System.Drawing.Point(45, 238);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(58, 17);
            this.lblHoraFin.TabIndex = 6;
            this.lblHoraFin.Text = "Hora fin";
            // 
            // lblComentTransp
            // 
            this.lblComentTransp.AutoSize = true;
            this.lblComentTransp.Enabled = false;
            this.lblComentTransp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblComentTransp.Location = new System.Drawing.Point(465, 259);
            this.lblComentTransp.Name = "lblComentTransp";
            this.lblComentTransp.Size = new System.Drawing.Size(177, 17);
            this.lblComentTransp.TabIndex = 9;
            this.lblComentTransp.Text = "Comentario del Transporte";
            // 
            // lblComentAloj
            // 
            this.lblComentAloj.AutoSize = true;
            this.lblComentAloj.Enabled = false;
            this.lblComentAloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblComentAloj.Location = new System.Drawing.Point(465, 424);
            this.lblComentAloj.Name = "lblComentAloj";
            this.lblComentAloj.Size = new System.Drawing.Size(179, 17);
            this.lblComentAloj.TabIndex = 11;
            this.lblComentAloj.Text = "Comentario del alojamiento";
            // 
            // lblComentGen
            // 
            this.lblComentGen.AutoSize = true;
            this.lblComentGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblComentGen.Location = new System.Drawing.Point(465, 96);
            this.lblComentGen.Name = "lblComentGen";
            this.lblComentGen.Size = new System.Drawing.Size(157, 17);
            this.lblComentGen.TabIndex = 12;
            this.lblComentGen.Text = "Comentarios Generales";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblImporte.Location = new System.Drawing.Point(45, 377);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(130, 17);
            this.lblImporte.TabIndex = 14;
            this.lblImporte.Text = "Importe por alumno";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTitulo.Location = new System.Drawing.Point(213, 20);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(367, 26);
            this.txtTitulo.TabIndex = 15;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDescripcion.Location = new System.Drawing.Point(34, 452);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(330, 130);
            this.txtDescripcion.TabIndex = 16;
            // 
            // txtCometariosGenerales
            // 
            this.txtCometariosGenerales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCometariosGenerales.Location = new System.Drawing.Point(453, 116);
            this.txtCometariosGenerales.Multiline = true;
            this.txtCometariosGenerales.Name = "txtCometariosGenerales";
            this.txtCometariosGenerales.Size = new System.Drawing.Size(330, 130);
            this.txtCometariosGenerales.TabIndex = 17;
            // 
            // txtComentTransp
            // 
            this.txtComentTransp.Enabled = false;
            this.txtComentTransp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtComentTransp.Location = new System.Drawing.Point(453, 282);
            this.txtComentTransp.Multiline = true;
            this.txtComentTransp.Name = "txtComentTransp";
            this.txtComentTransp.Size = new System.Drawing.Size(330, 130);
            this.txtComentTransp.TabIndex = 18;
            // 
            // txtComentAloj
            // 
            this.txtComentAloj.Enabled = false;
            this.txtComentAloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtComentAloj.Location = new System.Drawing.Point(453, 452);
            this.txtComentAloj.Multiline = true;
            this.txtComentAloj.Name = "txtComentAloj";
            this.txtComentAloj.Size = new System.Drawing.Size(330, 130);
            this.txtComentAloj.TabIndex = 20;
            // 
            // cmbTipo
            // 
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Extraescolar",
            "Complementaria"});
            this.cmbTipo.Location = new System.Drawing.Point(182, 93);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 24);
            this.cmbTipo.TabIndex = 22;
            this.cmbTipo.Text = "Extraescolar";
            // 
            // dtpFini
            // 
            this.dtpFini.CustomFormat = "dd-mm-yyyy";
            this.dtpFini.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpFini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFini.Location = new System.Drawing.Point(171, 146);
            this.dtpFini.Name = "dtpFini";
            this.dtpFini.Size = new System.Drawing.Size(95, 23);
            this.dtpFini.TabIndex = 23;
            // 
            // dtpFfin
            // 
            this.dtpFfin.CustomFormat = "dd-mm-yyyy";
            this.dtpFfin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpFfin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFfin.Location = new System.Drawing.Point(171, 175);
            this.dtpFfin.Name = "dtpFfin";
            this.dtpFfin.Size = new System.Drawing.Size(95, 23);
            this.dtpFfin.TabIndex = 24;
            // 
            // chkTransporte
            // 
            this.chkTransporte.AutoSize = true;
            this.chkTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkTransporte.Location = new System.Drawing.Point(48, 300);
            this.chkTransporte.Name = "chkTransporte";
            this.chkTransporte.Size = new System.Drawing.Size(159, 21);
            this.chkTransporte.TabIndex = 25;
            this.chkTransporte.Text = "Requiere Transporte";
            this.chkTransporte.UseVisualStyleBackColor = true;
            this.chkTransporte.CheckedChanged += new System.EventHandler(this.chck_transporte_CheckedChanged);
            // 
            // chkAlojamiento
            // 
            this.chkAlojamiento.AutoSize = true;
            this.chkAlojamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkAlojamiento.Location = new System.Drawing.Point(48, 333);
            this.chkAlojamiento.Name = "chkAlojamiento";
            this.chkAlojamiento.Size = new System.Drawing.Size(162, 21);
            this.chkAlojamiento.TabIndex = 26;
            this.chkAlojamiento.Text = "Requiere Alojamiento";
            this.chkAlojamiento.UseVisualStyleBackColor = true;
            this.chkAlojamiento.CheckedChanged += new System.EventHandler(this.chkAlojamiento_CheckedChanged);
            // 
            // dtpHini
            // 
            this.dtpHini.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpHini.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHini.Location = new System.Drawing.Point(171, 204);
            this.dtpHini.Name = "dtpHini";
            this.dtpHini.ShowUpDown = true;
            this.dtpHini.Size = new System.Drawing.Size(95, 23);
            this.dtpHini.TabIndex = 27;
            // 
            // dtpHfin
            // 
            this.dtpHfin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpHfin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHfin.Location = new System.Drawing.Point(171, 233);
            this.dtpHfin.Name = "dtpHfin";
            this.dtpHfin.ShowUpDown = true;
            this.dtpHfin.Size = new System.Drawing.Size(95, 23);
            this.dtpHfin.TabIndex = 28;
            // 
            // nudImporte
            // 
            this.nudImporte.DecimalPlaces = 2;
            this.nudImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nudImporte.Location = new System.Drawing.Point(192, 375);
            this.nudImporte.Name = "nudImporte";
            this.nudImporte.Size = new System.Drawing.Size(120, 23);
            this.nudImporte.TabIndex = 40;
            // 
            // chkInicioPrevisto
            // 
            this.chkInicioPrevisto.AutoSize = true;
            this.chkInicioPrevisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkInicioPrevisto.Location = new System.Drawing.Point(48, 268);
            this.chkInicioPrevisto.Name = "chkInicioPrevisto";
            this.chkInicioPrevisto.Size = new System.Drawing.Size(204, 21);
            this.chkInicioPrevisto.TabIndex = 41;
            this.chkInicioPrevisto.Text = "Prevista en la programacion";
            this.chkInicioPrevisto.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCrear.Location = new System.Drawing.Point(372, 604);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(115, 23);
            this.btnCrear.TabIndex = 42;
            this.btnCrear.Text = "Crear Actividad";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_ClickAsync);
            // 
            // FrmCrearActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 639);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.chkInicioPrevisto);
            this.Controls.Add(this.nudImporte);
            this.Controls.Add(this.dtpHfin);
            this.Controls.Add(this.dtpHini);
            this.Controls.Add(this.chkAlojamiento);
            this.Controls.Add(this.chkTransporte);
            this.Controls.Add(this.dtpFfin);
            this.Controls.Add(this.dtpFini);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtComentAloj);
            this.Controls.Add(this.txtComentTransp);
            this.Controls.Add(this.txtCometariosGenerales);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.lblComentGen);
            this.Controls.Add(this.lblComentAloj);
            this.Controls.Add(this.lblComentTransp);
            this.Controls.Add(this.lblHoraFin);
            this.Controls.Add(this.lblHoraIni);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaIni);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmCrearActividad";
            this.Text = "Creacion Actividades";
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFechaIni;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblHoraIni;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.Label lblComentTransp;
        private System.Windows.Forms.Label lblComentAloj;
        private System.Windows.Forms.Label lblComentGen;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCometariosGenerales;
        private System.Windows.Forms.TextBox txtComentTransp;
        private System.Windows.Forms.TextBox txtComentAloj;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.DateTimePicker dtpFini;
        private System.Windows.Forms.DateTimePicker dtpFfin;
        private System.Windows.Forms.CheckBox chkTransporte;
        private System.Windows.Forms.CheckBox chkAlojamiento;
        private System.Windows.Forms.DateTimePicker dtpHfin;
        private System.Windows.Forms.NumericUpDown nudImporte;
        private System.Windows.Forms.CheckBox chkInicioPrevisto;
        private System.Windows.Forms.DateTimePicker dtpHini;
        private System.Windows.Forms.Button btnCrear;
    }
}