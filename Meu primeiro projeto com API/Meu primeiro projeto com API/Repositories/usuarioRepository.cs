using Meu_primeiro_projeto_com_API.Models;
using Meu_primeiro_projeto_com_API.Entities;
using Meu_primeiro_projeto_com_API.Services;
using System.Reflection.Metadata;

namespace Meu_primeiro_projeto_com_API.Repositories
{
    public class UsuarioRepository
    {

        public int Inserir(Usuario usuario) 
        {
            var result = 1;

            return result;

        }

        public Usuario ObterUsuarioPorEmail(string email)
        {
            var result = new Usuario();

            return result;

        }
    }
}
