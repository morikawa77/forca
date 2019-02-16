using System;
using System.Drawing;
using System.Windows.Forms;

namespace forca
{
    public partial class Forca : Form
    {
        public Graphics g;
        Pen caneta = new Pen(Color.Black);
        Pen caneta2 = new Pen(Color.Red);
        public string palavra;
        public char[] charPalavra;
        public char letra;
        public int tentativas = 6;
        public int qtdLetras = 0;
        public char[] resultadoLetras;

        
        public Forca()
        {
            InitializeComponent();

            btn_salvar.Enabled = false;
            letra_tb.Enabled = false;
            letra_tb.MaxLength = 1;
            tentar_btn.Enabled = false;
            tentar_palavra_tb.Enabled = false;
            tentar_palavra_btn.Enabled = false;
            palavra_tb.PasswordChar = '*';

        }
        public void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            caneta.Width = 10;
            g.DrawLine(caneta, 30, 30, 30, 600);
            g.DrawLine(caneta, 30, 30, 300, 30);
            g.DrawLine(caneta, 300, 30, 300, 100);

            caneta2.Width = 10;

            switch (tentativas)
            {
                case 5: 
                    // cabeca
                    g.DrawEllipse(caneta2, 260, 100, 80, 80);
                    break;
                case 4:
                    // cabeca
                    g.DrawEllipse(caneta2, 260, 100, 80, 80);
                    //corpo
                    g.DrawLine(caneta2, 300, 180, 300, 450);
                    break;
                case 3:
                    // cabeca
                    g.DrawEllipse(caneta2, 260, 100, 80, 80);
                    //corpo
                    g.DrawLine(caneta2, 300, 180, 300, 450);
                    // perna esquerda
                    g.DrawLine(caneta2, 300, 450, 240, 550);
                    break;
                case 2:
                    // cabeca
                    g.DrawEllipse(caneta2, 260, 100, 80, 80);
                    //corpo
                    g.DrawLine(caneta2, 300, 180, 300, 450);
                    // perna esquerda
                    g.DrawLine(caneta2, 300, 450, 240, 550);
                    // perna direita
                    g.DrawLine(caneta2, 300, 450, 360, 550);
                    break;
                case 1:
                    // cabeca
                    g.DrawEllipse(caneta2, 260, 100, 80, 80);
                    //corpo
                    g.DrawLine(caneta2, 300, 180, 300, 450);
                    // perna esquerda
                    g.DrawLine(caneta2, 300, 450, 240, 550);
                    // perna direita
                    g.DrawLine(caneta2, 300, 450, 360, 550);
                    // braco esquerdo
                    g.DrawLine(caneta2, 300, 250, 240, 350);
                    break;
                case 0:
                    // cabeca
                    g.DrawEllipse(caneta2, 260, 100, 80, 80);
                    //corpo
                    g.DrawLine(caneta2, 300, 180, 300, 450);
                    // perna esquerda
                    g.DrawLine(caneta2, 300, 450, 240, 550);
                    // perna direita
                    g.DrawLine(caneta2, 300, 450, 360, 550);
                    // braco esquerdo
                    g.DrawLine(caneta2, 300, 250, 240, 350);
                    // braco direito
                    g.DrawLine(caneta2, 300, 250, 360, 350);
                    // perdeu
                    perdeu();
                    break;
            }

        }
      
        private void palavra_tb_KeyUp(object sender, KeyEventArgs e)
        {
            if(!String.IsNullOrEmpty(palavra_tb.Text))
            {
                btn_salvar.Enabled = true;
            }
            
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            palavra = palavra_tb.Text;
            
            palavra_tb.Enabled = false;
            // printa palavra no resultado para testes
            // resultado_label.Text = palavra;

            // transforma a palavra em um array de chars
            charPalavra = palavra.ToCharArray();
            // Quantidade de letras da string
            qtdLetras = charPalavra.Length;
            // printa o tamanho do array para testes
            // resultado_label.Text = qtdLetras.ToString();

            for (int i = 0; i < qtdLetras; i++)
            {
                resultado_label.Text = resultado_label.Text + "*";
            }

            resultadoLetras = resultado_label.Text.ToCharArray();

            letra_tb.Enabled = true;
            tentar_btn.Enabled = true;
            tentar_palavra_tb.Enabled = true;
            tentar_palavra_btn.Enabled = true;
        }

        private void tentar_btn_Click(object sender, EventArgs e)
        {
            // Joga a letra em um char
            letra = letra_tb.Text[0];
            letra_tb.Text = "";
            // Printa letra no resultado para testes
            // resultado_label.Text = letra.ToString();

            int index = 0;

            // procura o char na no array de chars da palavra
            for (int i = 0; i < charPalavra.Length; i++)
            {
                if (letra == charPalavra[i])
                {
                    // index de onde encontrou a letra
                    index = i;
                    // printa o index de onde encontrou a letra na string
                    // resultado_label.Text = index.ToString();
                    if (index == 0)
                    {
                        resultadoLetras[0] = letra;
                    }
                    else
                    {
                        resultadoLetras[index] = letra;
                    }

                    string s = new string(resultadoLetras);
                    resultado_label.Text = s;
                }
            }

            if (index == 0)
            {
                tentativas--;
                pictureBox1.Refresh();
            }
            else
            {
                if (resultado_label.Text == palavra)
                {
                    resultado_label.Text = palavra;
                    venceu();
                }
            }
            

        }
        private void novo_jogo_btn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void tentar_palavra_btn_Click(object sender, EventArgs e)
        {
            if (tentar_palavra_tb.Text == palavra)
            {
                resultado_label.Text = palavra;
                venceu();
            }
            else
            {
                tentativas--;
                pictureBox1.Refresh();
            }
        }

        public void venceu()
        {
            btn_salvar.Enabled = false;
            letra_tb.Enabled = false;
            letra_tb.MaxLength = 1;
            tentar_btn.Enabled = false;
            tentar_palavra_tb.Enabled = false;
            tentar_palavra_btn.Enabled = false;
            resultado.Text = "Você venceu, deseja tentar novamente?";
        }

        public void perdeu()
        {
            btn_salvar.Enabled = false;
            letra_tb.Enabled = false;
            letra_tb.MaxLength = 1;
            tentar_btn.Enabled = false;
            tentar_palavra_tb.Enabled = false;
            tentar_palavra_btn.Enabled = false;
            resultado.Text = "Você perdeu, deseja tentar novamente?";
        }
    }
}
