using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaLogin
{
    public partial class frmCalculoIMC : Form
    {
        public frmCalculoIMC()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int peso = int.Parse(txtPeso.Text);
            float altura = float.Parse(txtAltura.Text);

            float imc = (float)peso / (altura * altura);

            lbIMC.Text = imc.ToString("F2");

            string classificacao = "";
            string aviso = "";

            if (imc >= 16 && imc <= 16.9)
            {
                classificacao = "Muito abaixo do peso";
            }
            else
            {
                if (imc >= 17 && imc <= 18.4)
                {
                    classificacao = "Abaixo do peso";
                }
                else
                {
                    if (imc > 18.4 && imc <= 24.9)
                    {
                        classificacao = "Peso normal";
                        aviso = "Menor risco de doenças cardíacas e vasculares";

                    }
                    else
                    {
                        if (imc > 24.9 && imc <= 29.9)
                        {
                            classificacao = "Acima do peso";
                        }
                        else
                        {
                            if (imc > 29.9 && imc <= 34.9)
                            {
                                classificacao = "Obesidade grau I";
                            }
                            else
                            {
                                if (imc > 34.9 && imc <= 40)
                                {
                                    classificacao = "Obesidade grau II";
                                }
                            }
                        }
                    }
                }
            }
            lbClassificacao.Text = classificacao;
            DialogResult resposta = MessageBox.Show(aviso + "\nCalcular Novamente?","Resultado",MessageBoxButtons.YesNo);
            if (resposta == DialogResult.No)
            {
                this.Close();
            }
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
