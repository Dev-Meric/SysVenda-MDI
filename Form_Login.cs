using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysVenda_MDI.Entidades;
using SysVendas2;

namespace SysVenda_MDI
{
	public partial class Form_Login : Form
	{
		Usuario usuario;
		public Form_Login()
		{
			InitializeComponent();
		}


		private void Btn_Acessar_Click(object sender, EventArgs e)
		{
			string User = "admin";
			string Password = "admin";

			try
			{
				using (Contexto contexto = new Contexto())
				{
					usuario = contexto.Usuarios.FirstOrDefault(u => u.Login == TxtUsuário.Text);
				}

				if (usuario != null)
				{
					if (usuario.Senha == TxtSenha.Text)
					{
						MessageBox.Show("Acesso liberado");
						Form formMain = new Form_Principal2();
						formMain.Show();
						this.Hide();
					}
					else
					{
						MessageBox.Show("Usuário ou Senha incorretos.");
					}
				}
				else
				{
					MessageBox.Show("Usuário ou Senha incorretos.");
				}
			}
			catch (System.InvalidOperationException) {
				MessageBox.Show("Erro ao se conectar com o sevidor");
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
