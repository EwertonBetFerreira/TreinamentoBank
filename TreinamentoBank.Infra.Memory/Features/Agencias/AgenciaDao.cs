using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoBank.Dominio.Features.Agencias;
using TreinamentoBank.Dominio.Interfaces;

namespace TreinamentoBank.Infra.Memory.Features.Agencias
{
    public class AgenciaDao : IAgenciaRepository

    {
        private List<Agencia> agencias = new List<Agencia>();

        public int RetornaUltimoId()
        {
            Agencia ultimoid = agencias.LastOrDefault();
            return ultimoid.Id;
        }

        public void CadastraDados(Agencia obj)
        {
            obj.Id = RetornaUltimoId() + 1;
            agencias.Add(obj);
        }

        public Agencia ConsultaDados(int id)
        {
           return agencias.Find(x => x.Id == id);

        }
        public void EditarDados(Agencia obj)
        {
            Agencia oldAgencia = ConsultaDados(obj.Id);
            oldAgencia.Cidade = obj.Cidade;
            oldAgencia.Codigo = obj.Codigo;
            oldAgencia.Nome = obj.Nome;
            oldAgencia.UF = obj.UF;
        }

        public void ExcluirDados(int id)
        {
            Agencia oldAgencia = ConsultaDados(id);
            agencias.Remove(oldAgencia);
        }

    }
}
