using iCantina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Controllers
{
    public class EstudanteController
    {
        public CantinaContext db;

        public EstudanteController(CantinaContext db)
        {
            this.db = db;
        }

        public BindingList<Estudante> GetEstudantes()
        {
            var listaEstudante = db.Estudantes.ToList();
            return new BindingList<Estudante>(listaEstudante);
        }

        public Estudante AdicionarEstudante(string nome, int nif, decimal saldo, int numEstudante)
        {
            validacoes(nome, nif, saldo, numEstudante);
            UtilizadorController.VerificarNIF(nif, db);
            var estudante = new Estudante { Name = nome, NIF = nif, Saldo = saldo, NumEstudante = numEstudante };
            db.Estudantes.Add(estudante);
            db.SaveChanges();

            return estudante;
        }

        public void atualizarEstudante(int id, string nome, int nif, decimal saldo, int numEstudante)
        {
            validacoes(nome, nif, saldo, numEstudante);
            UtilizadorController.VerificarNIF(nif, db);

            var estudante = db.Estudantes.Where(p => p.Id == id).FirstOrDefault();
            estudante.Name = nome;
            estudante.NIF = nif;
            estudante.Saldo = saldo;
            estudante.NumEstudante = numEstudante;
            db.SaveChanges();
        }

        public void apagarEstudante(int id)
        {
            var estudante = db.Estudantes.Where(p => p.Id == id).FirstOrDefault();
            db.Estudantes.Remove(estudante);
            db.SaveChanges();
        }


        private bool validacoes(string nome, int nif, decimal saldo, int numEstudante)
        {
            if (saldo < 0)
            {
                throw new Exception("Saldo incorreto");
            }

            if (numEstudante.ToString().Length != 7)
            {
                throw new Exception("Numero do estudante inválido");
            }

            if (nome == "")
            {
                throw new Exception("Nome inválido");
            }

            if (nif.ToString().Length != 9)
            {
                throw new Exception("NIF inválido.");
            }

            return true;

        }

        public void AtualizarSaldo(int estudanteId, decimal novoSaldo)
        {
            var estudante = db.Estudantes.Find(estudanteId);
            if (estudante != null)
            {
                estudante.Saldo = novoSaldo;
                db.SaveChanges(); // Salva as mudanças na base de dados
            }
            else
            {
                throw new ArgumentException("Estudante não encontrado.");
            }
        }
    }
}