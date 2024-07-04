using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysVenda_MDI.Entidades
{
	internal class Venda
	{
		public int VendaID { get; set; }
		public int ClientID { get; set; }
		public int ProdutoID { get; set; }
		public DateTime DataVenda { get; set; }
		public int Quantidade { get; set; }

		public Cliente Cliente { get; set; }
		public Produto Produto { get; set; }
	}
}
