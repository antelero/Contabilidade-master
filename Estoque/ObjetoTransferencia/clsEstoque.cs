using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class clsEstoque
    {
        public string Desc_Mov { get; set; }
        public int NumLote { get; set; }
        public string DescricaoItem { get; set; }
        public string CategoriaItem { get; set; }
        public int Qtde { get; set; }
        public double PrecoUnit { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public string NomeFantasia { get; set; }
        public double SubTotal { get; set; }
        public double ICMS { get; set; }
        public double Total { get; set; }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
