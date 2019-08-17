using Impacta.WebApi.Pessoas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Impacta.WebApi.Pessoas.Controllers
{
	public class CursosController : ApiController
	{
		static List<Cursos> ListaDeCursos = new List<Cursos>();

		public List<Cursos> GetCrusos()
		{
			return ListaDeCursos;
		}

		public Cursos GetCursos(int Id)
		{
			var consultaCurso = from c in ListaDeCursos
								where c.Id.Equals(Id)
								select c;

			var res = ListaDeCursos.Where(x => x.Id.Equals(Id)).FirstOrDefault();

			if (consultaCurso.Count() <= 0)
			{
				return null;
			}
			else
			{
				return consultaCurso.FirstOrDefault();
			}

		}

		public void PostCursos(Cursos curso)
		{
			if (curso != null)
			{
				ListaDeCursos.Add(curso);
			}
		}

		public void PutCursos(Cursos curso)
		{
			if (curso != null)
			{
				ListaDeCursos.Add(curso);
			}
		}

		public void PutCursos(int id, Cursos curso)
		{
			if (curso != null && id > 0)
			{
				var result = ListaDeCursos.Where(x => x.Id.Equals(id)).FirstOrDefault();

				result.Nome = curso.Nome;
				result.CargaHoraria = curso.CargaHoraria;

				int posicao = ListaDeCursos.IndexOf(curso);
				ListaDeCursos.RemoveAt(posicao);
				ListaDeCursos.Insert(posicao, curso);

			}
		}

		public List<Cursos> DeleteCursos(int id)
		{
			if (id > 0)
			{
				ListaDeCursos.RemoveAt(
					ListaDeCursos.IndexOf(
						ListaDeCursos.Where(x => x.Id.Equals(id)).FirstOrDefault()
						));
			}

			return ListaDeCursos;
		}

	}
}