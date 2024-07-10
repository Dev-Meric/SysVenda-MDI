using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysVenda_MDI.Entidades
{

	enum TipoUsuario
	{
		COMUM,
		ADMIN
	}

	internal class Usuario
	{
		public int UsuarioId { get; set; }
		public string Nome { get; set; }
		public string Login { get; set; }
		public string Senha { get; set; }
		public TipoUsuario Perfil { get; set; } = TipoUsuario.COMUM;
	}

	//funcao
}
