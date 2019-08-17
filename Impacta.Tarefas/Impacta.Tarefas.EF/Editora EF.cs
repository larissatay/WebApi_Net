using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Impacta.MOD;

namespace Impacta.Tarefas.EF
{
	public class EditoraEF
	{
		public List<Editora>  ListarEditoras()
		{
			List<Editora> listaDeEditora = null;

			using (RealBooksContexto realDB = new RealBooksContexto())
			{
				listaDeEditora = realDB.Editoras.ToList();

			}

			return listaDeEditora;
		}

		public Editora BuscarEditora(int id)
		{
			Editora editora = null;

			using (RealBooksContexto realDB = new RealBooksContexto())
			{
				using ( var db = new RealBooksContexto())
				{
					editora = db.Editoras.Where(p => p.EditoraId == id).FirstOrDefault();
				}
			}

			return editora;
		}

		public void Excluir(int id)
		{
			using (var realDB = new RealBooksContexto())
			{
				var editora = realDB.Editoras.Where(i => i.EditoraId == id).FirstOrDefault();
				realDB.Editoras.Remove(editora);
				realDB.SaveChanges();
			}
		}

		 
		public void Salvar(Editora editora)
		{
			using (RealBooksContexto db = new RealBooksContexto())
			{
				// verifica se o ID ja existe, se existe é pq não é
				// cadastro novo, então é uma alteração 
				if (editora.EditoraId > 0)
				{
					// busca no banco de dados o registro po ID
					var result = db.Editoras.Where(x => x.EditoraId == editora.EditoraId).FirstOrDefault();

					result.Nome = editora.Nome;
					result.Email = editora.Email;

					// faz update no banco no registro alterado 
					db.SaveChanges();

				}

				else
				{
					// adiciona o objeto
					db.Editoras.Add(editora);

					//faz um INSERT no banco de dados 
					db.SaveChanges();
				}
			}
		}

	}
}
