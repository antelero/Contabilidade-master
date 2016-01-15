using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class clsFornecedor
    {
        public int id { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public override string ToString()
        {
            return NomeFantasia;
        }
    }
}