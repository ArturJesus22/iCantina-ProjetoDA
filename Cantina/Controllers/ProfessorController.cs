using iCantina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;

namespace iCantina.Controllers
{
    public class ProfessorController
    {
        public CantinaContext db;
        public ProfessorController(CantinaContext db)
        {
            this.db = db;
        }

        public BindingList<Professor> GetProfessores()
        {
            //return db.Professores.ToList();
            var listaProfessor = db.Professores.ToList();
            return new BindingList<Professor>(listaProfessor);
        }

        public Professor adicionarProfessor(string nome, int nif, decimal saldo, string email)
        {
            validacoes(nome, nif, saldo, email);
            UtilizadorController.VerificarNIF(nif, db);

            var professor = new Professor { Name = nome, NIF = nif, Saldo = saldo, Email = email };
            db.Professores.Add(professor);
            db.SaveChanges();

            return professor;
        }

        public void atualizarProfessor(int id, string nome, int nif, decimal saldo, string email)
        {
            validacoes(nome, nif, saldo, email);
            UtilizadorController.VerificarNIF(nif, db);
            var professor = db.Professores.Where(p => p.Id == id).FirstOrDefault();

            professor.Name = nome;
            professor.NIF = nif;
            professor.Saldo = saldo;
            professor.Email = email;
            db.SaveChanges();
        }

        public void apagarProfessor(int id)
        {
            var professor = db.Professores.Where(p => p.Id == id).FirstOrDefault();
            db.Professores.Remove(professor);
            db.SaveChanges();
        }

        private bool validacoes(string nome, int nif, decimal saldo, string email)
        {
            if (nome == "")
            {
                throw new Exception("Nome inválido");
            }

            if (nif.ToString().Length != 9)
            {
                throw new Exception("NIF inválido. Deve conter exatamente 9 dígitos.");
            }

            if (saldo < 0)
            {
                throw new Exception("Saldo inválido");
            }

            if (!IsValidEmail(email))
            {
                throw new Exception("Email inválido");
            }

            return true;
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public void AtualizarSaldo(int professorId, decimal novoSaldo)
        {
            var professor = db.Estudantes.Find(professorId);
            if (professor != null)
            {
                professor.Saldo = novoSaldo;
                db.SaveChanges(); // Salva as mudanças na base de dados
            }
            else
            {
                throw new ArgumentException("Professor não encontrado.");
            }
        }
    }
}