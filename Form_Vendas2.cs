using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysVendas2;
using SysVendas2.Entidades;

namespace SysVenda_MDI
{
    public partial class Form_Vendas2 : Form
    {
        Produto produtoAtual;
        public Form_Vendas2()
        {
            InitializeComponent();
        }

        private void Btn_INSERIR_Click(object sender, EventArgs e)
        {

        }

        private void Btn_FINALIZAR_Click(object sender, EventArgs e)
        {

        }

        private void Form_Vendas2_Load(object sender, EventArgs e)
        {

        }

        private void Txt_Descricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Txt_ProdutoID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) 
            {

                using (Contexto contexto = new Contexto())
                {
                    produtoAtual  =  contexto.Produtos.FirstOrDefault(p => p.ProdutoID == Convert.ToInt16(Txt_ProdutoID.Text));
                }

                if (produtoAtual != null) 
                {
                    string Descricao = produtoAtual.Descricao;
                    string Unidade = produtoAtual.Unidade;
                    decimal Preco = produtoAtual.Preco;

                    Console.WriteLine($"Descrição: {Descricao}");
                    Console.WriteLine($"Unidade: {Unidade}");
                    Console.WriteLine($"Preço: {Preco}");
                }
                else
                {
                    Console.WriteLine("Produto não encontrado.");
                }
            }
        }
    }
}

