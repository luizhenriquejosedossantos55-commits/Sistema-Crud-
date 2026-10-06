using Microsoft.AspNetCore.SignalR.Protocol;
using Meu_primeiro_projeto_com_API.Models;
using Meu_primeiro_projeto_com_API.Controllers;
using Meu_primeiro_projeto_com_API.Services;
using Meu_primeiro_projeto_com_API.Repositories;


namespace Meu_primeiro_projeto_com_API.Entities
{
    public class Usuario
    {

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Genero { get; set; }

        public string Senha { get; set;  }


    }
}
