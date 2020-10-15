namespace Practica_3._1_Herencia
{
    partial class Ejer1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCapturarDatos = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.radLibroImpreso = new System.Windows.Forms.RadioButton();
            this.RadAudioLibro = new System.Windows.Forms.RadioButton();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbVentasLibro = new System.Windows.Forms.ListBox();
            this.txtVenta = new System.Windows.Forms.TextBox();
            this.btnCapturarVenta = new System.Windows.Forms.Button();
            this.lbVentasCD = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.gpbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadAudioLibro);
            this.groupBox1.Controls.Add(this.radLibroImpreso);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Publicacion";
            // 
            // btnCapturarDatos
            // 
            this.btnCapturarDatos.Location = new System.Drawing.Point(278, 147);
            this.btnCapturarDatos.Name = "btnCapturarDatos";
            this.btnCapturarDatos.Size = new System.Drawing.Size(89, 53);
            this.btnCapturarDatos.TabIndex = 0;
            this.btnCapturarDatos.Text = "Capturar Datos";
            this.btnCapturarDatos.UseVisualStyleBackColor = true;
            this.btnCapturarDatos.Click += new System.EventHandler(this.btnCapturarDatos_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(278, 206);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(89, 52);
            this.btnMostrarDatos.TabIndex = 1;
            this.btnMostrarDatos.Text = "Mostrar Datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(278, 264);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 33);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gpbDatos
            // 
            this.gpbDatos.Controls.Add(this.label4);
            this.gpbDatos.Controls.Add(this.label3);
            this.gpbDatos.Controls.Add(this.label2);
            this.gpbDatos.Controls.Add(this.label1);
            this.gpbDatos.Controls.Add(this.txtTiempo);
            this.gpbDatos.Controls.Add(this.txtPaginas);
            this.gpbDatos.Controls.Add(this.txtPrecio);
            this.gpbDatos.Controls.Add(this.txtTitulo);
            this.gpbDatos.Location = new System.Drawing.Point(22, 138);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(250, 159);
            this.gpbDatos.TabIndex = 1;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Datos de Publicacion";
            // 
            // radLibroImpreso
            // 
            this.radLibroImpreso.AutoSize = true;
            this.radLibroImpreso.Location = new System.Drawing.Point(27, 32);
            this.radLibroImpreso.Name = "radLibroImpreso";
            this.radLibroImpreso.Size = new System.Drawing.Size(88, 17);
            this.radLibroImpreso.TabIndex = 0;
            this.radLibroImpreso.TabStop = true;
            this.radLibroImpreso.Text = "Libro Impreso";
            this.radLibroImpreso.UseVisualStyleBackColor = true;
            this.radLibroImpreso.CheckedChanged += new System.EventHandler(this.radLibroImpreso_CheckedChanged);
            // 
            // RadAudioLibro
            // 
            this.RadAudioLibro.AutoSize = true;
            this.RadAudioLibro.Location = new System.Drawing.Point(27, 74);
            this.RadAudioLibro.Name = "RadAudioLibro";
            this.RadAudioLibro.Size = new System.Drawing.Size(78, 17);
            this.RadAudioLibro.TabIndex = 1;
            this.RadAudioLibro.TabStop = true;
            this.RadAudioLibro.Text = "Audio Libro";
            this.RadAudioLibro.UseVisualStyleBackColor = true;
            this.RadAudioLibro.CheckedChanged += new System.EventHandler(this.RadAudioLibro_CheckedChanged);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(63, 27);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(181, 20);
            this.txtTitulo.TabIndex = 0;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(63, 54);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(181, 20);
            this.txtPrecio.TabIndex = 1;
            // 
            // txtPaginas
            // 
            this.txtPaginas.Location = new System.Drawing.Point(86, 90);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(158, 20);
            this.txtPaginas.TabIndex = 2;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(144, 126);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(100, 20);
            this.txtTiempo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Titulo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Num.Paginas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "TIempo de Reproduccion";
            // 
            // lbVentasLibro
            // 
            this.lbVentasLibro.FormattingEnabled = true;
            this.lbVentasLibro.Location = new System.Drawing.Point(172, 50);
            this.lbVentasLibro.Name = "lbVentasLibro";
            this.lbVentasLibro.Size = new System.Drawing.Size(195, 82);
            this.lbVentasLibro.TabIndex = 3;
            // 
            // txtVenta
            // 
            this.txtVenta.Location = new System.Drawing.Point(172, 15);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Size = new System.Drawing.Size(100, 20);
            this.txtVenta.TabIndex = 4;
            // 
            // btnCapturarVenta
            // 
            this.btnCapturarVenta.Location = new System.Drawing.Point(278, 12);
            this.btnCapturarVenta.Name = "btnCapturarVenta";
            this.btnCapturarVenta.Size = new System.Drawing.Size(89, 23);
            this.btnCapturarVenta.TabIndex = 5;
            this.btnCapturarVenta.Text = "Capturar venta";
            this.btnCapturarVenta.UseVisualStyleBackColor = true;
            this.btnCapturarVenta.Click += new System.EventHandler(this.btnCapturarVenta_Click);
            // 
            // lbVentasCD
            // 
            this.lbVentasCD.FormattingEnabled = true;
            this.lbVentasCD.Location = new System.Drawing.Point(172, 50);
            this.lbVentasCD.Name = "lbVentasCD";
            this.lbVentasCD.Size = new System.Drawing.Size(195, 82);
            this.lbVentasCD.TabIndex = 6;
            // 
            // Ejer1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 304);
            this.Controls.Add(this.lbVentasCD);
            this.Controls.Add(this.btnCapturarVenta);
            this.Controls.Add(this.txtVenta);
            this.Controls.Add(this.lbVentasLibro);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.gpbDatos);
            this.Controls.Add(this.btnCapturarDatos);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ejer1";
            this.Text = "Ejercicios 1-4";
            this.Load += new System.EventHandler(this.Ejercicio_1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadAudioLibro;
        private System.Windows.Forms.RadioButton radLibroImpreso;
        private System.Windows.Forms.Button btnCapturarDatos;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.TextBox txtPaginas;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ListBox lbVentasLibro;
        private System.Windows.Forms.TextBox txtVenta;
        private System.Windows.Forms.Button btnCapturarVenta;
        private System.Windows.Forms.ListBox lbVentasCD;
    }
}