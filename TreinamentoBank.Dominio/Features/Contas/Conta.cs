using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoBank.Dominio.Features.Agencias;

namespace TreinamentoBank.Dominio.Features.Contas
{
    public class Conta
    {
        public int Id { get; set; }

        public Agencia Agencia { get; set; }

        public string Cliente { get; set; }

        public float Saldo { get; set; }

        public DateTime Data { get; set; }
    }
}
