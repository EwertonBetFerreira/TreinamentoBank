using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoBank.Aplicacao.Interfaces;
using TreinamentoBank.Dominio.Features.Agencias;
using TreinamentoBank.Dominio.Features.Contas;
using TreinamentoBank.Dominio.Interfaces;

namespace TreinamentoBank.Aplicacao.Features.Agencias
{
    public class AgenciaService : IAgenciaService
    {
        private IAgenciaRepository _Agencias;

        public AgenciaService(IAgenciaRepository agencias)
        {
            _Agencias = agencias;
        }
        public void CadastraDados(Agencia obj)
        {
            _Agencias.CadastraDados(obj);
        }

        public void EditaDados(Agencia obj)
        {
            _Agencias.EditarDados(obj);
        }

        public void ExcluiDados(Int32 id)
        {
            _Agencias.ExcluirDados(id);
        }

        public Agencia ConsultaDados(Int32 id)
        {
            return _Agencias.ConsultaDados(id);
            
        }
    }
}
