namespace ProyectoFinalLab2.Capa_presentacion
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.BtnCRUD = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.BtnAltaUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCRUD
            // 
            this.BtnCRUD.FlatAppearance.BorderSize = 0;
            this.BtnCRUD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCRUD.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCRUD.ForeColor = System.Drawing.Color.White;
            this.BtnCRUD.Location = new System.Drawing.Point(267, 81);
            this.BtnCRUD.Name = "BtnCRUD";
            this.BtnCRUD.Size = new System.Drawing.Size(210, 32);
            this.BtnCRUD.TabIndex = 0;
            this.BtnCRUD.Text = ">Registro de productos";
            this.BtnCRUD.UseVisualStyleBackColor = true;
            this.BtnCRUD.Click += new System.EventHandler(this.BtnCRUD_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Location = new System.Drawing.Point(243, 185);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(156, 28);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.Text = ">Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // BtnAltaUsuario
            // 
            this.BtnAltaUsuario.FlatAppearance.BorderSize = 0;
            this.BtnAltaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAltaUsuario.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAltaUsuario.ForeColor = System.Drawing.Color.White;
            this.BtnAltaUsuario.Location = new System.Drawing.Point(224, 136);
            this.BtnAltaUsuario.Name = "BtnAltaUsuario";
            this.BtnAltaUsuario.Size = new System.Drawing.Size(277, 27);
            this.BtnAltaUsuario.TabIndex = 2;
            this.BtnAltaUsuario.Text = ">Lista de Empleados";
            this.BtnAltaUsuario.UseVisualStyleBackColor = true;
            this.BtnAltaUsuario.Click += new System.EventHandler(this.BtnAltaUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(293, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu Principal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(400, 235);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(118, 29);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir del sistema";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(529, 275);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAltaUsuario);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.BtnCRUD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipal_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCRUD;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button BtnAltaUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnSalir;
    }
}