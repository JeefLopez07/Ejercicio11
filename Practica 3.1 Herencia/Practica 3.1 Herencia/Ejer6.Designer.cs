namespace Practica_3._1_Herencia
{
    partial class Ejer6
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
            this.gbPosicionJugador = new System.Windows.Forms.GroupBox();
            this.gbDatosJugador = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.rdbPortero = new System.Windows.Forms.RadioButton();
            this.rdbDelantero = new System.Windows.Forms.RadioButton();
            this.rdbMedio = new System.Windows.Forms.RadioButton();
            this.rdbDefensa = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNumJugador = new System.Windows.Forms.TextBox();
            this.txtMinJugados = new System.Windows.Forms.TextBox();
            this.txtGolesAnotados = new System.Windows.Forms.TextBox();
            this.gbPosicionJugador.SuspendLayout();
            this.gbDatosJugador.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPosicionJugador
            // 
            this.gbPosicionJugador.Controls.Add(this.rdbDefensa);
            this.gbPosicionJugador.Controls.Add(this.rdbMedio);
            this.gbPosicionJugador.Controls.Add(this.rdbDelantero);
            this.gbPosicionJugador.Controls.Add(this.rdbPortero);
            this.gbPosicionJugador.Location = new System.Drawing.Point(21, 33);
            this.gbPosicionJugador.Name = "gbPosicionJugador";
            this.gbPosicionJugador.Size = new System.Drawing.Size(138, 143);
            this.gbPosicionJugador.TabIndex = 0;
            this.gbPosicionJugador.TabStop = false;
            this.gbPosicionJugador.Text = "Posicion del jugador";
            // 
            // gbDatosJugador
            // 
            this.gbDatosJugador.Controls.Add(this.txtGolesAnotados);
            this.gbDatosJugador.Controls.Add(this.txtMinJugados);
            this.gbDatosJugador.Controls.Add(this.txtNumJugador);
            this.gbDatosJugador.Controls.Add(this.txtNombre);
            this.gbDatosJugador.Controls.Add(this.label4);
            this.gbDatosJugador.Controls.Add(this.label3);
            this.gbDatosJugador.Controls.Add(this.label2);
            this.gbDatosJugador.Controls.Add(this.label1);
            this.gbDatosJugador.Location = new System.Drawing.Point(21, 182);
            this.gbDatosJugador.Name = "gbDatosJugador";
            this.gbDatosJugador.Size = new System.Drawing.Size(251, 190);
            this.gbDatosJugador.TabIndex = 1;
            this.gbDatosJugador.TabStop = false;
            this.gbDatosJugador.Text = "Datos del Jugador";
            this.gbDatosJugador.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Capturar Datos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Mostrar Datos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(171, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 36);
            this.button3.TabIndex = 4;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // rdbPortero
            // 
            this.rdbPortero.AutoSize = true;
            this.rdbPortero.Location = new System.Drawing.Point(22, 20);
            this.rdbPortero.Name = "rdbPortero";
            this.rdbPortero.Size = new System.Drawing.Size(59, 17);
            this.rdbPortero.TabIndex = 0;
            this.rdbPortero.TabStop = true;
            this.rdbPortero.Text = "Portero";
            this.rdbPortero.UseVisualStyleBackColor = true;
            // 
            // rdbDelantero
            // 
            this.rdbDelantero.AutoSize = true;
            this.rdbDelantero.Location = new System.Drawing.Point(22, 52);
            this.rdbDelantero.Name = "rdbDelantero";
            this.rdbDelantero.Size = new System.Drawing.Size(71, 17);
            this.rdbDelantero.TabIndex = 1;
            this.rdbDelantero.TabStop = true;
            this.rdbDelantero.Text = "Delantero";
            this.rdbDelantero.UseVisualStyleBackColor = true;
            // 
            // rdbMedio
            // 
            this.rdbMedio.AutoSize = true;
            this.rdbMedio.Location = new System.Drawing.Point(22, 84);
            this.rdbMedio.Name = "rdbMedio";
            this.rdbMedio.Size = new System.Drawing.Size(54, 17);
            this.rdbMedio.TabIndex = 2;
            this.rdbMedio.TabStop = true;
            this.rdbMedio.Text = "Medio";
            this.rdbMedio.UseVisualStyleBackColor = true;
            // 
            // rdbDefensa
            // 
            this.rdbDefensa.AutoSize = true;
            this.rdbDefensa.Location = new System.Drawing.Point(22, 116);
            this.rdbDefensa.Name = "rdbDefensa";
            this.rdbDefensa.Size = new System.Drawing.Size(65, 17);
            this.rdbDefensa.TabIndex = 3;
            this.rdbDefensa.TabStop = true;
            this.rdbDefensa.Text = "Defensa";
            this.rdbDefensa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Jugador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Minutos Jugados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Goles Anotados";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(82, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(156, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtNumJugador
            // 
            this.txtNumJugador.Location = new System.Drawing.Point(141, 81);
            this.txtNumJugador.Name = "txtNumJugador";
            this.txtNumJugador.Size = new System.Drawing.Size(97, 20);
            this.txtNumJugador.TabIndex = 5;
            // 
            // txtMinJugados
            // 
            this.txtMinJugados.Location = new System.Drawing.Point(141, 118);
            this.txtMinJugados.Name = "txtMinJugados";
            this.txtMinJugados.Size = new System.Drawing.Size(97, 20);
            this.txtMinJugados.TabIndex = 6;
            // 
            // txtGolesAnotados
            // 
            this.txtGolesAnotados.Location = new System.Drawing.Point(141, 152);
            this.txtGolesAnotados.Name = "txtGolesAnotados";
            this.txtGolesAnotados.Size = new System.Drawing.Size(97, 20);
            this.txtGolesAnotados.TabIndex = 7;
            // 
            // Ejer6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 382);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbDatosJugador);
            this.Controls.Add(this.gbPosicionJugador);
            this.Name = "Ejer6";
            this.Text = "Equipo de Futbol";
            this.Load += new System.EventHandler(this.Ejer6_Load);
            this.gbPosicionJugador.ResumeLayout(false);
            this.gbPosicionJugador.PerformLayout();
            this.gbDatosJugador.ResumeLayout(false);
            this.gbDatosJugador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPosicionJugador;
        private System.Windows.Forms.RadioButton rdbPortero;
        private System.Windows.Forms.GroupBox gbDatosJugador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton rdbDefensa;
        private System.Windows.Forms.RadioButton rdbMedio;
        private System.Windows.Forms.RadioButton rdbDelantero;
        private System.Windows.Forms.TextBox txtGolesAnotados;
        private System.Windows.Forms.TextBox txtMinJugados;
        private System.Windows.Forms.TextBox txtNumJugador;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}