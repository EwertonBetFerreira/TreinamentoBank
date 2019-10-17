using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoBank.Dominio.Interfaces
{
    public interface IRepository<T>
    {
         void CadastraDados(T obj);

         void EditarDados(T obj);

         void ExcluirDados(int id);

         T ConsultaDados(int id);
    }
}
