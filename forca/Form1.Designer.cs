﻿namespace forca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forca));
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
            this.qtdLetras_label = new System.Windows.Forms.Label();
            this.letras_tentadas_tb = new System.Windows.Forms.TextBox();
            this.palavras_tentadas_tb = new System.Windows.Forms.TextBox();
            this.imgFaustao = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOJogoDaForcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirPlacarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFaustao)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
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
            this.label3.BackColor = System.Drawing.Color.Transparent;
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
            this.palavra_tb.TabIndex = 1;
            this.palavra_tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.palavra_tb_KeyUp);
            // 
            // btn_salvar
            // 
            this.btn_salvar.CausesValidation = false;
            this.btn_salvar.Location = new System.Drawing.Point(614, 103);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(323, 41);
            this.btn_salvar.TabIndex = 2;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // tentar_btn
            // 
            this.tentar_btn.Location = new System.Drawing.Point(614, 280);
            this.tentar_btn.Name = "tentar_btn";
            this.tentar_btn.Size = new System.Drawing.Size(323, 41);
            this.tentar_btn.TabIndex = 4;
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
            this.letra_tb.TabIndex = 3;
            this.letra_tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.letra_tb_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
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
            this.novo_jogo_btn.TabIndex = 7;
            this.novo_jogo_btn.Text = "Novo jogo";
            this.novo_jogo_btn.UseVisualStyleBackColor = true;
            this.novo_jogo_btn.Click += new System.EventHandler(this.novo_jogo_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
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
            this.resultado_label.Location = new System.Drawing.Point(620, 632);
            this.resultado_label.Name = "resultado_label";
            this.resultado_label.Size = new System.Drawing.Size(0, 33);
            this.resultado_label.TabIndex = 11;
            this.resultado_label.UseMnemonic = false;
            // 
            // tentar_palavra_btn
            // 
            this.tentar_palavra_btn.Location = new System.Drawing.Point(614, 457);
            this.tentar_palavra_btn.Name = "tentar_palavra_btn";
            this.tentar_palavra_btn.Size = new System.Drawing.Size(323, 41);
            this.tentar_palavra_btn.TabIndex = 6;
            this.tentar_palavra_btn.Text = "Tentar";
            this.tentar_palavra_btn.UseVisualStyleBackColor = true;
            this.tentar_palavra_btn.Click += new System.EventHandler(this.tentar_palavra_btn_Click);
            // 
            // tentar_palavra_tb
            // 
            this.tentar_palavra_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tentar_palavra_tb.Location = new System.Drawing.Point(614, 413);
            this.tentar_palavra_tb.Name = "tentar_palavra_tb";
            this.tentar_palavra_tb.Size = new System.Drawing.Size(323, 38);
            this.tentar_palavra_tb.TabIndex = 5;
            this.tentar_palavra_tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tentar_palavra_tb_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(610, 386);
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
            // qtdLetras_label
            // 
            this.qtdLetras_label.AutoSize = true;
            this.qtdLetras_label.BackColor = System.Drawing.Color.White;
            this.qtdLetras_label.Location = new System.Drawing.Point(819, 604);
            this.qtdLetras_label.Name = "qtdLetras_label";
            this.qtdLetras_label.Size = new System.Drawing.Size(118, 13);
            this.qtdLetras_label.TabIndex = 16;
            this.qtdLetras_label.Text = "A palavra tem 17 letras.";
            this.qtdLetras_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // letras_tentadas_tb
            // 
            this.letras_tentadas_tb.AcceptsReturn = true;
            this.letras_tentadas_tb.Location = new System.Drawing.Point(616, 334);
            this.letras_tentadas_tb.Multiline = true;
            this.letras_tentadas_tb.Name = "letras_tentadas_tb";
            this.letras_tentadas_tb.ReadOnly = true;
            this.letras_tentadas_tb.Size = new System.Drawing.Size(321, 42);
            this.letras_tentadas_tb.TabIndex = 18;
            // 
            // palavras_tentadas_tb
            // 
            this.palavras_tentadas_tb.AcceptsReturn = true;
            this.palavras_tentadas_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.palavras_tentadas_tb.Location = new System.Drawing.Point(614, 512);
            this.palavras_tentadas_tb.Multiline = true;
            this.palavras_tentadas_tb.Name = "palavras_tentadas_tb";
            this.palavras_tentadas_tb.ReadOnly = true;
            this.palavras_tentadas_tb.Size = new System.Drawing.Size(321, 71);
            this.palavras_tentadas_tb.TabIndex = 19;
            // 
            // imgFaustao
            // 
            this.imgFaustao.BackColor = System.Drawing.Color.Transparent;
            this.imgFaustao.Image = ((System.Drawing.Image)(resources.GetObject("imgFaustao.Image")));
            this.imgFaustao.Location = new System.Drawing.Point(0, 341);
            this.imgFaustao.Name = "imgFaustao";
            this.imgFaustao.Size = new System.Drawing.Size(600, 388);
            this.imgFaustao.TabIndex = 20;
            this.imgFaustao.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirPlacarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreOJogoDaForcaToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreOJogoDaForcaToolStripMenuItem
            // 
            this.sobreOJogoDaForcaToolStripMenuItem.Name = "sobreOJogoDaForcaToolStripMenuItem";
            this.sobreOJogoDaForcaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.sobreOJogoDaForcaToolStripMenuItem.Text = "Sobre o Jogo da Forca";
            this.sobreOJogoDaForcaToolStripMenuItem.Click += new System.EventHandler(this.sobreOJogoDaForcaToolStripMenuItem_Click);
            // 
            // abrirPlacarToolStripMenuItem
            // 
            this.abrirPlacarToolStripMenuItem.Name = "abrirPlacarToolStripMenuItem";
            this.abrirPlacarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirPlacarToolStripMenuItem.Text = "Abrir Placar";
            this.abrirPlacarToolStripMenuItem.Click += new System.EventHandler(this.abrirPlacarToolStripMenuItem_Click);
            // 
            // Forca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.imgFaustao);
            this.Controls.Add(this.palavras_tentadas_tb);
            this.Controls.Add(this.letras_tentadas_tb);
            this.Controls.Add(this.qtdLetras_label);
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
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Forca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Forca";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFaustao)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label qtdLetras_label;
        private System.Windows.Forms.TextBox letras_tentadas_tb;
        private System.Windows.Forms.TextBox palavras_tentadas_tb;
        private System.Windows.Forms.PictureBox imgFaustao;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreOJogoDaForcaToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirPlacarToolStripMenuItem;
    }
}

