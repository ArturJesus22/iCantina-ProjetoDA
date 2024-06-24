using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Models
{
    public class Fatura
    {
        public int ID { get; set; }
        public decimal Total { get; set; }
        public DateTime DataHora { get; set; }
        public Reserva Reserva { get; set; }
        public BindingList<ItemFatura> ItemFatura { get; set; }

        public Fatura()
        {
            ItemFatura = new BindingList<ItemFatura>();
        }
    }
}
