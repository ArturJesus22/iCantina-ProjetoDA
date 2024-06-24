using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Models
{
    public class QuantidadeExtra
    {
        public int ID { get; set; }
        public Extra Extra { get; set; }
        public int Quantidade { get; set; }
    }
}
