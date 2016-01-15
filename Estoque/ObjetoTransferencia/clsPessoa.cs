using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class clsPessoa
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime  DataNascimento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int idNivel { get; set; }
    }
}
