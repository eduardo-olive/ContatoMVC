using ContatoMVC.Data;
using ContatoMVC.Models;

namespace ContatoMVC.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public ContatoModel BuscarPorId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.Id == id);
        }

        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDB = BuscarPorId(contato.Id);
            if (contatoDB  == null)
            {
                throw new Exception("Houve um erro na atualização do contato.");
            }

            contatoDB.Nome = contato.Nome;
            contatoDB.SobreNome = contato.SobreNome;
            contatoDB.Email = contato.Email;
            contatoDB.Telefone = contato.Telefone;

            _bancoContext.Update(contatoDB);
            _bancoContext.SaveChanges();
            return contatoDB;
        }

        public ContatoModel Apagar(int id)
        {
            ContatoModel contatoDB = BuscarPorId(id);
            if (contatoDB == null) throw new Exception("Contato não encontrado.");

            _bancoContext.Remove(contatoDB);
            _bancoContext.SaveChanges();
            return contatoDB;
        }
    }
}
