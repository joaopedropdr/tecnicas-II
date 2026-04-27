using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    public class CentralDeMultas
    {
        private List<Multa> multas = new List<Multa>();
        public void registrarMulta(Multa multa) 
        { 
            multas.Add(multa);
            Console.WriteLine("Multa registrada");
        }
    }
}
