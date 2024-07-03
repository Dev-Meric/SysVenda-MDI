using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysVendas2.Entidades
{
	internal class Produto
	{
		public int ProdutoID { get; set; }
		public string Descricao { get; set; }
		public string Unidade { get; set; }
		public decimal Preco { get; set; }
	}
}
