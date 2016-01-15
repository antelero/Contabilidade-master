using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class clsMovimentacao
    {
        public int idMovimentacao { get; set; }
        public string Desc_Mov { get; set; }
        public override string ToString()
        {
            return Desc_Mov;
        }
    }
}
