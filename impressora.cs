using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using SysVendas2.Entidades;
using Vip.Printer;
using Vip.Printer.Enums;

namespace SysVenda_MDI
{
    public partial class impressora : Form
    {
        private Printer ObterPrinter()
        {
            // Ajuste do Encoding para se adequar à impressora.
            return new Printer("192.168.30.75", PrinterType.Bematech, 1, 1, 1, null, ProtocolType.Network);
        }

        void ImprimirTeste()
        {
            Printer printer = ObterPrinter();

            try
            {
                printer.InitializePrint();
                printer.AlignCenter();
                printer.NewLines(2);

                printer.Image(Properties.Resources.logo_MDI, true);

                printer.InitializePrint();
                printer.AlignCenter();
                //printer.NewLines(5);

                printer.WriteLine("SISTEMA DE VENDAS");
                printer.WriteLine("SENAC CASTANHAL");
                printer.WriteLine("Mestres da Informática");

                printer.NewLines(1);
                printer.AlignLeft();

                Produto produto = new Produto
                {
                    ProdutoID = 2,
                    Descricao = "Abacaxi",
                    Unidade = "Unid",
                    Preco = 10
                };
                int quantidade = 5;

                StringBuilder linhaProduto = new StringBuilder();
                string idProduto = produto.ProdutoID.ToString();
                linhaProduto.Append(idProduto.PadLeft(5))
                            .Append(" | ")
                            .Append(produto.Descricao);

                string precoProduto = produto.Preco.ToString("C2", CultureInfo.CurrentCulture);
                StringBuilder linhaPreco = new StringBuilder();
                linhaPreco.Append(precoProduto.PadLeft(13))
                          .Append(" | ")
                          .Append(produto.Unidade.PadLeft(5))
                          .Append("  | ")
                          .Append(quantidade.ToString().PadLeft(9))
                          .Append(" | ")
                          .Append((produto.Preco * quantidade).ToString("C2", CultureInfo.CurrentCulture).PadLeft(10));

                printer.WriteLine("   id | Nome");
                printer.WriteLine("      | Preço |  UNID  |   Quant   |   Subtotal");
                printer.WriteLine("------------------------------------------------");

                printer.WriteLine(linhaProduto.ToString());
                printer.WriteLine(linhaPreco.ToString());

                printer.NewLines(10);
                printer.Separator();
                printer.PartialPaperCut(true);

                printer.PrintDocument();
            }
            catch (Exception ex)
            {
                // Mostra uma mensagem de erro e registra o erro usando o método LogError.
                MessageBox.Show($"Erro ao tentar imprimir: {ex.Message}", "Erro de Impressão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogError(ex);
            }
        }

        private void LogError(Exception ex)
        {
            // Caminho para o arquivo de log
            string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "error.log");

            // Mensagem de erro a ser gravada no log
            string errorMessage = $"{DateTime.Now}: {ex.Message}\n{ex.StackTrace}\n\n";

            try
            {
                // Adiciona a mensagem de erro ao arquivo de log
                File.AppendAllText(logFilePath, errorMessage);
            }
            catch (Exception fileEx)
            {
                // Se ocorrer um erro ao gravar o log, você pode querer notificar o usuário ou registrar de outra forma
                MessageBox.Show($"Erro ao registrar o erro: {fileEx.Message}", "Erro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public impressora()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        private void ButtonImpressora_Click(object sender, EventArgs e)
        {
            ImprimirTeste();
        }
    }
}
