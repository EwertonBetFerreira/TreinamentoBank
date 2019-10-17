using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoBank.Dominio.Features.Agencias
{
    public class Agencia
    {
        public int Id { get; set; }
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string Cidade { get; set; }

        public string UF { get; set; }
    }
}
