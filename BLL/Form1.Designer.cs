namespace BLL
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNuevoNombre = new System.Windows.Forms.TextBox();
            this.tbNuevaCantidad = new System.Windows.Forms.NumericUpDown();
            this.tbNuevoPrecio = new System.Windows.Forms.NumericUpDown();
            this.tbNuevaDescripcion = new System.Windows.Forms.TextBox();
            this.btNuevoProducto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btEliminar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbEdicionNombre = new System.Windows.Forms.TextBox();
            this.tbEdicionPrecio = new System.Windows.Forms.NumericUpDown();
            this.tbEdicionCantidad = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btEditarProducto = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNuevaCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNuevoPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbEdicionPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEdicionCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btNuevoProducto);
            this.groupBox1.Controls.Add(this.tbNuevaDescripcion);
            this.groupBox1.Controls.Add(this.tbNuevoPrecio);
            this.groupBox1.Controls.Add(this.tbNuevaCantidad);
            this.groupBox1.Controls.Add(this.tbNuevoNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripción";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbNuevoNombre
            // 
            this.tbNuevoNombre.Location = new System.Drawing.Point(10, 36);
            this.tbNuevoNombre.Name = "tbNuevoNombre";
            this.tbNuevoNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNuevoNombre.TabIndex = 4;
            // 
            // tbNuevaCantidad
            // 
            this.tbNuevaCantidad.Location = new System.Drawing.Point(275, 37);
            this.tbNuevaCantidad.Name = "tbNuevaCantidad";
            this.tbNuevaCantidad.Size = new System.Drawing.Size(120, 20);
            this.tbNuevaCantidad.TabIndex = 5;
            // 
            // tbNuevoPrecio
            // 
            this.tbNuevoPrecio.Location = new System.Drawing.Point(128, 37);
            this.tbNuevoPrecio.Name = "tbNuevoPrecio";
            this.tbNuevoPrecio.Size = new System.Drawing.Size(120, 20);
            this.tbNuevoPrecio.TabIndex = 6;
            // 
            // tbNuevaDescripcion
            // 
            this.tbNuevaDescripcion.Location = new System.Drawing.Point(10, 84);
            this.tbNuevaDescripcion.Multiline = true;
            this.tbNuevaDescripcion.Name = "tbNuevaDescripcion";
            this.tbNuevaDescripcion.Size = new System.Drawing.Size(385, 46);
            this.tbNuevaDescripcion.TabIndex = 7;
            this.tbNuevaDescripcion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btNuevoProducto
            // 
            this.btNuevoProducto.Location = new System.Drawing.Point(320, 136);
            this.btNuevoProducto.Name = "btNuevoProducto";
            this.btNuevoProducto.Size = new System.Drawing.Size(75, 23);
            this.btNuevoProducto.TabIndex = 8;
            this.btNuevoProducto.Text = "Agregar";
            this.btNuevoProducto.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(509, 210);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btEliminar);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 267);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado Productos";
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(442, 236);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 23);
            this.btEliminar.TabIndex = 2;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btEditarProducto);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.tbEdicionCantidad);
            this.groupBox3.Controls.Add(this.tbEdicionPrecio);
            this.groupBox3.Controls.Add(this.tbEdicionNombre);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 468);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(403, 173);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edición de Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cantidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Descripción";
            // 
            // tbEdicionNombre
            // 
            this.tbEdicionNombre.Location = new System.Drawing.Point(13, 37);
            this.tbEdicionNombre.Name = "tbEdicionNombre";
            this.tbEdicionNombre.Size = new System.Drawing.Size(100, 20);
            this.tbEdicionNombre.TabIndex = 4;
            // 
            // tbEdicionPrecio
            // 
            this.tbEdicionPrecio.Location = new System.Drawing.Point(131, 37);
            this.tbEdicionPrecio.Name = "tbEdicionPrecio";
            this.tbEdicionPrecio.Size = new System.Drawing.Size(120, 20);
            this.tbEdicionPrecio.TabIndex = 5;
            // 
            // tbEdicionCantidad
            // 
            this.tbEdicionCantidad.Location = new System.Drawing.Point(275, 38);
            this.tbEdicionCantidad.Name = "tbEdicionCantidad";
            this.tbEdicionCantidad.Size = new System.Drawing.Size(120, 20);
            this.tbEdicionCantidad.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 86);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 46);
            this.textBox1.TabIndex = 7;
            // 
            // btEditarProducto
            // 
            this.btEditarProducto.Location = new System.Drawing.Point(319, 144);
            this.btEditarProducto.Name = "btEditarProducto";
            this.btEditarProducto.Size = new System.Drawing.Size(75, 23);
            this.btEditarProducto.TabIndex = 8;
            this.btEditarProducto.Text = "Editar";
            this.btEditarProducto.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 653);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Inventario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNuevaCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNuevoPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbEdicionPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEdicionCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNuevaDescripcion;
        private System.Windows.Forms.NumericUpDown tbNuevoPrecio;
        private System.Windows.Forms.NumericUpDown tbNuevaCantidad;
        private System.Windows.Forms.TextBox tbNuevoNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btNuevoProducto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btEditarProducto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown tbEdicionCantidad;
        private System.Windows.Forms.NumericUpDown tbEdicionPrecio;
        private System.Windows.Forms.TextBox tbEdicionNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

