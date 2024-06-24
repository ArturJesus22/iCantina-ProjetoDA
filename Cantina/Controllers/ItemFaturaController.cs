using iCantina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Controllers
{
    public class ItemFaturaController
    {
        private CantinaContext db;
        public ItemFaturaController(CantinaContext db)
        {
            this.db = db;
        }

        public BindingList<ItemFatura> GetItemFaturas()
        {
            var itemFatura = db.ItemFaturas.ToList();
            return new BindingList<ItemFatura>(itemFatura);
        }

        public ItemFatura AdicionarItemFatura(string descricao, decimal preco)
        {
            var itemFatura = new ItemFatura(descricao, preco);
            db.ItemFaturas.Add(itemFatura);
            db.SaveChanges();

            return itemFatura;
        }
    }
}