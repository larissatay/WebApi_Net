using System;
using System.Web.Mvc;
using Impacta.MOD;
using Impacta.Tarefas.Business;


namespace Impacta.Tarefas.Controllers
{
	public class RealBooksController : Controller
	{
		// GET: RealBooks
		public ActionResult Index()
		{
			// criar um objeto do tipo bUSINESS

			EditoraBus editoraBus = new EditoraBus();

			var listaEditora = editoraBus.ListarEditoras();

			return View(listaEditora);
		}


		public ActionResult ListarNovasEditora()
		{
			try
			{
				EditoraBus obEditora = new EditoraBus();

				var list = obEditora.ListarEditoras();

				return View(list);
			}

			catch (Exception ex)
			{

				throw ex;
			}


		}

		// GET: RealBooks/Details/5
		public ActionResult Details(int id)
		{

			return View();
		}

		// GET: RealBooks/Create
		public ActionResult Create()
		{

			return View();
		}

		// POST: RealBooks/Create
		[HttpPost]
		public ActionResult Create(Editora collection)
		{
			try
			{
				// Invocando na camada de negocio
				// o metodo para salvar os dados da Editora
				EditoraBus editoraBus = new EditoraBus();

				// enviamos para a camada de negocio os dados 
				editoraBus.Salvar(collection);

				// TODO: Add insert logic here

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}

		// GET: RealBooks/Edit/5
		public ActionResult Edit(int id)
		{
			try
			{
				if (!ModelState.IsValid)
					ModelState.AddModelError("Editora", "Editora invalida");
				EditoraBus obEditora = new EditoraBus();

				var lst = obEditora.BuscarEditora(id);
				return View(lst);
			}
			catch
			{
				throw;
			}

		}



		// POST: RealBooks/Edit/5
		[HttpPost]
		public ActionResult Edit(int id, FormCollection collection)
		{
			try
			{
				// TODO: Add update logic here

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}

		// GET: RealBooks/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: RealBooks/Delete/5
		[HttpPost]
		public ActionResult Delete(int id, FormCollection collection)
		{
			try
			{
				// TODO: Add delete logic here

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}
	}


}


