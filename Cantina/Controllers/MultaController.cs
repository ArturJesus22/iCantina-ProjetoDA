using iCantina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Controllers
{
    public class MultaController
    {

        public CantinaContext db;

        public MultaController(CantinaContext db)
        {
            this.db = db;
        }
        public BindingList<Multa> GetMultas()
        {
            var listaMulta = db.Multas.ToList();
            return new BindingList<Multa>(listaMulta);
        }

        public bool verificarMulta(int numHoras)
        {
            return db.Multas.Any(m => m.NumHoras == numHoras);
        }

        public Multa adicionarMulta(decimal valor, int numHoras)
        {
            if (verificarMulta(numHoras))
            {
                throw new Exception("Essa multa já foi criada com esse número de horas!");
            }

            var multa = new Multa { Valor = valor, NumHoras = numHoras };
            db.Multas.Add(multa);
            db.SaveChanges();

            return multa;

        }

        public void atualizarMulta(int id, decimal valor, int numHoras)
        {
            if (verificarMulta(numHoras))
            {
                throw new Exception("Essa multa já foi criada com esse número de horas!");
            }

            var multa = db.Multas.Where(m => m.ID == id).FirstOrDefault();
            multa.Valor = valor;
            multa.NumHoras = numHoras;
            db.SaveChanges();

        }

        public void apagarMulta(int id)
        {
            var multa = db.Multas.Where(m => m.ID == id).FirstOrDefault();
            db.Multas.Remove(multa);
            db.SaveChanges();
        }
    }
}
