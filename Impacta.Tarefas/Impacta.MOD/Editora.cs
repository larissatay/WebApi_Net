using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impacta.MOD
{
	public class Editora
	{
		[Display (Name ="Codigo da Editora")]
		public int EditoraId { get; set; }

		[Display (Name ="Razao Social")]
		[Required(ErrorMessage ="Razao Social deve ser informada")]
		public string Nome { get; set; }

		[EmailAddress] // Se formato nao for de email emitira uma mensagem
		[Required(ErrorMessage = "E-mail de contato nao esta sendo informado")]
		public string Email { get; set; }

		[Required]
		public string Cnpj { get; set; }

		[Phone]
		public string Telefone { get; set; }

		public string Url { get; set; }

		public Endereco Endereco  { get; set; }
		



	}
}
