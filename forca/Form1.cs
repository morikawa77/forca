using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
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
        public string letrasTentadas;
        public string palavrasTentadas;

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
            qtdLetras_label.Text = "";
            imgFaustao.Visible = false;
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
            if (!String.IsNullOrWhiteSpace(palavra_tb.Text))
            {
                btn_salvar.Enabled = true;
            }
        }


        private void letra_tb_KeyUp(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrEmpty(letra_tb.Text))
            {
                tentar_btn.Enabled = true;
            }
        }

        private void tentar_palavra_tb_KeyUp(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrEmpty(tentar_palavra_tb.Text))
            {
                tentar_palavra_btn.Enabled = true;
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            palavra = palavra_tb.Text;

            // Desabilita o campo de texto
            palavra_tb.Enabled = false;

            // Habilita e envia o focus pro campo de texto char
            letra_tb.Enabled = true;
            letra_tb.Focus();

            // Desabilita o botao
            btn_salvar.Enabled = false;

            // printa palavra no resultado para testes
            // resultado_label.Text = palavra;

            // transforma a palavra em um array de chars
            charPalavra = palavra.ToCharArray();

            // Quantidade de letras da string
            qtdLetras = charPalavra.Length;

            // Printa a quantidade de letras da palavra
            qtdLetras_label.Text = $"A palavra tem {qtdLetras} letras.";

            // printa o tamanho do array para testes
            // resultado_label.Text = qtdLetras.ToString();

            // monta a palavra so com asteriscos
            for (int i = 0; i < qtdLetras; i++)
            {
                resultado_label.Text = resultado_label.Text + "*";
            }

            // printa a palavra so com asteriscos
            resultadoLetras = resultado_label.Text.ToCharArray();

            // Habilita textbox da palavra e desativa os botoes
            tentar_palavra_tb.Enabled = true;
            tentar_btn.Enabled = false;
            tentar_palavra_btn.Enabled = false;
        }

        private void tentar_btn_Click(object sender, EventArgs e)
        {
            // Joga a letra em um char
            letra = letra_tb.Text[0];

            // Verifica se  e a primeira vez a passar aqui
            if (letras_tentadas_tb.Text == "")
            {
                // Adiciona a letra as letras tentadas 
                letrasTentadas = "Letras tentadas: \r\n" + letra_tb.Text;
            }
            else
            {
                // Adiciona a letra as letras tentadas 
                letrasTentadas = letrasTentadas + ", " + letra_tb.Text;
            }

            // Printa as letras tentadas
            letras_tentadas_tb.Text = letrasTentadas;

            // Esvazia o campo de texto
            letra_tb.Text = "";

            // Desabilita o botao
            tentar_btn.Enabled = false;

            // Volta o focus pro campo de texto
            letra_tb.Focus();

            // Printa letra no resultado para testes
            // resultado_label.Text = letra.ToString();

            int index = 0;
            bool encontrou = false;

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

                    encontrou = true;
                }
            }

            
            if (!encontrou)
            {
                tentativas--;
                errou();
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
        private void tentar_palavra_btn_Click(object sender, EventArgs e)
        {
            // Verifica se e a primeira vez a passar aqui
            if (palavras_tentadas_tb.Text == "")
            {
                // Adiciona a palavra as palavras tentadas 
                palavrasTentadas = "Palavras tentadas: \r\n" + tentar_palavra_tb.Text;
            }
            else
            {
                // Adiciona a palavra as palavras tentadas 
                palavrasTentadas = palavrasTentadas + ", " + tentar_palavra_tb.Text;
            }

            // Printa as palavras tentadas
            palavras_tentadas_tb.Text = palavrasTentadas;

            if (tentar_palavra_tb.Text == palavra)
            {
                resultado_label.Text = palavra;
                venceu();
            }
            else
            {
                tentativas--;
                pictureBox1.Refresh();
                errou();

                tentar_palavra_tb.Text = "";
                tentar_palavra_tb.Focus();
                tentar_palavra_btn.Enabled = false;
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

        private void novo_jogo_btn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        public void errou()
        {
            try
            {
                // 20% de chance de aparecer
                Random rnd = new Random();
                int intRandom = rnd.Next(0, 4);

                if (intRandom == 1)
                {
                    System.IO.Stream str = Properties.Resources.errou;
                    System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                    snd.Play();

                    imgFaustao.Visible = true;
                    Task.Run(() =>
                    {
                        Thread.Sleep(2000);
                        this.Invoke(new Action(() =>
                        {
                            imgFaustao.Visible = false;
                        }));
                    });
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": " + ex.StackTrace.ToString(),"Error");
            }
        }

        /*
         * 
         *              M E N U S
         *  
         *  
         */

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void abrirPlacarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO criar Placar form
            new Placar().Show();
            this.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close();
            if (MessageBox.Show("Tem certeza que deseja sair?", "Sair", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void sobreOJogoDaForcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open dialog about the game
            MessageBox.Show("Jogo da Forca \n Desenvolvido por Reginaldo Morikawa");
        }
    }
}
