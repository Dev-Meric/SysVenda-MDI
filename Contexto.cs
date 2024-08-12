using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysVenda_MDI.Entidades;


namespace SysVenda_MDI
{
	internal class Contexto : DbContext
	{
		public DbSet<Cliente> Clientes { get; set; }
		public DbSet<Produto> Produtos { get; set; }
		public DbSet<Venda> Vendas { get; set; }
		public DbSet<ItemVenda> ItensVendas { get; set; }
		public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseMySql("server=192.168.30.169;database=sysvendas_mdi;user=admin;password=senac123#", new MySqlServerVersion(new Version(8, 0, 37)));
		}
	}
}