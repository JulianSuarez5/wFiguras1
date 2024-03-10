namespace wFiguras1
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
            this.gbxCirculo = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblAreaCirculo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.gbxTriangulo = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblAreaTriangulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.gbxCuadrado = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAreaCuadrado = new System.Windows.Forms.Label();
            this.lblLadoCuadrado = new System.Windows.Forms.Label();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.btnCalcularCuadrado = new System.Windows.Forms.Button();
            this.btnCalcularTriangulo = new System.Windows.Forms.Button();
            this.btnCalcularCirculo = new System.Windows.Forms.Button();
            this.gbxCirculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.gbxTriangulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbxCuadrado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCirculo
            // 
            this.gbxCirculo.BackColor = System.Drawing.Color.PowderBlue;
            this.gbxCirculo.Controls.Add(this.btnCalcularCirculo);
            this.gbxCirculo.Controls.Add(this.pictureBox3);
            this.gbxCirculo.Controls.Add(this.lblAreaCirculo);
            this.gbxCirculo.Controls.Add(this.label4);
            this.gbxCirculo.Controls.Add(this.txtRadio);
            this.gbxCirculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCirculo.Location = new System.Drawing.Point(864, 179);
            this.gbxCirculo.Name = "gbxCirculo";
            this.gbxCirculo.Size = new System.Drawing.Size(414, 384);
            this.gbxCirculo.TabIndex = 4;
            this.gbxCirculo.TabStop = false;
            this.gbxCirculo.Text = "CALCULA EL ÁREA DE UN CIRCULO";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(168, 47);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(224, 204);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // lblAreaCirculo
            // 
            this.lblAreaCirculo.AutoSize = true;
            this.lblAreaCirculo.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaCirculo.Location = new System.Drawing.Point(21, 252);
            this.lblAreaCirculo.Name = "lblAreaCirculo";
            this.lblAreaCirculo.Size = new System.Drawing.Size(84, 25);
            this.lblAreaCirculo.TabIndex = 12;
            this.lblAreaCirculo.Text = "ÁREA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Radio:";
            // 
            // txtRadio
            // 
            this.txtRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRadio.Location = new System.Drawing.Point(26, 75);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(112, 44);
            this.txtRadio.TabIndex = 3;
            // 
            // gbxTriangulo
            // 
            this.gbxTriangulo.BackColor = System.Drawing.Color.PowderBlue;
            this.gbxTriangulo.Controls.Add(this.btnCalcularTriangulo);
            this.gbxTriangulo.Controls.Add(this.pictureBox2);
            this.gbxTriangulo.Controls.Add(this.lblAreaTriangulo);
            this.gbxTriangulo.Controls.Add(this.label3);
            this.gbxTriangulo.Controls.Add(this.label2);
            this.gbxTriangulo.Controls.Add(this.txtAltura);
            this.gbxTriangulo.Controls.Add(this.txtBase);
            this.gbxTriangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTriangulo.Location = new System.Drawing.Point(442, 179);
            this.gbxTriangulo.Name = "gbxTriangulo";
            this.gbxTriangulo.Size = new System.Drawing.Size(406, 384);
            this.gbxTriangulo.TabIndex = 3;
            this.gbxTriangulo.TabStop = false;
            this.gbxTriangulo.Text = "CALCULA EL ÁREA DE UN TRIANGULO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(186, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(210, 204);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // lblAreaTriangulo
            // 
            this.lblAreaTriangulo.AutoSize = true;
            this.lblAreaTriangulo.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaTriangulo.Location = new System.Drawing.Point(15, 210);
            this.lblAreaTriangulo.Name = "lblAreaTriangulo";
            this.lblAreaTriangulo.Size = new System.Drawing.Size(84, 25);
            this.lblAreaTriangulo.TabIndex = 11;
            this.lblAreaTriangulo.Text = "ÁREA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Base:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Altura:";
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(20, 153);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(136, 44);
            this.txtAltura.TabIndex = 2;
            // 
            // txtBase
            // 
            this.txtBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBase.Location = new System.Drawing.Point(20, 75);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(136, 44);
            this.txtBase.TabIndex = 1;
            // 
            // gbxCuadrado
            // 
            this.gbxCuadrado.BackColor = System.Drawing.Color.PowderBlue;
            this.gbxCuadrado.Controls.Add(this.btnCalcularCuadrado);
            this.gbxCuadrado.Controls.Add(this.pictureBox1);
            this.gbxCuadrado.Controls.Add(this.lblAreaCuadrado);
            this.gbxCuadrado.Controls.Add(this.lblLadoCuadrado);
            this.gbxCuadrado.Controls.Add(this.txtLado1);
            this.gbxCuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCuadrado.Location = new System.Drawing.Point(10, 179);
            this.gbxCuadrado.Name = "gbxCuadrado";
            this.gbxCuadrado.Size = new System.Drawing.Size(417, 384);
            this.gbxCuadrado.TabIndex = 2;
            this.gbxCuadrado.TabStop = false;
            this.gbxCuadrado.Text = "CALCULA EL ÁREA DE UN CUADRADO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(181, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 222);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblAreaCuadrado
            // 
            this.lblAreaCuadrado.AutoSize = true;
            this.lblAreaCuadrado.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaCuadrado.Location = new System.Drawing.Point(17, 150);
            this.lblAreaCuadrado.Name = "lblAreaCuadrado";
            this.lblAreaCuadrado.Size = new System.Drawing.Size(84, 25);
            this.lblAreaCuadrado.TabIndex = 8;
            this.lblAreaCuadrado.Text = "ÁREA:";
            // 
            // lblLadoCuadrado
            // 
            this.lblLadoCuadrado.AutoSize = true;
            this.lblLadoCuadrado.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoCuadrado.Location = new System.Drawing.Point(14, 64);
            this.lblLadoCuadrado.Name = "lblLadoCuadrado";
            this.lblLadoCuadrado.Size = new System.Drawing.Size(69, 25);
            this.lblLadoCuadrado.TabIndex = 7;
            this.lblLadoCuadrado.Text = "Lado:";
            // 
            // txtLado1
            // 
            this.txtLado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLado1.Location = new System.Drawing.Point(19, 92);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(120, 44);
            this.txtLado1.TabIndex = 0;
            // 
            // btnCalcularCuadrado
            // 
            this.btnCalcularCuadrado.Location = new System.Drawing.Point(86, 300);
            this.btnCalcularCuadrado.Name = "btnCalcularCuadrado";
            this.btnCalcularCuadrado.Size = new System.Drawing.Size(207, 66);
            this.btnCalcularCuadrado.TabIndex = 11;
            this.btnCalcularCuadrado.Text = "CALCULAR";
            this.btnCalcularCuadrado.UseVisualStyleBackColor = true;
            this.btnCalcularCuadrado.Click += new System.EventHandler(this.btnCalcularCuadrado_Click);
            // 
            // btnCalcularTriangulo
            // 
            this.btnCalcularTriangulo.Location = new System.Drawing.Point(94, 300);
            this.btnCalcularTriangulo.Name = "btnCalcularTriangulo";
            this.btnCalcularTriangulo.Size = new System.Drawing.Size(207, 66);
            this.btnCalcularTriangulo.TabIndex = 13;
            this.btnCalcularTriangulo.Text = "CALCULAR";
            this.btnCalcularTriangulo.UseVisualStyleBackColor = true;
            this.btnCalcularTriangulo.Click += new System.EventHandler(this.btnCalcularTriangulo_Click);
            // 
            // btnCalcularCirculo
            // 
            this.btnCalcularCirculo.Location = new System.Drawing.Point(86, 300);
            this.btnCalcularCirculo.Name = "btnCalcularCirculo";
            this.btnCalcularCirculo.Size = new System.Drawing.Size(207, 66);
            this.btnCalcularCirculo.TabIndex = 14;
            this.btnCalcularCirculo.Text = "CALCULAR";
            this.btnCalcularCirculo.UseVisualStyleBackColor = true;
            this.btnCalcularCirculo.Click += new System.EventHandler(this.btnCalcularCirculo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1419, 690);
            this.Controls.Add(this.gbxCirculo);
            this.Controls.Add(this.gbxTriangulo);
            this.Controls.Add(this.gbxCuadrado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.gbxCirculo.ResumeLayout(false);
            this.gbxCirculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.gbxTriangulo.ResumeLayout(false);
            this.gbxTriangulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbxCuadrado.ResumeLayout(false);
            this.gbxCuadrado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCirculo;
        private System.Windows.Forms.Button btnCalcularCirculo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblAreaCirculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.GroupBox gbxTriangulo;
        private System.Windows.Forms.Button btnCalcularTriangulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblAreaTriangulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.GroupBox gbxCuadrado;
        private System.Windows.Forms.Button btnCalcularCuadrado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAreaCuadrado;
        private System.Windows.Forms.Label lblLadoCuadrado;
        private System.Windows.Forms.TextBox txtLado1;
    }
}

