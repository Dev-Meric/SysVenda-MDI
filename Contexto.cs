using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysVendas2.Entidades;

namespace SysVendas2
{
	internal class Contexto : DbContext
	{
		public DbSet<Cliente> Clientes { get; set; }
		public DbSet<Produto> Produtos { get; set; }
		public DbSet<Venda> Vendas { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseMySql("server=localhost;database=bdvendas;user=senac;password=senac123#");
		}
	}
}
