using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using SysVenda_MDI.Entidades;

namespace SysVenda_MDI
{
	public partial class Form_Clientes2 : Form
	{
		int estadoUsuario = 0;

		Cliente cliente;

		int clienteID;

		List<Cliente> clientes;

		private Contexto contexto;
		public Form_Clientes2()
		{
			InitializeComponent();

			clientes = new List<Cliente>();

			using (var clientesCxt = new Contexto())
			{
				clientes = clientesCxt.Clientes.ToList();
			}

			DGV_ListaClientes.DataSource = clientes;

			contexto = new Contexto();
		}

		private void Btn_INSERIR_Click(object sender, EventArgs e)
		{
			DateTime dataNascimento;
			DateTime.TryParseExact(Txt_NASCIMENTO.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNascimento);

			//Criar um novo cliente com os dados do formulário
			Cliente novocliente = new Cliente()
			{
				Nome = Txt_NOME_CLIENTES.Text,
				Rg = Txt_RG.Text,
				CPF = Txt_CPF.Text,
				DataNascimento = dataNascimento,
				Endereco = Txt_ENDERECO.Text,
				Fone = Txt_FONE.Text,
				Email = Txt_EMAIL.Text,
			};

			contexto.Clientes.Add(novocliente);
			contexto.SaveChanges();
			clientes = new List<Cliente>();

			using (var clientesCxt = new Contexto())
			{
				clientes = clientesCxt.Clientes.ToList();
			}

			DGV_ListaClientes.DataSource = clientes;
			MessageBox.Show("Cliente adicionado com sucesso! 😁");

			//Limpeza das caixas de texto
			Txt_NOME_CLIENTES.Text = "";
			Txt_RG.Text = "";
			Txt_CPF.Text = "";
			Txt_EMAIL.Text = "";
			Txt_ENDERECO.Text = "";
			Txt_NASCIMENTO.Text = "";
			Txt_FONE.Text = "";
			Txt_NOME_CLIENTES.Focus();

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void Btn_ATUALIZAR_Click(object sender, EventArgs e)
		{
			if (estadoUsuario == 2)
			{
				using (var contexto = new Contexto())
				{
					var clienteRegistrado = contexto.Clientes.FirstOrDefault(c => c.ClienteID == clienteID);

					clienteRegistrado.Nome = Txt_NOME_CLIENTES.Text;
					clienteRegistrado.Rg = Txt_RG.Text;
					clienteRegistrado.CPF = Txt_CPF.Text;
					//clienteRegistrado.Nascimento = Txt_NASCIMENTO.Text;
					clienteRegistrado.Endereco = Txt_ENDERECO.Text;
					clienteRegistrado.Fone = Txt_FONE.Text;
					clienteRegistrado.Email = Txt_EMAIL.Text;

					contexto.Clientes.Update(clienteRegistrado);
					contexto.SaveChanges();

					// Atualiza o DataGrideView com os dados inseridos recentemente
					clientes = new List<Cliente>();
					clientes = contexto.Clientes.ToList();

					DGV_ListaClientes.DataSource = clientes;
				}

				estadoUsuario = 1;

			}
			else
			{
				if (DGV_ListaClientes.SelectedRows.Count > 0)
				{
					Cliente clientesSelected = DGV_ListaClientes.SelectedRows[0].DataBoundItem as Cliente;

					//Txt_ClienteID.Text = clientesSelected.ClienteID.ToString();
					clienteID = clientesSelected.ClienteID;
					Txt_NOME_CLIENTES.Text = clientesSelected.Nome;
					Txt_RG.Text = clientesSelected.Rg;
					Txt_CPF.Text = clientesSelected.CPF;
					//clienteSelected.Nascimento = Txt_NASCIMENTO.Text;
					Txt_ENDERECO.Text = clientesSelected.Endereco;
					Txt_FONE.Text = clientesSelected.Fone;
					Txt_EMAIL.Text = clientesSelected.Email;

					estadoUsuario = 2;
				}
			}

		}

		private void Btn_EXCLUIR_Click(object sender, EventArgs e)
		{
			if (DGV_ListaClientes.SelectedRows.Count > 0)
			{
				Cliente clientesSelected = DGV_ListaClientes.SelectedRows[0].DataBoundItem as Cliente;

				using (var contexto = new Contexto())
				{
					var clienteParaDeletar = contexto.Clientes.FirstOrDefault(c => c.ClienteID == clientesSelected.ClienteID);

					contexto.Clientes.Remove(clienteParaDeletar);
					contexto.SaveChanges();

					//Atualiza o DataGrideView com a lista sem o cliente deletado
					clientes = new List<Cliente>();
					clientes = contexto.Clientes.ToList();

					DGV_ListaClientes.DataSource = clientes;
				}
			}
		}

		private void Txt_CEP_Click(object sender, EventArgs e)
		{
			string cep = ButtonClick.Text;
			ClienteAPI cliente = new ClienteAPI();

			Endereco resp = cliente.GetEndereco("68743570");

			//Chamar a função clienteAPI.GetEndereco(cep)
			Txt_ENDERECO.Text = resp.logradouro + ", " + resp.localidade + "/" + resp.uf;
		}

		private void Txt_ENDERECO_TextChanged(object sender, EventArgs e)
		{

		}

		private void Txt_NOME_CLIENTES_TextChanged(object sender, EventArgs e)
		{

		}

		private void Form_Clientes2_Load(object sender, EventArgs e)
		{

		}
	}
}
