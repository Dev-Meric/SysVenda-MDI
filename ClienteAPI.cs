using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysVenda_MDI;

namespace SysVenda_MDI
{
	internal class ClienteAPI
	{
		RestClient restClient = new RestClient("https://viacep.com.br/ws/");

		public Endereco GetEndereco(string cep)
		{
			// Exemplo de uso de interpolação de string no C#
			Endereco resposta = restClient.Get<Endereco>(resource: $"{cep}/json");

			return resposta;
		}
	}
}