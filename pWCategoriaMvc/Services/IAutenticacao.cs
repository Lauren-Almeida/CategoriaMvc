using CategoriaMvc.Models;

namespace CategoriaMvc.Services;

public interface IAutenticacao
{
    Task<TokenViewModel> AutenticaUsuario(UsuarioViewModel usuarioVM);
}
