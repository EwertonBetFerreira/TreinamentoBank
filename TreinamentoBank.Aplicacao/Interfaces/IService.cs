
namespace TreinamentoBank.Aplicacao.Interfaces
{
    public interface IService<T>
    {
        void CadastraDados(T obj);
        T ConsultaDados(int id);
        void EditaDados(T obj);
        void ExcluiDados(int id);
    }
}
