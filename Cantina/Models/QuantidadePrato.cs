using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Models
{
    public class QuantidadePrato
    {
        public int ID { get; set; }
        public Prato Prato { get; set; }
        public int Quantidade { get; set; }
    }
}
