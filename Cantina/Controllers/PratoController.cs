using iCantina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace iCantina.Controllers
{
    public class PratoController
    {
        public CantinaContext db;

        public PratoController(CantinaContext db)
        {
            this.db = db;
        }
        public BindingList<Prato> GetPratos()
        {
            var listaPrato = db.Pratos.ToList();
            return new BindingList<Prato>(listaPrato);
        }

        public BindingList<Prato> GetPratosAtivos()
        {
            var listaPratoAtivo = db.Pratos.Where(p => p.Ativo).ToList();
            return new BindingList<Prato>(listaPratoAtivo);
        }

        public bool validarPrato(string tipo)
        {
            tipo = tipo.ToLower();
            var tiposValidos = new List<string> { "carne", "peixe", "vegetariano" };

            if (!tiposValidos.Contains(tipo))
            {
                throw new Exception("Tipo indisponível (Carne, Peixe, Vegetariano)!");
            }

            return db.Pratos.Any(p => p.Tipo.ToLower() == tipo);
        }

        public Prato adicionarPrato(string descricao, string tipo, bool ativo)
        {
            validarPrato(tipo);

            var prato = new Prato { Descricao = descricao, Tipo = tipo, Ativo = ativo };
            db.Pratos.Add(prato);
            db.SaveChanges();

            return prato;
        }

        public void atualizarPrato(int id, string descricao, string tipo, bool ativo)
        {
            validarPrato(tipo);
            var prato = db.Pratos.Where(p => p.ID == id).FirstOrDefault();
            prato.Descricao = descricao;
            prato.Tipo = tipo;
            prato.Ativo = ativo;
            db.SaveChanges();

        }

        public void apagarPrato(int id)
        {
            var prato = db.Pratos.Where(p => p.ID == id).FirstOrDefault();
            db.Pratos.Remove(prato);
            db.SaveChanges();
        }
    }
}
