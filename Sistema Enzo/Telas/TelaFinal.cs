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
    public partial class TelaFinal : Form
    {
        public TelaFinal()
        {
            InitializeComponent();


            Computador conexao = new Computador(Program.componentes[0], Program.componentes[1], Program.componentes[2], Program.componentes[3], Program.componentes[4], Program.componentes[5], Program.componentes[6], Program.componentes[7]);
            Program.totalComputador.Add(conexao);

            foreach (Computador str in Program.totalComputador)
            {
                lbl_processador.Text = str.processador.ToString();
                lbl_placaMae.Text = str.placaMae.ToString();
                lbl_ram.Text = str.memoriaRam.ToString();
                lbl_placaVideo.Text = str.placaVideo.ToString();
                lbl_ssd.Text = str.ssd.ToString();
                lbl_gabinete.Text = str.gabinete.ToString();
                lbl_fonte.Text = str.fonte.ToString();
                lbl_cooler.Text = str.cooler.ToString();
            }

            lbl_subTotal.Text = (Total() / 100.0).ToString("C2");//FOI FEITO A DIVISAO PARA FIVAR BONITINHO O NUMERO NA TELA. PARA O C2 RECONHECER CORRETAMENTE
            lbl_total.Text = (Total() / 100.0).ToString("C2");
        }


        public double Total()
        {
            double total = 0;

            foreach (Computador str in Program.totalComputador)
            {
                double processador = Convert.ToDouble(str.processador.Replace(".", "").Replace(",", "").Replace("R$", ""));
                double placaMae = Convert.ToDouble(str.placaMae.Replace(".", "").Replace(",", "").Replace("R$", ""));
                double ram = Convert.ToDouble(str.memoriaRam.Replace(".", "").Replace(",", "").Replace("R$", ""));
                double placaVideo = Convert.ToDouble(str.placaVideo.Replace(".", "").Replace(",", "").Replace("R$", ""));
                double ssd = Convert.ToDouble(str.ssd.Replace(".", "").Replace(",", "").Replace("R$", ""));
                double gabinete = Convert.ToDouble(str.gabinete.Replace(".", "").Replace(",", "").Replace("R$", ""));
                double fonte = Convert.ToDouble(str.fonte.Replace(".", "").Replace(",", "").Replace("R$", ""));
                double cooler = Convert.ToDouble(str.cooler.Replace(".", "").Replace(",", "").Replace("R$", ""));
                total = processador + placaMae + ram + placaVideo + ssd + gabinete + fonte + cooler;
            }
            return total;
        }

        private void btn_aplicar_Click(object sender, EventArgs e)
        {
            double totalDesconto = 0;
            double valorTotal = 0;
            string cupomDesconto = txt_cupom.Text;

            if (cupomDesconto == "PFVMEDANOTA")
            {
                totalDesconto = (Total() * 10) / 100;
                valorTotal = Total() - totalDesconto;
                lbl_cupom.Text = (totalDesconto / 100.0).ToString("C2");
                lbl_total.Text = (valorTotal / 100.0).ToString("C2");
                MessageBox.Show("Cupom Inserido!");
            }
            else
            {
                lbl_total.Text = (Total() / 100.0).ToString("C2");
                lbl_cupom.Text = null;
                txt_cupom.Text = null;
                MessageBox.Show("Cupom Invalido!");

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaTroll tela = new TelaTroll();
            this.Visible = false;
            tela.ShowDialog();
        }
    }
}
