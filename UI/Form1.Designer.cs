namespace UI
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNuevoNombre = new System.Windows.Forms.TextBox();
            this.tbNuevoPrecio = new System.Windows.Forms.NumericUpDown();
            this.tbNuevoCantidad = new System.Windows.Forms.NumericUpDown();
            this.tbNuevoDescripcion = new System.Windows.Forms.TextBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbEditarNombre = new System.Windows.Forms.TextBox();
            this.tbEditarDescripcion = new System.Windows.Forms.TextBox();
            this.tbEditarPrecio = new System.Windows.Forms.NumericUpDown();
            this.tbEditarCantidad = new System.Windows.Forms.NumericUpDown();
            this.btEditar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btEliminar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNuevoPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNuevoCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEditarPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEditarCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btAgregar);
            this.groupBox1.Controls.Add(this.tbNuevoDescripcion);
            this.groupBox1.Controls.Add(this.tbNuevoCantidad);
            this.groupBox1.Controls.Add(this.tbNuevoPrecio);
            this.groupBox1.Controls.Add(this.tbNuevoNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Producto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btEliminar);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 320);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista Productos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btEditar);
            this.groupBox3.Controls.Add(this.tbEditarCantidad);
            this.groupBox3.Controls.Add(this.tbEditarPrecio);
            this.groupBox3.Controls.Add(this.tbEditarDescripcion);
            this.groupBox3.Controls.Add(this.tbEditarNombre);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 461);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(558, 124);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripción";
            // 
            // tbNuevoNombre
            // 
            this.tbNuevoNombre.Location = new System.Drawing.Point(68, 16);
            this.tbNuevoNombre.Name = "tbNuevoNombre";
            this.tbNuevoNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNuevoNombre.TabIndex = 4;
            // 
            // tbNuevoPrecio
            // 
            this.tbNuevoPrecio.Location = new System.Drawing.Point(228, 16);
            this.tbNuevoPrecio.Name = "tbNuevoPrecio";
            this.tbNuevoPrecio.Size = new System.Drawing.Size(120, 20);
            this.tbNuevoPrecio.TabIndex = 5;
            // 
            // tbNuevoCantidad
            // 
            this.tbNuevoCantidad.Location = new System.Drawing.Point(428, 16);
            this.tbNuevoCantidad.Name = "tbNuevoCantidad";
            this.tbNuevoCantidad.Size = new System.Drawing.Size(120, 20);
            this.tbNuevoCantidad.TabIndex = 6;
            // 
            // tbNuevoDescripcion
            // 
            this.tbNuevoDescripcion.Location = new System.Drawing.Point(68, 56);
            this.tbNuevoDescripcion.Multiline = true;
            this.tbNuevoDescripcion.Name = "tbNuevoDescripcion";
            this.tbNuevoDescripcion.Size = new System.Drawing.Size(280, 40);
            this.tbNuevoDescripcion.TabIndex = 7;
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(472, 72);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 8;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cantidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Descripcion";
            // 
            // tbEditarNombre
            // 
            this.tbEditarNombre.Location = new System.Drawing.Point(68, 20);
            this.tbEditarNombre.Name = "tbEditarNombre";
            this.tbEditarNombre.Size = new System.Drawing.Size(100, 20);
            this.tbEditarNombre.TabIndex = 4;
            // 
            // tbEditarDescripcion
            // 
            this.tbEditarDescripcion.Location = new System.Drawing.Point(68, 64);
            this.tbEditarDescripcion.Multiline = true;
            this.tbEditarDescripcion.Name = "tbEditarDescripcion";
            this.tbEditarDescripcion.Size = new System.Drawing.Size(280, 53);
            this.tbEditarDescripcion.TabIndex = 5;
            // 
            // tbEditarPrecio
            // 
            this.tbEditarPrecio.Location = new System.Drawing.Point(226, 20);
            this.tbEditarPrecio.Name = "tbEditarPrecio";
            this.tbEditarPrecio.Size = new System.Drawing.Size(120, 20);
            this.tbEditarPrecio.TabIndex = 6;
            // 
            // tbEditarCantidad
            // 
            this.tbEditarCantidad.Location = new System.Drawing.Point(429, 20);
            this.tbEditarCantidad.Name = "tbEditarCantidad";
            this.tbEditarCantidad.Size = new System.Drawing.Size(120, 20);
            this.tbEditarCantidad.TabIndex = 7;
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(471, 93);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 8;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(477, 285);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 23);
            this.btEliminar.TabIndex = 1;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 607);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNuevoPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNuevoCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEditarPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEditarCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.TextBox tbNuevoDescripcion;
        private System.Windows.Forms.NumericUpDown tbNuevoCantidad;
        private System.Windows.Forms.NumericUpDown tbNuevoPrecio;
        private System.Windows.Forms.TextBox tbNuevoNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.NumericUpDown tbEditarCantidad;
        private System.Windows.Forms.NumericUpDown tbEditarPrecio;
        private System.Windows.Forms.TextBox tbEditarDescripcion;
        private System.Windows.Forms.TextBox tbEditarNombre;
    }
}

