using Impacta.MOD;
using Impacta.Tarefas.EF;
using System;
using System.Collections.Generic;



namespace Impacta.Tarefas.Business 
{
	public class EditoraBus
	{

		public List<Editora> ListarEditoras()
		{
			EditoraEF editoraEF = new EditoraEF();

			List<Editora> ed;
			try
			{

			  ed = editoraEF.ListarEditoras(); 

			}
			catch (Exception ex)
			{

				throw new Exception ("Falha ao tentar Validar a busca das Editoras. Erro: \n" + ex.Message);
			}

			return ed; 
		} 

		public void Salvar(Editora editora)
		{
			try
			{
				if (string.IsNullOrEmpty(editora.Nome))
				{
					throw new Exception("Nome invalido");
				}

				if (string.IsNullOrEmpty(editora.Email))
				{
					throw new Exception("E-mail invalido");
				}

				EditoraEF editoraEF = new EditoraEF();

				editoraEF.Salvar(editora);
			}

			catch (Exception ex)
			{
				throw ex; 
			}
		}

		public Editora BuscarEditora(int id)
		{
			EditoraEF editoraEF = new EditoraEF();

			return editoraEF.BuscarEditora(id); 
		}

		public void Excluir(int id)
		{
			EditoraEF editoraEF = new EditoraEF();

			editoraEF.Excluir(id);
		}

	}
}
