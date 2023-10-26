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
            this.btAgregar = new System.Windows.Forms.Button();
            this.tbNuevoDescripcion = new System.Windows.Forms.TextBox();
            this.tbNuevoCantidad = new System.Windows.Forms.NumericUpDown();
            this.tbNuevoPrecio = new System.Windows.Forms.NumericUpDown();
            this.tbNuevoNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btEliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btEditar = new System.Windows.Forms.Button();
            this.tbEditarCantidad = new System.Windows.Forms.NumericUpDown();
            this.tbEditarPrecio = new System.Windows.Forms.NumericUpDown();
            this.tbEditarDescripcion = new System.Windows.Forms.TextBox();
            this.tbEditarNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNuevoCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNuevoPrecio)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbEditarCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEditarPrecio)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(744, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Producto";
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(629, 89);
            this.btAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(100, 28);
            this.btAgregar.TabIndex = 8;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // tbNuevoDescripcion
            // 
            this.tbNuevoDescripcion.Location = new System.Drawing.Point(91, 69);
            this.tbNuevoDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNuevoDescripcion.Multiline = true;
            this.tbNuevoDescripcion.Name = "tbNuevoDescripcion";
            this.tbNuevoDescripcion.Size = new System.Drawing.Size(372, 48);
            this.tbNuevoDescripcion.TabIndex = 7;
            // 
            // tbNuevoCantidad
            // 
            this.tbNuevoCantidad.Location = new System.Drawing.Point(571, 20);
            this.tbNuevoCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNuevoCantidad.Name = "tbNuevoCantidad";
            this.tbNuevoCantidad.Size = new System.Drawing.Size(160, 22);
            this.tbNuevoCantidad.TabIndex = 6;
            // 
            // tbNuevoPrecio
            // 
            this.tbNuevoPrecio.Location = new System.Drawing.Point(304, 20);
            this.tbNuevoPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNuevoPrecio.Name = "tbNuevoPrecio";
            this.tbNuevoPrecio.Size = new System.Drawing.Size(160, 22);
            this.tbNuevoPrecio.TabIndex = 5;
            // 
            // tbNuevoNombre
            // 
            this.tbNuevoNombre.Location = new System.Drawing.Point(91, 20);
            this.tbNuevoNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNuevoNombre.Name = "tbNuevoNombre";
            this.tbNuevoNombre.Size = new System.Drawing.Size(132, 22);
            this.tbNuevoNombre.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btEliminar);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(16, 166);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(744, 394);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista Productos";
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(636, 351);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(100, 28);
            this.btEliminar.TabIndex = 1;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(720, 319);
            this.dataGridView1.TabIndex = 0;
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
            this.groupBox3.Location = new System.Drawing.Point(16, 567);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(744, 153);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(628, 114);
            this.btEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(100, 28);
            this.btEditar.TabIndex = 8;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            // 
            // tbEditarCantidad
            // 
            this.tbEditarCantidad.Location = new System.Drawing.Point(572, 25);
            this.tbEditarCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEditarCantidad.Name = "tbEditarCantidad";
            this.tbEditarCantidad.Size = new System.Drawing.Size(160, 22);
            this.tbEditarCantidad.TabIndex = 7;
            // 
            // tbEditarPrecio
            // 
            this.tbEditarPrecio.Location = new System.Drawing.Point(301, 25);
            this.tbEditarPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEditarPrecio.Name = "tbEditarPrecio";
            this.tbEditarPrecio.Size = new System.Drawing.Size(160, 22);
            this.tbEditarPrecio.TabIndex = 6;
            // 
            // tbEditarDescripcion
            // 
            this.tbEditarDescripcion.Location = new System.Drawing.Point(91, 79);
            this.tbEditarDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEditarDescripcion.Multiline = true;
            this.tbEditarDescripcion.Name = "tbEditarDescripcion";
            this.tbEditarDescripcion.Size = new System.Drawing.Size(372, 64);
            this.tbEditarDescripcion.TabIndex = 5;
            // 
            // tbEditarNombre
            // 
            this.tbEditarNombre.Location = new System.Drawing.Point(91, 25);
            this.tbEditarNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEditarNombre.Name = "tbEditarNombre";
            this.tbEditarNombre.Size = new System.Drawing.Size(132, 22);
            this.tbEditarNombre.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 79);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Descripcion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(497, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 747);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNuevoCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNuevoPrecio)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbEditarCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEditarPrecio)).EndInit();
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

