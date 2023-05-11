using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_01
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btn_exibir_Click(object sender, EventArgs e)
        {
            lb_mensagem.Text = "Olá, Amigo " + tb_nome.Text
                + "\n Seu curso é:" + cbox_curso.Text;

        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void lb_mensagem_Click(object sender, EventArgs e)
        {

        }
    }
}
