using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoBank.Dominio.Features.Contas;
using TreinamentoBank.Dominio.Interfaces;

namespace TreinamentoBank.Infra.Memory.Features.Contas
{
    public class ContaDao : IContaRepository
    {

        private List<Conta> contas = new List<Conta>();
        public int RetornaUltimoId()
        {
            Conta ultimoid = contas.LastOrDefault();
            return ultimoid.Id;
        }
        public void CadastraDados(Conta obj)
        {
            obj.Id = RetornaUltimoId() + 1;
            contas.Add(obj);
        }

        public Conta ConsultaDados(int id)
        {
            return contas.Find(x => x.Id == id);
        }

        public void EditarDados(Conta obj)
        {
            Conta oldConta = ConsultaDados(obj.Id);
            oldConta.Agencia = obj.Agencia;
            oldConta.Cliente = obj.Cliente;
            oldConta.Data = DateTime.Now;
            oldConta.Saldo = obj.Saldo;
        }

        public void ExcluirDados(int id)
        {
            Conta oldConta = ConsultaDados(id);
            contas.Remove(oldConta);
        }
    }
}
