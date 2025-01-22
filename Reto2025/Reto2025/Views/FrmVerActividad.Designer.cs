namespace Reto2025.Views
{
    partial class FrmVerActividad
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
            this.rtxDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFini = new System.Windows.Forms.Label();
            this.lblFfni = new System.Windows.Forms.Label();
            this.lblHini = new System.Windows.Forms.Label();
            this.lblHfni = new System.Windows.Forms.Label();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.rtxComentarios = new System.Windows.Forms.RichTextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.rtxEstado = new System.Windows.Forms.RichTextBox();
            this.lblSolicitante = new System.Windows.Forms.Label();
            this.btnGrupos = new System.Windows.Forms.Button();
            this.btnProfesores = new System.Windows.Forms.Button();
            this.lvwGeneral = new System.Windows.Forms.ListView();
            this.rtxAlojamiento = new System.Windows.Forms.RichTextBox();
            this.lblAlojamiento = new System.Windows.Forms.Label();
            this.lblTransporte = new System.Windows.Forms.Label();
            this.rtxTransporte = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblIncidencias = new System.Windows.Forms.Label();
            this.rtxIncidencias = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTitulo.Location = new System.Drawing.Point(26, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(47, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTipo.Location = new System.Drawing.Point(27, 58);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(97, 17);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Actividad Tipo";
            // 
            // rtxDescripcion
            // 
            this.rtxDescripcion.BackColor = System.Drawing.SystemColors.Control;
            this.rtxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtxDescripcion.Location = new System.Drawing.Point(30, 149);
            this.rtxDescripcion.Name = "rtxDescripcion";
            this.rtxDescripcion.ReadOnly = true;
            this.rtxDescripcion.Size = new System.Drawing.Size(231, 140);
            this.rtxDescripcion.TabIndex = 2;
            this.rtxDescripcion.Text = "Descripcion";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDescripcion.Location = new System.Drawing.Point(27, 129);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 17);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblFini
            // 
            this.lblFini.AutoSize = true;
            this.lblFini.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFini.Location = new System.Drawing.Point(736, 18);
            this.lblFini.Name = "lblFini";
            this.lblFini.Size = new System.Drawing.Size(147, 17);
            this.lblFini.TabIndex = 4;
            this.lblFini.Text = "Fecha Inicio: 16/07/25";
            // 
            // lblFfni
            // 
            this.lblFfni.AutoSize = true;
            this.lblFfni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFfni.Location = new System.Drawing.Point(749, 78);
            this.lblFfni.Name = "lblFfni";
            this.lblFfni.Size = new System.Drawing.Size(134, 17);
            this.lblFfni.TabIndex = 5;
            this.lblFfni.Text = "Fecha Fin: 16/07/25";
            // 
            // lblHini
            // 
            this.lblHini.AutoSize = true;
            this.lblHini.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHini.Location = new System.Drawing.Point(839, 38);
            this.lblHini.Name = "lblHini";
            this.lblHini.Size = new System.Drawing.Size(44, 17);
            this.lblHini.TabIndex = 6;
            this.lblHini.Text = "16:00";
            // 
            // lblHfni
            // 
            this.lblHfni.AutoSize = true;
            this.lblHfni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHfni.Location = new System.Drawing.Point(839, 98);
            this.lblHfni.Name = "lblHfni";
            this.lblHfni.Size = new System.Drawing.Size(44, 17);
            this.lblHfni.TabIndex = 7;
            this.lblHfni.Text = "16:00";
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblComentarios.Location = new System.Drawing.Point(27, 328);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(87, 17);
            this.lblComentarios.TabIndex = 9;
            this.lblComentarios.Text = "Comentarios";
            // 
            // rtxComentarios
            // 
            this.rtxComentarios.BackColor = System.Drawing.SystemColors.Control;
            this.rtxComentarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxComentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtxComentarios.Location = new System.Drawing.Point(30, 348);
            this.rtxComentarios.Name = "rtxComentarios";
            this.rtxComentarios.ReadOnly = true;
            this.rtxComentarios.Size = new System.Drawing.Size(231, 140);
            this.rtxComentarios.TabIndex = 8;
            this.rtxComentarios.Text = "Comentarios";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEstado.Location = new System.Drawing.Point(304, 129);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(52, 17);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado";
            // 
            // rtxEstado
            // 
            this.rtxEstado.BackColor = System.Drawing.SystemColors.Control;
            this.rtxEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtxEstado.Location = new System.Drawing.Point(307, 149);
            this.rtxEstado.Name = "rtxEstado";
            this.rtxEstado.ReadOnly = true;
            this.rtxEstado.Size = new System.Drawing.Size(231, 140);
            this.rtxEstado.TabIndex = 11;
            this.rtxEstado.Text = "Comentario estado";
            // 
            // lblSolicitante
            // 
            this.lblSolicitante.AutoSize = true;
            this.lblSolicitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSolicitante.Location = new System.Drawing.Point(27, 85);
            this.lblSolicitante.Name = "lblSolicitante";
            this.lblSolicitante.Size = new System.Drawing.Size(73, 17);
            this.lblSolicitante.TabIndex = 12;
            this.lblSolicitante.Text = "Solicitante";
            // 
            // btnGrupos
            // 
            this.btnGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGrupos.Location = new System.Drawing.Point(584, 113);
            this.btnGrupos.Name = "btnGrupos";
            this.btnGrupos.Size = new System.Drawing.Size(86, 30);
            this.btnGrupos.TabIndex = 13;
            this.btnGrupos.Text = "Grupos";
            this.btnGrupos.UseVisualStyleBackColor = true;
            this.btnGrupos.Click += new System.EventHandler(this.btnGrupos_Click);
            // 
            // btnProfesores
            // 
            this.btnProfesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnProfesores.Location = new System.Drawing.Point(729, 113);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Size = new System.Drawing.Size(86, 30);
            this.btnProfesores.TabIndex = 14;
            this.btnProfesores.Text = "Profesores";
            this.btnProfesores.UseVisualStyleBackColor = true;
            this.btnProfesores.Click += new System.EventHandler(this.btnProfesores_Click);
            // 
            // lvwGeneral
            // 
            this.lvwGeneral.HideSelection = false;
            this.lvwGeneral.Location = new System.Drawing.Point(584, 149);
            this.lvwGeneral.Name = "lvwGeneral";
            this.lvwGeneral.Size = new System.Drawing.Size(231, 140);
            this.lvwGeneral.TabIndex = 15;
            this.lvwGeneral.UseCompatibleStateImageBehavior = false;
            this.lvwGeneral.View = System.Windows.Forms.View.Details;
            // 
            // rtxAlojamiento
            // 
            this.rtxAlojamiento.BackColor = System.Drawing.SystemColors.Control;
            this.rtxAlojamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxAlojamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtxAlojamiento.Location = new System.Drawing.Point(307, 547);
            this.rtxAlojamiento.Name = "rtxAlojamiento";
            this.rtxAlojamiento.ReadOnly = true;
            this.rtxAlojamiento.Size = new System.Drawing.Size(231, 140);
            this.rtxAlojamiento.TabIndex = 19;
            this.rtxAlojamiento.Text = "Alojamiento no requerido";
            // 
            // lblAlojamiento
            // 
            this.lblAlojamiento.AutoSize = true;
            this.lblAlojamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAlojamiento.Location = new System.Drawing.Point(304, 527);
            this.lblAlojamiento.Name = "lblAlojamiento";
            this.lblAlojamiento.Size = new System.Drawing.Size(81, 17);
            this.lblAlojamiento.TabIndex = 18;
            this.lblAlojamiento.Text = "Alojamiento";
            // 
            // lblTransporte
            // 
            this.lblTransporte.AutoSize = true;
            this.lblTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTransporte.Location = new System.Drawing.Point(27, 527);
            this.lblTransporte.Name = "lblTransporte";
            this.lblTransporte.Size = new System.Drawing.Size(78, 17);
            this.lblTransporte.TabIndex = 17;
            this.lblTransporte.Text = "Transporte";
            // 
            // rtxTransporte
            // 
            this.rtxTransporte.BackColor = System.Drawing.SystemColors.Control;
            this.rtxTransporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtxTransporte.Location = new System.Drawing.Point(30, 547);
            this.rtxTransporte.Name = "rtxTransporte";
            this.rtxTransporte.ReadOnly = true;
            this.rtxTransporte.Size = new System.Drawing.Size(231, 140);
            this.rtxTransporte.TabIndex = 16;
            this.rtxTransporte.Text = "Transporte no requerido";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(544, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "Grupos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblIncidencias
            // 
            this.lblIncidencias.AutoSize = true;
            this.lblIncidencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblIncidencias.Location = new System.Drawing.Point(304, 328);
            this.lblIncidencias.Name = "lblIncidencias";
            this.lblIncidencias.Size = new System.Drawing.Size(78, 17);
            this.lblIncidencias.TabIndex = 21;
            this.lblIncidencias.Text = "Incidencias";
            // 
            // rtxIncidencias
            // 
            this.rtxIncidencias.BackColor = System.Drawing.SystemColors.Control;
            this.rtxIncidencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxIncidencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtxIncidencias.Location = new System.Drawing.Point(307, 348);
            this.rtxIncidencias.Name = "rtxIncidencias";
            this.rtxIncidencias.ReadOnly = true;
            this.rtxIncidencias.Size = new System.Drawing.Size(231, 140);
            this.rtxIncidencias.TabIndex = 23;
            this.rtxIncidencias.Text = "Incidencias";
            // 
            // FrmVerActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 711);
            this.Controls.Add(this.rtxIncidencias);
            this.Controls.Add(this.lblIncidencias);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtxAlojamiento);
            this.Controls.Add(this.lblAlojamiento);
            this.Controls.Add(this.lblTransporte);
            this.Controls.Add(this.rtxTransporte);
            this.Controls.Add(this.lvwGeneral);
            this.Controls.Add(this.btnProfesores);
            this.Controls.Add(this.btnGrupos);
            this.Controls.Add(this.lblSolicitante);
            this.Controls.Add(this.rtxEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblComentarios);
            this.Controls.Add(this.rtxComentarios);
            this.Controls.Add(this.lblHfni);
            this.Controls.Add(this.lblHini);
            this.Controls.Add(this.lblFfni);
            this.Controls.Add(this.lblFini);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.rtxDescripcion);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmVerActividad";
            this.Text = "Actividad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.RichTextBox rtxDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFini;
        private System.Windows.Forms.Label lblFfni;
        private System.Windows.Forms.Label lblHini;
        private System.Windows.Forms.Label lblHfni;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.RichTextBox rtxComentarios;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.RichTextBox rtxEstado;
        private System.Windows.Forms.Label lblSolicitante;
        private System.Windows.Forms.Button btnGrupos;
        private System.Windows.Forms.Button btnProfesores;
        private System.Windows.Forms.ListView lvwGeneral;
        private System.Windows.Forms.RichTextBox rtxAlojamiento;
        private System.Windows.Forms.Label lblAlojamiento;
        private System.Windows.Forms.Label lblTransporte;
        private System.Windows.Forms.RichTextBox rtxTransporte;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblIncidencias;
        private System.Windows.Forms.RichTextBox rtxIncidencias;
    }
}