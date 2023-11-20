﻿using System;
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
    public partial class TelaInicialGabinete : Form
    {
        public int contador = 0;
        public TelaInicialGabinete()
        {
            InitializeComponent();
        }

        private void check_1_CheckedChanged(object sender, EventArgs e)
        {
            if (check_1.Checked == true)
            {
                btn_avancar.Visible = true;
                contador++;

                if (contador > 1)
                {
                    check_1.Checked = true;
                    check_2.Checked = false;
                    check_3.Checked = false;
                    check_4.Checked = false;
                    check_5.Checked = false;
                    check_6.Checked = false;
                    check_7.Checked = false;
                    check_8.Checked = false;
                }
            }
            else if (check_1.Checked == false)
            {
                contador--;
                if (contador > 0)
                {
                    btn_avancar.Visible = true;
                }
                else
                {
                    btn_avancar.Visible = false;
                }
            }
        }

        private void check_2_CheckedChanged(object sender, EventArgs e)
        {
            if (check_2.Checked == true)
            {
                btn_avancar.Visible = true;
                contador++;

                if (contador > 1)
                {
                    check_1.Checked = false;
                    check_2.Checked = true;
                    check_3.Checked = false;
                    check_4.Checked = false;
                    check_5.Checked = false;
                    check_6.Checked = false;
                    check_7.Checked = false;
                    check_8.Checked = false;
                }
            }
            else if (check_2.Checked == false)
            {
                contador--;
                if (contador > 0)
                {
                    btn_avancar.Visible = true;
                }
                else
                {
                    btn_avancar.Visible = false;
                }
            }
        }

        private void check_3_CheckedChanged(object sender, EventArgs e)
        {
            if (check_3.Checked == true)
            {
                btn_avancar.Visible = true;
                contador++;

                if (contador > 1)
                {
                    check_1.Checked = false;
                    check_2.Checked = false;
                    check_3.Checked = true;
                    check_4.Checked = false;
                    check_5.Checked = false;
                    check_6.Checked = false;
                    check_7.Checked = false;
                    check_8.Checked = false;
                }
            }
            else if (check_3.Checked == false)
            {
                contador--;
                if (contador > 0)
                {
                    btn_avancar.Visible = true;
                }
                else
                {
                    btn_avancar.Visible = false;
                }
            }
        }

        private void check_4_CheckedChanged(object sender, EventArgs e)
        {
            if (check_4.Checked == true)
            {
                btn_avancar.Visible = true;
                contador++;

                if (contador > 1)
                {
                    check_1.Checked = false;
                    check_2.Checked = false;
                    check_3.Checked = false;
                    check_4.Checked = true;
                    check_5.Checked = false;
                    check_6.Checked = false;
                    check_7.Checked = false;
                    check_8.Checked = false;
                }
            }
            else if (check_4.Checked == false)
            {
                contador--;
                if (contador > 0)
                {
                    btn_avancar.Visible = true;
                }
                else
                {
                    btn_avancar.Visible = false;
                }
            }
        }

        private void check_5_CheckedChanged(object sender, EventArgs e)
        {
            if (check_5.Checked == true)
            {
                btn_avancar.Visible = true;
                contador++;

                if (contador > 1)
                {
                    check_1.Checked = false;
                    check_2.Checked = false;
                    check_3.Checked = false;
                    check_4.Checked = false;
                    check_5.Checked = true;
                    check_6.Checked = false;
                    check_7.Checked = false;
                    check_8.Checked = false;
                }
            }
            else if (check_5.Checked == false)
            {
                contador--;
                if (contador > 0)
                {
                    btn_avancar.Visible = true;
                }
                else
                {
                    btn_avancar.Visible = false;
                }
            }
        }

        private void check_6_CheckedChanged(object sender, EventArgs e)
        {
            if (check_6.Checked == true)
            {
                btn_avancar.Visible = true;
                contador++;

                if (contador > 1)
                {
                    check_1.Checked = false;
                    check_2.Checked = false;
                    check_3.Checked = false;
                    check_4.Checked = false;
                    check_5.Checked = false;
                    check_6.Checked = true;
                    check_7.Checked = false;
                    check_8.Checked = false;
                }
            }
            else if (check_6.Checked == false)
            {
                contador--;
                if (contador > 0)
                {
                    btn_avancar.Visible = true;
                }
                else
                {
                    btn_avancar.Visible = false;
                }
            }
        }

        private void check_7_CheckedChanged(object sender, EventArgs e)
        {
            if (check_7.Checked == true)
            {
                btn_avancar.Visible = true;
                contador++;

                if (contador > 1)
                {
                    check_1.Checked = false;
                    check_2.Checked = false;
                    check_3.Checked = false;
                    check_4.Checked = false;
                    check_5.Checked = false;
                    check_6.Checked = false;
                    check_7.Checked = true;
                    check_8.Checked = false;
                }
            }
            else if (check_7.Checked == false)
            {
                contador--;
                if (contador > 0)
                {
                    btn_avancar.Visible = true;
                }
                else
                {
                    btn_avancar.Visible = false;
                }
            }
        }

        private void check_8_CheckedChanged(object sender, EventArgs e)
        {
            if (check_8.Checked == true)
            {
                btn_avancar.Visible = true;
                contador++;

                if (contador > 1)
                {
                    check_1.Checked = false;
                    check_2.Checked = false;
                    check_3.Checked = false;
                    check_4.Checked = false;
                    check_5.Checked = false;
                    check_6.Checked = false;
                    check_7.Checked = false;
                    check_8.Checked = true;
                }
            }
            else if (check_8.Checked == false)
            {
                contador--;
                if (contador > 0)
                {
                    btn_avancar.Visible = true;
                }
                else
                {
                    btn_avancar.Visible = false;
                }
            }
        }

        private void btn_avancar_Click(object sender, EventArgs e)
        {
            string selecionada = string.Empty;//VARIAVEL COM VALOR EMPYT (VAZIO)
            foreach (Control controle in this.Controls)//PERCORRE TODOS AS FERRAMENTAS DO FORMS
            {
                if (controle is CheckBox checkBox && checkBox.Checked)//ENTRE TODAS AS FERRAMENTAS, PEGA SOMENTE OS CHECKBOX, E OS CHECK BOX QUE TIVEREM ATIVADO
                {
                    selecionada = checkBox.Name;//NA VARIAVEL selecionada FICARA SALVO O NOME DA VARIAVEL SELECIONADA 
                }
            }

            if (selecionada == check_1.Name)
            {
                Program.componentes[5] = 157.90.ToString("C2");
            }
            else if (selecionada == check_2.Name)
            {
                Program.componentes[5] = 470.77.ToString("C2");
            }
            else if (selecionada == check_3.Name)
            {
                Program.componentes[5] = 129.99.ToString("C2");
            }
            else if (selecionada == check_4.Name)
            {
                Program.componentes[5] = 258.71.ToString("C2");
            }
            else if (selecionada == check_5.Name)
            {
                Program.componentes[5] = 234.00.ToString("C2");
            }
            else if (selecionada == check_6.Name)
            {
                Program.componentes[5] = 149.99.ToString("C2");
            }
            else if (selecionada == check_7.Name)
            {
                Program.componentes[5] = 1039.90.ToString("C2");
            }
            else if (selecionada == check_8.Name)
            {
                Program.componentes[5] = 2195.90.ToString("C2");
            }
            TelaInicialFonte tela = new TelaInicialFonte();
            this.Visible = false;
            tela.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaInicialSSD tela = new TelaInicialSSD();
            this.Visible = false;
            tela.ShowDialog();
        }
    }
}
