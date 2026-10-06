using Meu_primeiro_projeto_com_API.Models;
using Meu_primeiro_projeto_com_API.Services;
using Meu_primeiro_projeto_com_API.Repositories;
using Meu_primeiro_projeto_com_API.Entities;
using Meu_primeiro_projeto_com_API.Commom;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Meu_primeiro_projeto_com_API.Controllers
{
    [Route("api/usuario")]
    [ApiController]
    public class usuarioControllers : ControllerBase
    {
        [Route("cadastro")]
        [HttpPost]

        public cadastroResult Cadastro(cadastroRequest request)
        {
            var result = new cadastroResult();

            if (request == null ||
                string.IsNullOrWhiteSpace(request.Nome) ||
                string.IsNullOrWhiteSpace(request.Sobrenome) ||
                string.IsNullOrWhiteSpace(request.Email) ||
                string.IsNullOrWhiteSpace(request.Telefone) ||
                string.IsNullOrWhiteSpace(request.Senha) ||
                string.IsNullOrWhiteSpace(request.Genero))
            {
                result.sucesso = false;
                result.mensagem = "Todos os campos são obrigatórios";
            }
            else
            {
                var usuarioService = new UsuarioServices();
                result = usuarioService.Cadastro(request.Nome,
                   request.Sobrenome,
                   request.Email,
                   request.Telefone,
                   request.Senha,
                   request.Genero
                   );


            }
            return result;
        }


        [Route("login")]
        [HttpPost]

        public loginResult Login(loginRequest request)
        {
            var result = new loginResult();

            if (request == null)
            {
                result.sucesso = false;
                result.mensagem = "Parâmetro request veio nulo";
            }

            else if (request.Email == "")
            {
                result.sucesso = false;
                result.mensagem = "E-mail é obrigatório";
            }

            else if (request.Senha == "")
            {
                result.sucesso = false;
                result.mensagem = "Senha é obrigatória";
            }

            else
            {
                var usuarioService = new UsuarioServices();

                result = usuarioService.Login(request.Email, request.Senha);
            }

            return result;

        }

        [Route("esqueceuSenha")]
        [HttpPost]

        public esqueceuSenhaResult EsqueceuSenha(esqueceuSenhaRequest request)
        {
            var result = new esqueceuSenhaResult();

            if (request == null || string.IsNullOrEmpty(request.email))
            {
                result.sucesso = false;
                result.mensagem = "Email obrigatório.";
            }

            else
            {
                var usuarioServices = new UsuarioServices();
                result = usuarioServices.EsqueceuSenha(request.email);
            }

            return result;

        }

    }
}




