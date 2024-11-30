namespace piedraPapelTijera
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPuntosJugador = new System.Windows.Forms.Label();
            this.lblPuntosComputadora = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnPiedra = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnTijera = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.pbxComputadora = new System.Windows.Forms.PictureBox();
            this.pbxJugador = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxComputadora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJugador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jugador:";
            // 
            // lblPuntosJugador
            // 
            this.lblPuntosJugador.AutoSize = true;
            this.lblPuntosJugador.Location = new System.Drawing.Point(53, 132);
            this.lblPuntosJugador.Name = "lblPuntosJugador";
            this.lblPuntosJugador.Size = new System.Drawing.Size(0, 13);
            this.lblPuntosJugador.TabIndex = 2;
            // 
            // lblPuntosComputadora
            // 
            this.lblPuntosComputadora.AutoSize = true;
            this.lblPuntosComputadora.Location = new System.Drawing.Point(302, 132);
            this.lblPuntosComputadora.Name = "lblPuntosComputadora";
            this.lblPuntosComputadora.Size = new System.Drawing.Size(0, 13);
            this.lblPuntosComputadora.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Computadora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(93, 417);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(0, 13);
            this.lblCantidad.TabIndex = 8;
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(44, 367);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(288, 47);
            this.btnJugar.TabIndex = 9;
            this.btnJugar.Text = "Siguiente ronda";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Visible = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnPiedra
            // 
            this.btnPiedra.Location = new System.Drawing.Point(12, 282);
            this.btnPiedra.Name = "btnPiedra";
            this.btnPiedra.Size = new System.Drawing.Size(45, 23);
            this.btnPiedra.TabIndex = 10;
            this.btnPiedra.Text = "🗻";
            this.btnPiedra.UseVisualStyleBackColor = true;
            this.btnPiedra.Click += new System.EventHandler(this.btnPiedra_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.Location = new System.Drawing.Point(63, 282);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(45, 23);
            this.btnPapel.TabIndex = 11;
            this.btnPapel.Text = "📄";
            this.btnPapel.UseVisualStyleBackColor = true;
            this.btnPapel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTijera
            // 
            this.btnTijera.Location = new System.Drawing.Point(114, 282);
            this.btnTijera.Name = "btnTijera";
            this.btnTijera.Size = new System.Drawing.Size(45, 23);
            this.btnTijera.TabIndex = 12;
            this.btnTijera.Text = "✂";
            this.btnTijera.UseVisualStyleBackColor = true;
            this.btnTijera.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(93, 325);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 39);
            this.lblResultado.TabIndex = 13;
            // 
            // pbxComputadora
            // 
            this.pbxComputadora.Image = global::piedraPapelTijera.Properties.Resources.pc;
            this.pbxComputadora.Location = new System.Drawing.Point(226, 159);
            this.pbxComputadora.Name = "pbxComputadora";
            this.pbxComputadora.Size = new System.Drawing.Size(122, 117);
            this.pbxComputadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxComputadora.TabIndex = 6;
            this.pbxComputadora.TabStop = false;
            this.pbxComputadora.Click += new System.EventHandler(this.pbxComputadora_Click);
            // 
            // pbxJugador
            // 
            this.pbxJugador.Image = global::piedraPapelTijera.Properties.Resources.profile;
            this.pbxJugador.Location = new System.Drawing.Point(12, 159);
            this.pbxJugador.Name = "pbxJugador";
            this.pbxJugador.Size = new System.Drawing.Size(115, 117);
            this.pbxJugador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxJugador.TabIndex = 5;
            this.pbxJugador.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Image = global::piedraPapelTijera.Properties.Resources.Titulo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnTijera);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnPiedra);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbxComputadora);
            this.Controls.Add(this.pbxJugador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPuntosComputadora);
            this.Controls.Add(this.lblPuntosJugador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxComputadora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJugador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPuntosJugador;
        private System.Windows.Forms.Label lblPuntosComputadora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbxJugador;
        private System.Windows.Forms.PictureBox pbxComputadora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnPiedra;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnTijera;
        private System.Windows.Forms.Label lblResultado;
    }
}

