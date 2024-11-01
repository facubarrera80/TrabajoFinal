namespace ProyectoFinalLab2.Capa_presentacion
{
    partial class NuevaVenta
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnCompra = new System.Windows.Forms.Button();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.ColProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lbProducto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(264, 36);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.Size = new System.Drawing.Size(382, 187);
            this.dgvProductos.TabIndex = 1;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // btnCompra
            // 
            this.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompra.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompra.ForeColor = System.Drawing.Color.White;
            this.btnCompra.Location = new System.Drawing.Point(140, 343);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(119, 28);
            this.btnCompra.TabIndex = 3;
            this.btnCompra.Text = "Realizar compra";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(119, 150);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(71, 20);
            this.TxtCantidad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad";
            // 
            // dgvCompra
            // 
            this.dgvCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProd,
            this.ColPre,
            this.ColCant});
            this.dgvCompra.Location = new System.Drawing.Point(264, 238);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.RowHeadersWidth = 51;
            this.dgvCompra.Size = new System.Drawing.Size(382, 146);
            this.dgvCompra.TabIndex = 6;
            // 
            // ColProd
            // 
            this.ColProd.HeaderText = "Producto";
            this.ColProd.MinimumWidth = 6;
            this.ColProd.Name = "ColProd";
            // 
            // ColPre
            // 
            this.ColPre.HeaderText = "Precio";
            this.ColPre.MinimumWidth = 6;
            this.ColPre.Name = "ColPre";
            // 
            // ColCant
            // 
            this.ColCant.HeaderText = "Cantidad";
            this.ColCant.MinimumWidth = 6;
            this.ColCant.Name = "ColCant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Producto:";
            // 
            // lbProducto
            // 
            this.lbProducto.AutoSize = true;
            this.lbProducto.Location = new System.Drawing.Point(125, 96);
            this.lbProducto.Name = "lbProducto";
            this.lbProducto.Size = new System.Drawing.Size(0, 13);
            this.lbProducto.TabIndex = 7;
            this.lbProducto.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Precio:";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(125, 124);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(0, 13);
            this.lbPrecio.TabIndex = 7;
            this.lbPrecio.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(64, 215);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(126, 26);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar al carrito";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(23, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total a pagar:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbTotal.Location = new System.Drawing.Point(165, 273);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(38, 18);
            this.lbTotal.TabIndex = 10;
            this.lbTotal.Text = "Total";
            // 
            // BtnMenu
            // 
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.ForeColor = System.Drawing.Color.White;
            this.BtnMenu.Location = new System.Drawing.Point(321, 407);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(133, 35);
            this.BtnMenu.TabIndex = 11;
            this.BtnMenu.Text = "Menu Principal";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 38);
            this.label4.TabIndex = 12;
            this.label4.Text = "MENU DE VENTAS:";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(460, 407);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(133, 35);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "Eliminar producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(678, 454);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.btnCompra);
            this.Controls.Add(this.dgvProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "NuevaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevaVenta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NuevaVenta_FormClosed);
            this.Load += new System.EventHandler(this.NuevaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button button1;
    }
}