// vamos adicionar o Entity Framework
using Impacta.MOD;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Impacta.Tarefas.EF
{
	public class RealBooksContexto : DbContext
	{
		public RealBooksContexto() :base("RealBooksContext")
		{

		}

		// Para trabalhar EF, você precisa de uma classe
		// para representar o seu BD que é nossa classe CONTEXTO
		// que deve Herdar de DbContext
		// Todas as tabelas que você desejar trabalhar no Banco de dados
		// devem ser mapeadas aqui com os DBSet<>
		public DbSet<Editora> Editoras { get; set; }
		public DbSet<Livro> Livros { get; set; }
		// Por padrão do EF as entidades geradas no banco dados
		// utilizam o plural do ingles: Ex: Livros -> Livroes

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			//base.OnModelCreating(modelBuilder);
		}


	}
}
