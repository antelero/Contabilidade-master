using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class clsItem
    {
        public int id { get; set; }
        public int idMovimentacao { get; set; }
        public int NumLote { get; set; }
        public string Descricao { get; set; }
        public int idTipo { get; set; }
        public int Qtde { get; set; }
        public double PrecoUnit { get; set; }
        public DateTime DataEntrada { get; set; }
        public int idFornecedor { get; set; }
        public override string ToString()
        {
            return Descricao;
        }

    }
}
