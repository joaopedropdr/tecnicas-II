using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    public class Multa
    {
        public Multa() { }
        public string? Placa { get; set; }
        public string? TipoInfracao { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
    }
}
