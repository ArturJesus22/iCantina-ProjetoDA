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
    public class FuncionarioController
    {
        public CantinaContext db;

        public FuncionarioController(CantinaContext db)
        {
            this.db = db;
        }


        public Funcionario adicionarFuncionario(string nome, int nif, string username)
        {

            validacoes(nome, nif, username);
            UtilizadorController.VerificarNIF(nif, this.db);
            var funcionario = new Funcionario { Name = nome, NIF = nif, Username = username };
            db.Funcionarios.Add(funcionario);
            db.SaveChanges();

            return funcionario;

        }

        public void atualizarFuncionario(int id, string nome, int nif, string username)
        {
            validacoes(nome, nif, username);
            UtilizadorController.VerificarNIF(nif, db);

            var funcionario = db.Funcionarios.Where(p => p.Id == id).FirstOrDefault();
            funcionario.Name = nome;
            funcionario.NIF = nif;
            funcionario.Username = username;
            db.SaveChanges();
        }

        public BindingList<Funcionario> GetFuncionarios()
        {
            //return db.Funcionarios.ToList();
            var listaFuncionario = db.Funcionarios.ToList();
            return new BindingList<Funcionario>(listaFuncionario);
        }
        public void apagarFuncionario(int id)
        {
            var funcionario = db.Funcionarios.Where(p => p.Id == id).FirstOrDefault();
            db.Funcionarios.Remove(funcionario);
            db.SaveChanges();
        }

        private bool validacoes(string nome, int nif, string username)
        {
            if (nome == "")
            {
                throw new Exception("Nome inválido");
            }

            if (nif.ToString().Length != 9)
            {
                throw new Exception("NIF inválido. Deve conter exatamente 9 dígitos.");
            }

            if (username == "")
            {
                throw new Exception("Username inválido");
            }

            return true;

        }
    }
}
