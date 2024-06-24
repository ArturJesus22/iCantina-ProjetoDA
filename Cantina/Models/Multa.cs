using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Models
{
    public class Multa
    {
        public int ID { get; set; }
        public decimal Valor { get; set; }
        public int NumHoras { get; set; }

        public override string ToString()
        {
            return $"Valor: {Valor:C2}, Número de Horas: {NumHoras}";
        }
    }
}
