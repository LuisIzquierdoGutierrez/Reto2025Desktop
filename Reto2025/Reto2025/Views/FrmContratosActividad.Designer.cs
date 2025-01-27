namespace Reto2025.Views
{
    partial class FrmContratosActividad
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
            this.lvwContratos = new System.Windows.Forms.ListView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvwContratos
            // 
            this.lvwContratos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lvwContratos.HideSelection = false;
            this.lvwContratos.Location = new System.Drawing.Point(12, 12);
            this.lvwContratos.Name = "lvwContratos";
            this.lvwContratos.Size = new System.Drawing.Size(317, 315);
            this.lvwContratos.TabIndex = 0;
            this.lvwContratos.UseCompatibleStateImageBehavior = false;
            this.lvwContratos.View = System.Windows.Forms.View.Details;
            this.lvwContratos.DoubleClick += new System.EventHandler(this.lvwContratos_DoubleClickAsync);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAgregar.Location = new System.Drawing.Point(105, 333);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(131, 30);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Añadir Contrato";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Empresa";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Importe";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Contratada";
            // 
            // FrmContratosActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 375);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lvwContratos);
            this.Name = "FrmContratosActividad";
            this.Text = "FrmContratosActividad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwContratos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}