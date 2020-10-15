namespace Practica_3._1_Herencia
{
    partial class Ejer7
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
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbPosición = new System.Windows.Forms.GroupBox();
            this.rdbBateador = new System.Windows.Forms.RadioButton();
            this.rdbJugador = new System.Windows.Forms.RadioButton();
            this.rdbPitcher = new System.Windows.Forms.RadioButton();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.txtErrores = new System.Windows.Forms.TextBox();
            this.txtHits = new System.Windows.Forms.TextBox();
            this.txtPonches = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNumeroUniforme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPosición.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(11, 189);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(105, 31);
            this.btnCapturar.TabIndex = 0;
            this.btnCapturar.Text = "Capturar Datos";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(122, 189);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(102, 31);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar Datos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(11, 226);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(213, 31);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbPosición
            // 
            this.gbPosición.Controls.Add(this.rdbBateador);
            this.gbPosición.Controls.Add(this.rdbJugador);
            this.gbPosición.Controls.Add(this.rdbPitcher);
            this.gbPosición.Location = new System.Drawing.Point(12, 23);
            this.gbPosición.Name = "gbPosición";
            this.gbPosición.Size = new System.Drawing.Size(200, 157);
            this.gbPosición.TabIndex = 3;
            this.gbPosición.TabStop = false;
            this.gbPosición.Text = "Posicion del jugador";
            // 
            // rdbBateador
            // 
            this.rdbBateador.AutoSize = true;
            this.rdbBateador.Location = new System.Drawing.Point(24, 119);
            this.rdbBateador.Name = "rdbBateador";
            this.rdbBateador.Size = new System.Drawing.Size(122, 17);
            this.rdbBateador.TabIndex = 2;
            this.rdbBateador.TabStop = true;
            this.rdbBateador.Text = "Bateador Designado";
            this.rdbBateador.UseVisualStyleBackColor = true;
            this.rdbBateador.CheckedChanged += new System.EventHandler(this.rdbBateador_CheckedChanged);
            // 
            // rdbJugador
            // 
            this.rdbJugador.AutoSize = true;
            this.rdbJugador.Location = new System.Drawing.Point(24, 85);
            this.rdbJugador.Name = "rdbJugador";
            this.rdbJugador.Size = new System.Drawing.Size(121, 17);
            this.rdbJugador.TabIndex = 1;
            this.rdbJugador.TabStop = true;
            this.rdbJugador.Text = "Jugador de Posición";
            this.rdbJugador.UseVisualStyleBackColor = true;
            this.rdbJugador.CheckedChanged += new System.EventHandler(this.rdbJugador_CheckedChanged);
            // 
            // rdbPitcher
            // 
            this.rdbPitcher.AutoSize = true;
            this.rdbPitcher.Location = new System.Drawing.Point(24, 46);
            this.rdbPitcher.Name = "rdbPitcher";
            this.rdbPitcher.Size = new System.Drawing.Size(58, 17);
            this.rdbPitcher.TabIndex = 0;
            this.rdbPitcher.TabStop = true;
            this.rdbPitcher.Text = "Pitcher";
            this.rdbPitcher.UseVisualStyleBackColor = true;
            this.rdbPitcher.CheckedChanged += new System.EventHandler(this.rdbPitcher_CheckedChanged);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtErrores);
            this.gbDatos.Controls.Add(this.txtHits);
            this.gbDatos.Controls.Add(this.txtPonches);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.txtNumeroUniforme);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Location = new System.Drawing.Point(242, 26);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(260, 231);
            this.gbDatos.TabIndex = 4;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos del Jugador";
            // 
            // txtErrores
            // 
            this.txtErrores.Location = new System.Drawing.Point(116, 193);
            this.txtErrores.Name = "txtErrores";
            this.txtErrores.Size = new System.Drawing.Size(132, 20);
            this.txtErrores.TabIndex = 9;
            this.txtErrores.Text = "0";
            // 
            // txtHits
            // 
            this.txtHits.Location = new System.Drawing.Point(116, 160);
            this.txtHits.Name = "txtHits";
            this.txtHits.Size = new System.Drawing.Size(132, 20);
            this.txtHits.TabIndex = 8;
            this.txtHits.Text = "0";
            // 
            // txtPonches
            // 
            this.txtPonches.Location = new System.Drawing.Point(116, 129);
            this.txtPonches.Name = "txtPonches";
            this.txtPonches.Size = new System.Drawing.Size(132, 20);
            this.txtPonches.TabIndex = 7;
            this.txtPonches.Text = "0";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(116, 81);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtNumeroUniforme
            // 
            this.txtNumeroUniforme.Location = new System.Drawing.Point(116, 38);
            this.txtNumeroUniforme.Name = "txtNumeroUniforme";
            this.txtNumeroUniforme.Size = new System.Drawing.Size(132, 20);
            this.txtNumeroUniforme.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Errores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ponches";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Uniforme";
            // 
            // Ejer7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 269);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.gbPosición);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnCapturar);
            this.Name = "Ejer7";
            this.Text = "Equipo de Beisbol";
            this.Load += new System.EventHandler(this.Ejer7_Load);
            this.gbPosición.ResumeLayout(false);
            this.gbPosición.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbPosición;
        private System.Windows.Forms.RadioButton rdbBateador;
        private System.Windows.Forms.RadioButton rdbJugador;
        private System.Windows.Forms.RadioButton rdbPitcher;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtErrores;
        private System.Windows.Forms.TextBox txtHits;
        private System.Windows.Forms.TextBox txtPonches;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNumeroUniforme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}