namespace forca
{
    partial class Forca
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.palavra_tb = new System.Windows.Forms.TextBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.tentar_btn = new System.Windows.Forms.Button();
            this.letra_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.novo_jogo_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.resultado_label = new System.Windows.Forms.Label();
            this.tentar_palavra_btn = new System.Windows.Forms.Button();
            this.tentar_palavra_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(519, 608);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Forca";
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(604, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(610, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Digite a palavra";
            this.label3.UseMnemonic = false;
            // 
            // palavra_tb
            // 
            this.palavra_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.palavra_tb.Location = new System.Drawing.Point(614, 59);
            this.palavra_tb.Name = "palavra_tb";
            this.palavra_tb.Size = new System.Drawing.Size(323, 38);
            this.palavra_tb.TabIndex = 4;
            this.palavra_tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.palavra_tb_KeyUp);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(614, 103);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(323, 41);
            this.btn_salvar.TabIndex = 5;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // tentar_btn
            // 
            this.tentar_btn.Location = new System.Drawing.Point(614, 280);
            this.tentar_btn.Name = "tentar_btn";
            this.tentar_btn.Size = new System.Drawing.Size(323, 41);
            this.tentar_btn.TabIndex = 8;
            this.tentar_btn.Text = "Tentar";
            this.tentar_btn.UseVisualStyleBackColor = true;
            this.tentar_btn.Click += new System.EventHandler(this.tentar_btn_Click);
            // 
            // letra_tb
            // 
            this.letra_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letra_tb.Location = new System.Drawing.Point(614, 236);
            this.letra_tb.Name = "letra_tb";
            this.letra_tb.Size = new System.Drawing.Size(323, 38);
            this.letra_tb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(610, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Digite a letra";
            this.label4.UseMnemonic = false;
            // 
            // novo_jogo_btn
            // 
            this.novo_jogo_btn.Location = new System.Drawing.Point(614, 669);
            this.novo_jogo_btn.Name = "novo_jogo_btn";
            this.novo_jogo_btn.Size = new System.Drawing.Size(323, 41);
            this.novo_jogo_btn.TabIndex = 10;
            this.novo_jogo_btn.Text = "Novo jogo";
            this.novo_jogo_btn.UseVisualStyleBackColor = true;
            this.novo_jogo_btn.Click += new System.EventHandler(this.novo_jogo_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(610, 598);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Resultado";
            this.label5.UseMnemonic = false;
            // 
            // resultado_label
            // 
            this.resultado_label.AutoSize = true;
            this.resultado_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado_label.Location = new System.Drawing.Point(610, 632);
            this.resultado_label.Name = "resultado_label";
            this.resultado_label.Size = new System.Drawing.Size(0, 33);
            this.resultado_label.TabIndex = 11;
            this.resultado_label.UseMnemonic = false;
            // 
            // tentar_palavra_btn
            // 
            this.tentar_palavra_btn.Location = new System.Drawing.Point(616, 437);
            this.tentar_palavra_btn.Name = "tentar_palavra_btn";
            this.tentar_palavra_btn.Size = new System.Drawing.Size(323, 41);
            this.tentar_palavra_btn.TabIndex = 14;
            this.tentar_palavra_btn.Text = "Tentar";
            this.tentar_palavra_btn.UseVisualStyleBackColor = true;
            this.tentar_palavra_btn.Click += new System.EventHandler(this.tentar_palavra_btn_Click);
            // 
            // tentar_palavra_tb
            // 
            this.tentar_palavra_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tentar_palavra_tb.Location = new System.Drawing.Point(616, 393);
            this.tentar_palavra_tb.Name = "tentar_palavra_tb";
            this.tentar_palavra_tb.Size = new System.Drawing.Size(323, 38);
            this.tentar_palavra_tb.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(612, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tentar palavra";
            this.label6.UseMnemonic = false;
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.ForeColor = System.Drawing.Color.Black;
            this.resultado.Location = new System.Drawing.Point(16, 678);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 29);
            this.resultado.TabIndex = 15;
            // 
            // Forca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.tentar_palavra_btn);
            this.Controls.Add(this.tentar_palavra_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultado_label);
            this.Controls.Add(this.novo_jogo_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tentar_btn);
            this.Controls.Add(this.letra_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.palavra_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Forca";
            this.Text = "Jogo da Forca";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox palavra_tb;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button tentar_btn;
        private System.Windows.Forms.TextBox letra_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button novo_jogo_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label resultado_label;
        private System.Windows.Forms.Button tentar_palavra_btn;
        private System.Windows.Forms.TextBox tentar_palavra_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label resultado;
    }
}

