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
    public partial class TelaCadastrar : Form
    {
        public TelaCadastrar()
        {
            InitializeComponent();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string senha = txt_senha.Text;
            string cpf = txt_cpf.Text;

            if (usuario == "" || senha == "" || cpf == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                foreach (Usuario str in Program.usuarios)
                {
                    if (usuario == str.usuario || cpf == str.cpf)
                    {
                        MessageBox.Show("Ja possui um cadastro vinculado!");
                    }
                    else
                    {
                        if (Validador.ValidaCPF(cpf) == true)
                        {
                            Usuario conexao = new Usuario(usuario, senha, cpf);
                            Program.usuarios.Add(conexao);
                            if (conexao.JsonSerealizarLista(Program.usuarios, "D:\\jsontrabalho\\Usuarios.json"))
                                MessageBox.Show("Salvo!");
                            TelaInicialProcessador tela = new TelaInicialProcessador();
                            this.Visible = false;
                            tela.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("CPF INVALIDO!");
                        }
                        break;
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaLogar tela = new TelaLogar();
            this.Visible = false;
            tela.ShowDialog();
        }
    }
}
