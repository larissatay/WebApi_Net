using System;
using Impacta.MOD;
using Impacta.Tarefas.DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Impacta.Tarefas.EF;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Data objData = new Data();

            TarefaMOD obj = new TarefaMOD();

            objData.CriarTarefa(obj);
        }

		[TestMethod]
		public void Test_ExclusaoById()
		{
			Data data = new Data();

			Assert.IsTrue(data.ExcluirTarefa(2));
		}

		[TestMethod]
		public void Test_ExclusaoById_2()
		{
			Data data = new Data();

			Assert.IsFalse(data.ExcluirTarefa(2));
		}

		[TestMethod]
		public void Test_EF()
		{
			//Contexto contexto = new Contexto();
			//Editora editora = new Editora();

			//contexto.Editoras = editora;


		}


	}
}
