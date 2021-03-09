using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analizador_Lexico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text = "88 * (5 + 1250)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String entrada = richTextBox1.Text;
            AnalizadorLexico lex = new AnalizadorLexico();
            LinkedList<Token> lTokens = lex.escanear(entrada);
            lex.imprimirListaToken(lTokens);

        }
    }
}
