using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysVendas2
{
	internal class Cliente
	{
		public int ClienteID { get; set; }
		public string Nome { get; set; }
		public string Rg { get; set; }
		public string CPF { get; set; }
		public DateTime DataNascimento { get; set; }
		public string Endereco { get; set; }
		public string Fone { get; set; }
		public string Email { get; set; }
	}
}
