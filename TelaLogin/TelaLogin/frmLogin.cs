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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (usuario == "brunomanzoli" && senha == "123456")
            {
                //ABRIR FORMULÁRIO PARA CÁLCULO DE IMC
                frmCalculoIMC fCalculoIMC = new frmCalculoIMC();
                this.Hide();
                fCalculoIMC.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Acesso Negado! Usuário e/ou Senha inválidos.");
            }

        }
    }
}
