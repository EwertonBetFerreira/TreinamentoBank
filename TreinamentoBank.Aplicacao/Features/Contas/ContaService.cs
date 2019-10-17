using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoBank.Aplicacao.Interfaces;
using TreinamentoBank.Dominio.Features.Contas;
using TreinamentoBank.Dominio.Interfaces;

namespace TreinamentoBank.Aplicacao.Features.Contas
{
    public class ContaService : IContaService
    {
        private IContaRepository _Contas;
        public ContaService(IContaRepository contas)
        {
            _Contas = contas;
        }
        public void CadastraDados(Conta obj)
        {
            _Contas.CadastraDados(obj);
        }

        public Conta ConsultaDados(int id)
        {
            return _Contas.ConsultaDados(id);
        }

        public void EditaDados(Conta obj)
        {
            _Contas.EditarDados(obj);
        }

        public void ExcluiDados(int id)
        {
            _Contas.ExcluirDados(id);
        }
    }
}
