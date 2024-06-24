using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iCantina.Models;

namespace iCantina.Controllers
{
    public class UtilizadorController
    {
        public static bool VerificarNIF(int nif, CantinaContext db)
        {
            return db.Utilizadores.Any(u => u.NIF == nif);
        }
    }
}
