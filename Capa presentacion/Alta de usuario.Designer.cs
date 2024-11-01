namespace ProyectoFinalLab2.Capa_presentacion
{
    partial class Alta_de_usuario
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
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgvListaEmpleados = new System.Windows.Forms.DataGridView();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(265, 103);
            this.TxtUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(164, 22);
            this.TxtUser.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de usuario";
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(265, 154);
            this.TxtContraseña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(164, 22);
            this.TxtContraseña.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(228, 212);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 43);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Green;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(127, 212);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(101, 43);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgvListaEmpleados
            // 
            this.dgvListaEmpleados.AllowUserToAddRows = false;
            this.dgvListaEmpleados.AllowUserToDeleteRows = false;
            this.dgvListaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEmpleados.Location = new System.Drawing.Point(513, 50);
            this.dgvListaEmpleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListaEmpleados.Name = "dgvListaEmpleados";
            this.dgvListaEmpleados.RowHeadersWidth = 51;
            this.dgvListaEmpleados.Size = new System.Drawing.Size(413, 219);
            this.dgvListaEmpleados.TabIndex = 4;
            this.dgvListaEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaEmpleados_CellClick);
            this.dgvListaEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaEmpleados_CellContentClick);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(265, 55);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(164, 22);
            this.TxtNombre.TabIndex = 1;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(80, 54);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(160, 22);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre y apellido";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(335, 212);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "ELIMINAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Alta_de_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(983, 324);
            this.Controls.Add(this.dgvListaEmpleados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Alta_de_usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de usuario";
            this.Load += new System.EventHandler(this.Alta_de_usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvListaEmpleados;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Button button1;
    }
}