using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysVenda_MDI.Entidades;
using Vip.Printer.Enums;
using Vip.Printer;

namespace SysVenda_MDI
{
    public partial class Form_Vendas2 : Form
    {
        Produto produtoAtual;
        Venda vendaAtual = new Venda();
        Cliente clienteVenda = new Cliente();
        ItemVenda ItemVendaAtual = new ItemVenda();
        List<ItemVenda> itensDaVenda = new List<ItemVenda>();

        int idItemDaVenda = 0;

        decimal valorTotalVenda = 0;
        decimal valorPago = 0;

        public Form_Vendas2()
        {
            InitializeComponent();
        }

        private void Btn_INSERIR_Click(object sender, EventArgs e)
        {
            itensDaVenda.Add(
               new ItemVenda
               {
                   VendaId = 0,
                   ProdutoId = produtoAtual.ProdutoID,
                   Quantidade = ItemVendaAtual.Quantidade,
                   ValorUnitario = produtoAtual.Preco
               }
           );
            Dgv_ItemVenda.Rows.Add(
                ++idItemDaVenda,
                produtoAtual.Descricao,
                ItemVendaAtual.ValorUnitario.ToString("C2", CultureInfo.CurrentCulture),
                ItemVendaAtual.Quantidade,
                ItemVendaAtual.SubTotal.ToString("C2", CultureInfo.CurrentCulture)
             );

            valorTotalVenda += ItemVendaAtual.SubTotal;

            //Lbl_TotalVenda.Text = valorTotalVenda.ToString("C2", CultureInfo.CurrentCulture);
        }

        private void Btn_FINALIZAR_Click(object sender, EventArgs e)
        {
            using (var ctx = new Contexto())
            {
                vendaAtual.ValorTotal = valorTotalVenda;

                Venda ultimaVenda = ctx.Vendas.OrderByDescending(v => v.VendaID).Take(1).Last();
                int idVendaAtual = ultimaVenda.VendaID;

                vendaAtual.VendaID = ++idVendaAtual;

                // vendaAtual.StatusVenda = TiposStatusVenda.CONCLUIDA;

                ctx.Vendas.Add(vendaAtual);
                ctx.SaveChanges();

                itensDaVenda.ForEach(item =>
                {
                    item.VendaId = vendaAtual.VendaID;
                });

                ctx.ItensVendas.AddRange(itensDaVenda);
                ctx.SaveChanges();
            }


            List<ItemVendaDTO> intem = new List<ItemVendaDTO>();


            Printer printer = ObterPrinter();
            printer.InitializePrint();

            printer.NewLines(5);
            printer.BoldMode("Nota de Venda");

            foreach (DataGridViewRow row in Dgv_ItemVenda.Rows)
            {
                if (!row.IsNewRow)
                {
                    ItemVendaDTO item = new ItemVendaDTO();
                    item.IdItemDaVenda = row.Cells[0].Value.ToString();
                    item.Nome = row.Cells[1].Value as string;
                    item.PrecoUnitario = row.Cells[2].Value as string;
                    item.QuantidadeVendida = row.Cells[3].Value.ToString();
                    item.SubTotalDoItem = row.Cells[4].Value as string;

                    //printer.WriteLine($"   {item.IdItemDaVenda}  {item.Nome}  {item.QuantidadeVendida}  {item.PrecoUnitario}  {item.SubTotalDoItem}");
                    printer.WriteLine(PrintLinha1(item.IdItemDaVenda, item.Nome));
                    printer.WriteLine(PrintLinha2(item.PrecoUnitario, Txt_Qtd.Text, "Kg", item.SubTotalDoItem));

                    // Faz algo com o valor da célula
                    printer.NewLine();
                }
            }


            printer.NewLines(10);
            printer.Separator();
            printer.PartialPaperCut(true);

            printer.PrintDocument();
        }


        string PrintLinha1(string strIdProd, string nomeProduto)
        {
            StringBuilder linhaProduto = new StringBuilder();

            int buffer = 5;
            int qtdEspaco = buffer - strIdProd.Length;

            linhaProduto.Append(' ', qtdEspaco);
            linhaProduto.Append(strIdProd);
            linhaProduto.Append(" | ");
            linhaProduto.Append(nomeProduto);

            return linhaProduto.ToString();
        }

        string PrintLinha2(string precoProd, string qtdVendida, string unidade, string strSubTotal)
        {
            StringBuilder linhaValores = new StringBuilder();
            //Linha 2 - valores
            // configuração do valor unitário
            //string precoProd = preco.ToString("C2", CultureInfo.CurrentCulture);
            int bufferPrecoProd = 13;
            int qtdEspacoPrecoProd = bufferPrecoProd - precoProd.Length;

            linhaValores.Append(' ', qtdEspacoPrecoProd);
            linhaValores.Append(precoProd);
            linhaValores.Append("  ");

            //configurações de unidade de medida
            int bufferUnidProd = 7;
            int qtdEspacoUnidProd = bufferUnidProd - unidade.Length;
            linhaValores.Append(' ', qtdEspacoUnidProd);
            linhaValores.Append(unidade);
            linhaValores.Append("  ");

            //configurações de unidade de medida
            string qtdProd = qtdVendida.ToString();
            int bufferQtdProd = 9;
            int qtdEspacoQtdProd = bufferQtdProd - qtdProd.Length;
            linhaValores.Append(' ', qtdEspacoQtdProd);
            linhaValores.Append(qtdProd);
            linhaValores.Append("  ");

            //configurações de unidade de medida
            //string strSubTotal = subTotal.ToString("C2", CultureInfo.CurrentCulture);
            int bufferSubTotProd = 11;
            int qtdEspacoSubTotProd = bufferSubTotProd - strSubTotal.Length;
            linhaValores.Append(' ', qtdEspacoSubTotProd);
            linhaValores.Append(strSubTotal);

            return linhaValores.ToString();
        }

        private Printer ObterPrinter()
        {
            return new Printer("192.168.30.75", PrinterType.Bematech, 1, 1, 1, null, ProtocolType.Network);
        }

        string buildLinha1(string id, string prodNome)
        {
            int bufferToId = 4;
            int bufferToProduto = 41;

            StringBuilder linha = new StringBuilder();

            //Id do produto
            int buffer = bufferToId - id.Length;

            linha.Append(" ", 0, buffer);
            linha.Append(id);
            linha.Append("| ");

            //Nome do produto
            buffer = bufferToProduto - prodNome.Length;

            linha.Append(" ");

            return linha.ToString();
        }

        string buildLinha2(string qtd, string valorUnid, string valorSubTotal)
        {
            StringBuilder linha = new StringBuilder();

            int bufferToQtd = 13;
            int bufferToValUnid = 12;
            int bufferToValSubTotal = 20;


            return linha.ToString();
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
                    produtoAtual = contexto.Produtos.FirstOrDefault(p => p.ProdutoID == Convert.ToInt16(Txt_ProdutoID.Text));
                }

                if (produtoAtual != null)
                {
                    Txt_Produto.Text = produtoAtual.Descricao;
                    Txt_UnidadeMed.Text = produtoAtual.Unidade;
                    Txt_ValorUnit.Text = produtoAtual.Preco.ToString("C2", CultureInfo.CurrentCulture);
                }
                else
                {
                    Console.WriteLine("Produto não encontrado.");
                }
            }
        }

        private void Txt_ValorPago_TextChanged(object sender, EventArgs e)
        {
            if (Txt_ValorPago.Text.Length > 0)
            {
                decimal troco = Convert.ToDecimal(Txt_ValorPago.Text) - valorTotalVenda;

                Txt_ValorPago.Text = troco.ToString("C2", CultureInfo.CurrentCulture);
                if (troco < 0)
                {
                    //Lbl_ValorTroco.ForeColor = Color.Red;
                }
                else
                {
                    //Lbl_ValorTroco.ForeColor = Color.Green;
                }
            }
        }

        private void Txt_ProdutoID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Produto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Qtd_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Qtd.Text.Length > 0)
            {
                int qtdVendida = Convert.ToInt32(Txt_Qtd.Text);

                if (qtdVendida > 0)
                {
                    ItemVendaAtual.Quantidade = qtdVendida;
                    Txt_Subtotal.Text = ItemVendaAtual.SubTotal.ToString("C2", CultureInfo.CurrentCulture);
                }
            }
            else
            {
                Txt_Subtotal.Text = string.Empty;
            }
        }

        private void Txt_Subtotal_TextChanged(object sender, EventArgs e)
        {

            if (decimal.TryParse(Txt_Qtd.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal quantidade) &&
                decimal.TryParse(Txt_ValorUnit.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal valorUnitario))
            {

                decimal subtotal = quantidade * valorUnitario;


                Txt_Subtotal.Text = subtotal.ToString("C2", CultureInfo.CurrentCulture);
            }
            else
            {

                Txt_Subtotal.Text = string.Empty;
            }
        }

        private void Txt_ValorUnit_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(Txt_Qtd.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal quantidade) &&
                decimal.TryParse(Txt_ValorUnit.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal valorUnitario))
            {

                ItemVendaAtual.Quantidade = quantidade;
                ItemVendaAtual.ValorUnitario = valorUnitario;


                decimal subtotal = ItemVendaAtual.SubTotal;


                Txt_Subtotal.Text = subtotal.ToString("C2", CultureInfo.CurrentCulture);
            }
            else
            {

                Txt_Subtotal.Text = string.Empty;
            }
        }


        private void Txt_Cliente_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Cliente.Text.Length > 0)
            {

                int idCliente = Convert.ToInt32(Txt_Cliente.Text);
                Cliente clienteAtual = new Cliente();

                //LblStatusBuscaCliente.Text = "Buscando cliente";
                // LblStatusBuscaCliente.ForeColor = Color.Green;

                using (var context = new Contexto())
                {
                    clienteAtual = context.Clientes.FirstOrDefault(p => p.ClienteID == idCliente);

                    if (clienteAtual != null)
                    {
                        Txt_Cliente.Text = clienteAtual.Nome;

                        //vendaAtual.Cliente = clienteAtual;
                        vendaAtual.ClientID = clienteAtual.ClienteID;

                        //LblStatusBuscaCliente.Text = "Status cliente";
                        //LblStatusBuscaCliente.ForeColor = Color.Black;
                    }
                    else
                    {
                        //LblStatusBuscaCliente.Text = "Cliente não encontrado";
                        //LblStatusBuscaCliente.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void Txt_Toco(object sender, EventArgs e)
        {

        }
    }
}

