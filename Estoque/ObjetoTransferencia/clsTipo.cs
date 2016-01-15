using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class clsTipo
    {
        public int id { get; set; }
        public string Descricao { get; set; }

        public override string ToString()
        {
            return this.Descricao;
        }
    }
}
