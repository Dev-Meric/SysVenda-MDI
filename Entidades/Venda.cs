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
		public DateTime DataVenda { get; set; } = DateTime.Now;
		
		public List<ItemVenda> itensVenda = new List<ItemVenda>();
		public Cliente Cliente { get; set; }
        public decimal ValorTotal { get; internal set; }
    }
}
