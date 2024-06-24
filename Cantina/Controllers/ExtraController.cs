using iCantina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.Controllers
{
    public class ExtraController
    {
        public CantinaContext db;

        public ExtraController(CantinaContext db)
        {
            this.db = db;
        }


        public void Validacoes(string descricao, decimal preco)
        {
            if (string.IsNullOrWhiteSpace(descricao))
            {
                throw new ArgumentException("A descrição não pode estar vazia ou ser nula.");
            }

            if (preco <= 0)
            {
                throw new ArgumentException("O preço deve ser maior que zero.");
            }
        }

        public BindingList<Extra> GetExtras()
        {
            var listaExtra = db.Extras.ToList();
            return new BindingList<Extra>(listaExtra);
        }

        public BindingList<Extra> GetExtrasAtivos()
        {
            var listaExtraAtivo = db.Extras.Where(p => p.Ativo).ToList();
            return new BindingList<Extra>(listaExtraAtivo);
        }

        public Extra adicionarExtra(string descricao, decimal preco, bool ativo)
        {
            Validacoes(descricao, preco);

            var extra = new Extra { Descricao = descricao, Preco = preco, Ativo = ativo };
            db.Extras.Add(extra);
            db.SaveChanges();

            return extra;

        }

        public void atualizarExtra(int id, string descricao, decimal preco, bool ativo)
        {
            Validacoes(descricao, preco);

            var extra = db.Extras.Where(ex => ex.ID == id).FirstOrDefault();
            extra.Descricao = descricao;
            extra.Preco = preco;
            extra.Ativo = ativo;
            db.SaveChanges();

        }

        public void apagarExtra(int id)
        {
            var extra = db.Extras.Where(p => p.ID == id).FirstOrDefault();
            db.Extras.Remove(extra);
            db.SaveChanges();
        }
    }
}

