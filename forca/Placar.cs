using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forca
{
    public partial class Placar : Form
    {
        public Placar()
        {
            InitializeComponent();
        }

        /*
         * 
         *              M E N U S
         *  
         *  
         */
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sobreOJogoDaForcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open dialog about the game
            MessageBox.Show("Jogo da Forca \n Desenvolvido por Reginaldo Morikawa");
        }
    }
}
