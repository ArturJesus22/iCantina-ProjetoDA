using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Controllers
{
    internal class AuthController
    {
        public void loginUser(string username)
        {
            using (var db = new CantinaContext())
            {
                var user = db.Funcionarios.FirstOrDefault(u => u.Username == username);
                if (user == null)
                {
                    throw new Exception("Nome de utilizador incorreto.");
                }
            }
        }

        public bool IsUsernameValid(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException("Tem de preencher o campo username", nameof(username));
            }

            using (var db = new CantinaContext())
            {
                bool exists = db.Funcionarios.Any(f => f.Username == username);
                return !exists; // Retorna true se o username estiver disponível
            }
        }

        public bool IsNifValid(int nif)
        {
            if (nif <= 0)
            {
                throw new ArgumentException("Tem de preencher o campo NIF com um valor válido", nameof(nif));
            }

            using (var db = new CantinaContext())
            {
                bool exists = db.Funcionarios.Any(f => f.NIF == nif);
                return !exists; // Retorna true se o NIF estiver disponível
            }
        }
    }
}
