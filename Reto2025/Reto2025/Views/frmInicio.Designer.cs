namespace Reto2025.Views
{
    partial class FrmInicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_crearActividades = new System.Windows.Forms.ToolStripMenuItem();
            this.verActividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_verCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_verProfesores = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_verDepartamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasDeTransporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_verEmpresas = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirEmpresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_perfil = new System.Windows.Forms.ToolStripMenuItem();
            this.normativaYFAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normativaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_mesSiguiente = new System.Windows.Forms.Button();
            this.btn_mesAnterior = new System.Windows.Forms.Button();
            this.lbl_lunes = new System.Windows.Forms.Label();
            this.lbl_martes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.activityContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_actividadesdia = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actividadesToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.profesoresToolStripMenuItem,
            this.departamentosToolStripMenuItem,
            this.empresasDeTransporteToolStripMenuItem,
            this.tsmi_perfil,
            this.normativaYFAQToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1184, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actividadesToolStripMenuItem
            // 
            this.actividadesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.actividadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_crearActividades,
            this.verActividadesToolStripMenuItem});
            this.actividadesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.actividadesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.actividadesToolStripMenuItem.Name = "actividadesToolStripMenuItem";
            this.actividadesToolStripMenuItem.Size = new System.Drawing.Size(90, 23);
            this.actividadesToolStripMenuItem.Text = "Actividades";
            // 
            // tsmi_crearActividades
            // 
            this.tsmi_crearActividades.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tsmi_crearActividades.Name = "tsmi_crearActividades";
            this.tsmi_crearActividades.Size = new System.Drawing.Size(184, 24);
            this.tsmi_crearActividades.Text = "Crear Actividades";
            this.tsmi_crearActividades.Click += new System.EventHandler(this.tsmi_crearActividades_Click);
            // 
            // verActividadesToolStripMenuItem
            // 
            this.verActividadesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.verActividadesToolStripMenuItem.Name = "verActividadesToolStripMenuItem";
            this.verActividadesToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.verActividadesToolStripMenuItem.Text = "Ver Actividades";
            this.verActividadesToolStripMenuItem.Click += new System.EventHandler(this.verActividadesToolStripMenuItem_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_verCursos});
            this.cursosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cursosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(63, 23);
            this.cursosToolStripMenuItem.Text = "Cursos";
            // 
            // tsmi_verCursos
            // 
            this.tsmi_verCursos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tsmi_verCursos.Name = "tsmi_verCursos";
            this.tsmi_verCursos.Size = new System.Drawing.Size(144, 24);
            this.tsmi_verCursos.Text = "Ver Cursos";
            this.tsmi_verCursos.Click += new System.EventHandler(this.tsmi_verCursos_Click);
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_verProfesores});
            this.profesoresToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.profesoresToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(85, 23);
            this.profesoresToolStripMenuItem.Text = "Profesores";
            // 
            // tsmi_verProfesores
            // 
            this.tsmi_verProfesores.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tsmi_verProfesores.Name = "tsmi_verProfesores";
            this.tsmi_verProfesores.Size = new System.Drawing.Size(166, 24);
            this.tsmi_verProfesores.Text = "Ver profesores";
            this.tsmi_verProfesores.Click += new System.EventHandler(this.tsmi_verProfesores_Click);
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_verDepartamentos});
            this.departamentosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.departamentosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(116, 23);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            // 
            // tsmi_verDepartamentos
            // 
            this.tsmi_verDepartamentos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tsmi_verDepartamentos.Name = "tsmi_verDepartamentos";
            this.tsmi_verDepartamentos.Size = new System.Drawing.Size(197, 24);
            this.tsmi_verDepartamentos.Text = "Ver Departamentos";
            this.tsmi_verDepartamentos.Click += new System.EventHandler(this.tsmi_verDepartamentos_Click);
            // 
            // empresasDeTransporteToolStripMenuItem
            // 
            this.empresasDeTransporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_verEmpresas,
            this.añadirEmpresasToolStripMenuItem});
            this.empresasDeTransporteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.empresasDeTransporteToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.empresasDeTransporteToolStripMenuItem.Name = "empresasDeTransporteToolStripMenuItem";
            this.empresasDeTransporteToolStripMenuItem.Size = new System.Drawing.Size(166, 23);
            this.empresasDeTransporteToolStripMenuItem.Text = "Empresas de transporte";
            // 
            // tsmi_verEmpresas
            // 
            this.tsmi_verEmpresas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tsmi_verEmpresas.Name = "tsmi_verEmpresas";
            this.tsmi_verEmpresas.Size = new System.Drawing.Size(167, 24);
            this.tsmi_verEmpresas.Text = "Ver Empresas";
            this.tsmi_verEmpresas.Click += new System.EventHandler(this.tsmi_verEmpresas_Click);
            // 
            // añadirEmpresasToolStripMenuItem
            // 
            this.añadirEmpresasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.añadirEmpresasToolStripMenuItem.Name = "añadirEmpresasToolStripMenuItem";
            this.añadirEmpresasToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.añadirEmpresasToolStripMenuItem.Text = "Crear Empresa";
            this.añadirEmpresasToolStripMenuItem.Click += new System.EventHandler(this.añadirEmpresasToolStripMenuItem_Click);
            // 
            // tsmi_perfil
            // 
            this.tsmi_perfil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmi_perfil.ForeColor = System.Drawing.Color.Black;
            this.tsmi_perfil.Name = "tsmi_perfil";
            this.tsmi_perfil.Size = new System.Drawing.Size(50, 23);
            this.tsmi_perfil.Text = "Perfil";
            this.tsmi_perfil.Click += new System.EventHandler(this.tsmi_perfil_Click);
            // 
            // normativaYFAQToolStripMenuItem
            // 
            this.normativaYFAQToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normativaToolStripMenuItem,
            this.fAQToolStripMenuItem});
            this.normativaYFAQToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.normativaYFAQToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.normativaYFAQToolStripMenuItem.Name = "normativaYFAQToolStripMenuItem";
            this.normativaYFAQToolStripMenuItem.Size = new System.Drawing.Size(133, 23);
            this.normativaYFAQToolStripMenuItem.Text = "Normativa y F.A.Q";
            // 
            // normativaToolStripMenuItem
            // 
            this.normativaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.normativaToolStripMenuItem.Name = "normativaToolStripMenuItem";
            this.normativaToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.normativaToolStripMenuItem.Text = "Normativa";
            this.normativaToolStripMenuItem.Click += new System.EventHandler(this.normativaToolStripMenuItem_Click);
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.fAQToolStripMenuItem.Text = "F.A.Q";
            this.fAQToolStripMenuItem.Click += new System.EventHandler(this.fAQToolStripMenuItem_Click);
            // 
            // daycontainer
            // 
            this.daycontainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.daycontainer.Location = new System.Drawing.Point(5, 96);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(943, 575);
            this.daycontainer.TabIndex = 1;
            // 
            // btn_mesSiguiente
            // 
            this.btn_mesSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_mesSiguiente.Location = new System.Drawing.Point(617, 669);
            this.btn_mesSiguiente.Name = "btn_mesSiguiente";
            this.btn_mesSiguiente.Size = new System.Drawing.Size(80, 30);
            this.btn_mesSiguiente.TabIndex = 2;
            this.btn_mesSiguiente.Text = "Siguiente";
            this.btn_mesSiguiente.UseVisualStyleBackColor = true;
            this.btn_mesSiguiente.Click += new System.EventHandler(this.btn_mesSiguiente_Click);
            // 
            // btn_mesAnterior
            // 
            this.btn_mesAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_mesAnterior.Location = new System.Drawing.Point(472, 669);
            this.btn_mesAnterior.Name = "btn_mesAnterior";
            this.btn_mesAnterior.Size = new System.Drawing.Size(76, 30);
            this.btn_mesAnterior.TabIndex = 3;
            this.btn_mesAnterior.Text = "Anterior";
            this.btn_mesAnterior.UseVisualStyleBackColor = true;
            this.btn_mesAnterior.Click += new System.EventHandler(this.btn_mesAnterior_Click);
            // 
            // lbl_lunes
            // 
            this.lbl_lunes.AutoSize = true;
            this.lbl_lunes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_lunes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_lunes.Location = new System.Drawing.Point(37, 76);
            this.lbl_lunes.Name = "lbl_lunes";
            this.lbl_lunes.Size = new System.Drawing.Size(47, 17);
            this.lbl_lunes.TabIndex = 4;
            this.lbl_lunes.Text = "Lunes";
            // 
            // lbl_martes
            // 
            this.lbl_martes.AutoSize = true;
            this.lbl_martes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_martes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_martes.Location = new System.Drawing.Point(170, 76);
            this.lbl_martes.Name = "lbl_martes";
            this.lbl_martes.Size = new System.Drawing.Size(51, 17);
            this.lbl_martes.TabIndex = 5;
            this.lbl_martes.Text = "Martes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(303, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Miercoles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(436, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Jueves";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(567, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Viernes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(697, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sabado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(829, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Domingo";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMes.Location = new System.Drawing.Point(420, 38);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(96, 20);
            this.lblMes.TabIndex = 11;
            this.lblMes.Text = "Mes actual";
            this.lblMes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // activityContainer
            // 
            this.activityContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.activityContainer.Location = new System.Drawing.Point(954, 96);
            this.activityContainer.Name = "activityContainer";
            this.activityContainer.Size = new System.Drawing.Size(220, 575);
            this.activityContainer.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(974, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 13;
            // 
            // lbl_actividadesdia
            // 
            this.lbl_actividadesdia.AutoSize = true;
            this.lbl_actividadesdia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_actividadesdia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_actividadesdia.Location = new System.Drawing.Point(1003, 76);
            this.lbl_actividadesdia.Name = "lbl_actividadesdia";
            this.lbl_actividadesdia.Size = new System.Drawing.Size(126, 17);
            this.lbl_actividadesdia.TabIndex = 14;
            this.lbl_actividadesdia.Text = "Actividades del dia";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.lbl_actividadesdia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.activityContainer);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_martes);
            this.Controls.Add(this.lbl_lunes);
            this.Controls.Add(this.btn_mesAnterior);
            this.Controls.Add(this.btn_mesSiguiente);
            this.Controls.Add(this.daycontainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1200, 750);
            this.MinimumSize = new System.Drawing.Size(1200, 750);
            this.Name = "FrmInicio";
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_crearActividades;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_verCursos;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_verProfesores;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_verDepartamentos;
        private System.Windows.Forms.ToolStripMenuItem empresasDeTransporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_perfil;
        private System.Windows.Forms.ToolStripMenuItem tsmi_verEmpresas;
        private System.Windows.Forms.FlowLayoutPanel daycontainer;
        private System.Windows.Forms.Button btn_mesSiguiente;
        private System.Windows.Forms.Button btn_mesAnterior;
        private System.Windows.Forms.Label lbl_lunes;
        private System.Windows.Forms.Label lbl_martes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.ToolStripMenuItem normativaYFAQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normativaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel activityContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_actividadesdia;
        private System.Windows.Forms.ToolStripMenuItem verActividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirEmpresasToolStripMenuItem;
    }
}