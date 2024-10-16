using ContatoMVC.Models;

namespace ContatoMVC.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel Adicionar(ContatoModel contato);
    }
}
