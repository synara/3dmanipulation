using Drawing.CG.Uni7.VF.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing.CG.Uni7.VF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){}

        private void btnRotacao_Click(object sender, EventArgs e)
        {
            var rotacao = new frmRotacao();
            rotacao.Show();
        }


        private void ManipularOpcoes()
        {
            btnEscala.Visible = !btnEscala.Visible;
            btnRotacao.Visible = !btnRotacao.Visible;
            btnTransfSequenciais.Visible = !btnTransfSequenciais.Visible;
            btnTranslacao.Visible = !btnTranslacao.Visible;
        }
    }
}
