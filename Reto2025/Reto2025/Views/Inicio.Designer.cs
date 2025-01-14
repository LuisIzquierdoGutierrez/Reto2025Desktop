namespace Reto2025.Views
{
    partial class Inicio
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
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_verCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_verProfesores = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_verDepartamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasDeTransporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_verEmpresas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_perfil = new System.Windows.Forms.ToolStripMenuItem();
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
            this.lbl_mes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actividadesToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.profesoresToolStripMenuItem,
            this.departamentosToolStripMenuItem,
            this.empresasDeTransporteToolStripMenuItem,
            this.tsmi_perfil});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(951, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actividadesToolStripMenuItem
            // 
            this.actividadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_crearActividades});
            this.actividadesToolStripMenuItem.Name = "actividadesToolStripMenuItem";
            this.actividadesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.actividadesToolStripMenuItem.Text = "Actividades";
            // 
            // tsmi_crearActividades
            // 
            this.tsmi_crearActividades.Name = "tsmi_crearActividades";
            this.tsmi_crearActividades.Size = new System.Drawing.Size(166, 22);
            this.tsmi_crearActividades.Text = "Crear Actividades";
            this.tsmi_crearActividades.Click += new System.EventHandler(this.tsmi_crearActividades_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_verCursos});
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cursosToolStripMenuItem.Text = "Cursos";
            // 
            // tsmi_verCursos
            // 
            this.tsmi_verCursos.Name = "tsmi_verCursos";
            this.tsmi_verCursos.Size = new System.Drawing.Size(129, 22);
            this.tsmi_verCursos.Text = "Ver Cursos";
            this.tsmi_verCursos.Click += new System.EventHandler(this.tsmi_verCursos_Click);
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_verProfesores});
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.profesoresToolStripMenuItem.Text = "Profesores";
            // 
            // tsmi_verProfesores
            // 
            this.tsmi_verProfesores.Name = "tsmi_verProfesores";
            this.tsmi_verProfesores.Size = new System.Drawing.Size(148, 22);
            this.tsmi_verProfesores.Text = "Ver profesores";
            this.tsmi_verProfesores.Click += new System.EventHandler(this.tsmi_verProfesores_Click);
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_verDepartamentos});
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            // 
            // tsmi_verDepartamentos
            // 
            this.tsmi_verDepartamentos.Name = "tsmi_verDepartamentos";
            this.tsmi_verDepartamentos.Size = new System.Drawing.Size(174, 22);
            this.tsmi_verDepartamentos.Text = "Ver Departamentos";
            this.tsmi_verDepartamentos.Click += new System.EventHandler(this.tsmi_verDepartamentos_Click);
            // 
            // empresasDeTransporteToolStripMenuItem
            // 
            this.empresasDeTransporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_verEmpresas});
            this.empresasDeTransporteToolStripMenuItem.Name = "empresasDeTransporteToolStripMenuItem";
            this.empresasDeTransporteToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.empresasDeTransporteToolStripMenuItem.Text = "Empresas de transporte";
            // 
            // tsmi_verEmpresas
            // 
            this.tsmi_verEmpresas.Name = "tsmi_verEmpresas";
            this.tsmi_verEmpresas.Size = new System.Drawing.Size(143, 22);
            this.tsmi_verEmpresas.Text = "Ver Empresas";
            this.tsmi_verEmpresas.Click += new System.EventHandler(this.tsmi_verEmpresas_Click);
            // 
            // tsmi_perfil
            // 
            this.tsmi_perfil.Name = "tsmi_perfil";
            this.tsmi_perfil.Size = new System.Drawing.Size(46, 20);
            this.tsmi_perfil.Text = "Perfil";
            this.tsmi_perfil.Click += new System.EventHandler(this.tsmi_perfil_Click);
            // 
            // daycontainer
            // 
            this.daycontainer.Location = new System.Drawing.Point(5, 96);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(943, 481);
            this.daycontainer.TabIndex = 1;
            // 
            // btn_mesSiguiente
            // 
            this.btn_mesSiguiente.Location = new System.Drawing.Point(777, 595);
            this.btn_mesSiguiente.Name = "btn_mesSiguiente";
            this.btn_mesSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btn_mesSiguiente.TabIndex = 2;
            this.btn_mesSiguiente.Text = "Siguiente";
            this.btn_mesSiguiente.UseVisualStyleBackColor = true;
            this.btn_mesSiguiente.Click += new System.EventHandler(this.btn_mesSiguiente_Click);
            // 
            // btn_mesAnterior
            // 
            this.btn_mesAnterior.Location = new System.Drawing.Point(614, 595);
            this.btn_mesAnterior.Name = "btn_mesAnterior";
            this.btn_mesAnterior.Size = new System.Drawing.Size(75, 23);
            this.btn_mesAnterior.TabIndex = 3;
            this.btn_mesAnterior.Text = "Anterior";
            this.btn_mesAnterior.UseVisualStyleBackColor = true;
            this.btn_mesAnterior.Click += new System.EventHandler(this.btn_mesAnterior_Click);
            // 
            // lbl_lunes
            // 
            this.lbl_lunes.AutoSize = true;
            this.lbl_lunes.Location = new System.Drawing.Point(5, 77);
            this.lbl_lunes.Name = "lbl_lunes";
            this.lbl_lunes.Size = new System.Drawing.Size(36, 13);
            this.lbl_lunes.TabIndex = 4;
            this.lbl_lunes.Text = "Lunes";
            // 
            // lbl_martes
            // 
            this.lbl_martes.AutoSize = true;
            this.lbl_martes.Location = new System.Drawing.Point(138, 77);
            this.lbl_martes.Name = "lbl_martes";
            this.lbl_martes.Size = new System.Drawing.Size(39, 13);
            this.lbl_martes.TabIndex = 5;
            this.lbl_martes.Text = "Martes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Miercoles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Jueves";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Viernes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(670, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sabado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(803, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Domingo";
            // 
            // lbl_mes
            // 
            this.lbl_mes.AutoSize = true;
            this.lbl_mes.Location = new System.Drawing.Point(420, 38);
            this.lbl_mes.Name = "lbl_mes";
            this.lbl_mes.Size = new System.Drawing.Size(59, 13);
            this.lbl_mes.TabIndex = 11;
            this.lbl_mes.Text = "Mes actual";
            this.lbl_mes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "label7";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 627);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_mes);
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
            this.Name = "Inicio";
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
        private System.Windows.Forms.Label lbl_mes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}