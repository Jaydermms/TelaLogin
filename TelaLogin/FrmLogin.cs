using System;
using TelaLogin.Entities;
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
    public partial class FrmLogin : Form
    {
        public static bool Cancelar = false;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string senha = txtSenha.Text;

            if(ValidacaoLogin.UsuarioLogado(user, senha))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Usuario ou Senha Incorretos!");
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtUsuario.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            Close();
        }
    }
}
