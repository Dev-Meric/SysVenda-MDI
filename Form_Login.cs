using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysVenda_MDI
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }


        private void Btn_Acessar_Click(object sender, EventArgs e)
        {
            string User = "admin";
            string Password = "admin";

            if (TxtUsuário.Text == User & TxtSenha.Text == Password)
            {
                MessageBox.Show("Acesso liberado");
                Form formMain = new Form();
                formMain.Show();
                this.Hide();
            }else 
             {
                MessageBox.Show("Usuário ou Senha incorretos.");

             }
        }
    }
}
