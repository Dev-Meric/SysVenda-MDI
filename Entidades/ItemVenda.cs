using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SysVenda_MDI.Entidades
{
	internal class ItemVenda
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ItemVendaId { get; set; }
		public int VendaId { get; set; }
		public int ProdutoId { get; set; }
		public decimal Quantidade { get; set; }
		public decimal ValorUnitario { get; set; }
		public decimal SubTotal { get { return ValorUnitario * Quantidade; } }
		public Venda Venda { get; set; }
		public Produto Produto { get; set; }
	}
}
