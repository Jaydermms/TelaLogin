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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();

            while(ValidacaoLogin.UserLogado == null)
            {
                Visible = false;
                frmLogin.ShowDialog();
                if (FrmLogin.Cancelar)
                {
                    Application.Exit();
                    return;
                }
            }
            Visible = true;
        }
    }
}
