using Meu_primeiro_projeto_com_API.Models;
using Meu_primeiro_projeto_com_API.Repositories;
using Meu_primeiro_projeto_com_API.Entities;
using Meu_primeiro_projeto_com_API.Commom;




namespace Meu_primeiro_projeto_com_API.Services
{
    public class UsuarioServices
    {

        public loginResult Login(string email, string senha)
        {
            var result = new loginResult();

            var usuarioRepository = new UsuarioRepository();

            var usuario = usuarioRepository.ObterUsuarioPorEmail(email);

            if (usuario != null)
            {
                //usuario existe
                if (usuario.Senha == senha)
                {
                    result.sucesso = true;
                }
                result.sucesso = false;
                result.mensagem = "Usuário ou senha inválidos";

                return result;
            }

            else
            {
                result.sucesso = false;
                result.mensagem = "Usuário ou senha inválidos";
            }

            return result;
        }

        public cadastroResult Cadastro(string nome,
            string sobrenome,
            string telefone,
            string email,
            string genero,
            string senha)
        {
            var result = new cadastroResult();

            var usuarioRepository = new UsuarioRepository();

            var usuario = usuarioRepository.ObterUsuarioPorEmail(email);

            if(usuario != null)
            {
                result.sucesso = false;
                result.mensagem = "Usuário já existe";
            }

            else
            {
                usuario = new Usuario();

                usuario.Nome = nome;
                usuario.Sobrenome = sobrenome;
                usuario.Email = email;
                usuario.Telefone = telefone;
                usuario.Genero = genero;
                usuario.Senha = senha;

                var insertResult = usuarioRepository.Inserir(usuario);

                if(insertResult > 0)
                {
                    result.sucesso = true;
                }

                else
                {
                    result.sucesso = false;
                    result.mensagem = "Erro ao tentar inserir usuário, tente novamente.";
                }

                
            }

            return result;
        }

        public esqueceuSenhaResult EsqueceuSenha(string email)
        {
            var result = new esqueceuSenhaResult();

            var usuarioRepository = new UsuarioRepository();

            var usuario = usuarioRepository.ObterUsuarioPorEmail(email);

            if(usuario == null)
            {
                result.sucesso = false;
                result.mensagem = "Usuário não existe.";
            }

            else
            {
                var emailSender = new EmailSender();

                var assunto = "Recuperação de senha.";
                var corpo = "Sua senha é," + usuario.Senha;

                emailSender.Enviar(assunto, corpo, usuario.Email);

            }

            return result;

        }
    }

}
