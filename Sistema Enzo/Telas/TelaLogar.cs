using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Enzo.Telas
{
    public partial class TelaLogar : Form
    {
        public TelaLogar()
        {
            InitializeComponent();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txt_usuario.Text;
                string senha = txt_senha.Text;

                foreach (Usuario str in Program.usuarios)
                {
                    if (str.usuario == usuario && str.senha == senha)
                    {
                        TelaInicialProcessador conexao = new TelaInicialProcessador();
                        this.Visible = false;
                        conexao.ShowDialog();
                    }
                    else
                    {
                        txt_aviso.Text = "Usuario ou senha incorreta!";
                    }
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaCadastrar tela = new TelaCadastrar();
            this.Visible = false;
            tela.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
