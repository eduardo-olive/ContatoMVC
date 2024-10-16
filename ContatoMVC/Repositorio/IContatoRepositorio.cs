using ContatoMVC.Models;

namespace ContatoMVC.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel BuscarPorId(int id);
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Atualizar(ContatoModel contato);
        ContatoModel Apagar(int id);
    }
}
