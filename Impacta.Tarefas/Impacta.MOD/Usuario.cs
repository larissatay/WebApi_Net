using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impacta.MOD
{
	public class Usuario
	{

		[Required(ErrorMessage = "Nome do usuario é obrigatorio")]
		[Display(Name ="USUÁRIO")]
		[StringLength(10, MinimumLength =5, ErrorMessage =("Usuario deve conter entre 5 e 8 caracters"))]
		public string Username { get; set; }

		[Display(Name = "SENHA")]
		[Required(ErrorMessage = "Senha é obrigatória")]
		public string Password { get; set; }
	}
}
