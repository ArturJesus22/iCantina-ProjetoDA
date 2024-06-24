using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Models
{
    public class ItemFatura
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public decimal Preco {  get; set; }

        public ItemFatura()
        {
        }

        public ItemFatura(string descricao, decimal preco)
        {
            Descricao = descricao;
            Preco = preco;
        }
    }
}
