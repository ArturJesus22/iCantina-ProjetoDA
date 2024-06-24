using iCantina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace iCantina.Controllers
{
    public class ReservaController
    {
        public CantinaContext db;

        public ReservaController(CantinaContext db)
        {
            this.db = db;
        }

        public BindingList<Reserva> GetReservas()
        {
            var listaReservas = db.Reservas.ToList();
            return new BindingList<Reserva>(listaReservas);
        }

        public Reserva adicionarReserva(Cliente cliente, Prato prato, BindingList<Extra> extras, decimal TotalGasto, Multa multa)
        {
            var reserva = new Reserva { Cliente = cliente, Prato = prato, Extras = extras, TotalGasto = TotalGasto, Multa = multa };
            db.Reservas.Add(reserva);
            db.SaveChanges();

            return reserva;
        }

        public void AtualizarReserva(Reserva reserva)
        {
            db.Entry(reserva).State = EntityState.Modified;
            db.SaveChanges();
        }


        public void removerReserva(int id)
        {
            var reserva = db.Reservas.Where(r => r.Id == id).FirstOrDefault();
            db.Reservas.Remove(reserva);
            db.SaveChanges();
        }
    }
}
