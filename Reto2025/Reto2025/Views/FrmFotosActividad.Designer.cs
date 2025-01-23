namespace Reto2025.Views
{
    partial class FrmFotosActividad
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
            this.flpFotosNube = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpFotosNube
            // 
            this.flpFotosNube.AutoScroll = true;
            this.flpFotosNube.Location = new System.Drawing.Point(2, 8);
            this.flpFotosNube.Name = "flpFotosNube";
            this.flpFotosNube.Size = new System.Drawing.Size(805, 157);
            this.flpFotosNube.TabIndex = 0;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAgregarImagen.Location = new System.Drawing.Point(325, 408);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(137, 30);
            this.btnAgregarImagen.TabIndex = 65;
            this.btnAgregarImagen.Text = "Agregar imagenes";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // FrmFotosActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.flpFotosNube);
            this.Name = "FrmFotosActividad";
            this.Text = "FrmFotosActividad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpFotosNube;
        private System.Windows.Forms.Button btnAgregarImagen;
    }
}