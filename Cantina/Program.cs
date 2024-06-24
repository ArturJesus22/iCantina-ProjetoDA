using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using iCantina.Models;
using iCantina.Views;

namespace iCantina
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var db = new CantinaContext())
            {
                db.QuantidadePratos.Load();
                db.QuantidadeExtras.Load();
                db.Utilizadores.Load();
                db.Extras.Load();
                db.Menus.Load();
                db.Multas.Load();
                db.Faturas.Load();
                db.ItemFaturas.Load();
                db.Pratos.Load();
                db.Reservas.Load();
                Application.Run(new FormLogin(db));
            }
        }

        public static CantinaContext DbContext { get; private set; }

        private static void InitializeDbContext()
        {
            DbContext = new CantinaContext();
            bool isCreated = DbContext.Database.Exists();

            if (!isCreated)
            {
                Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CantinaContext>());
                DbContext.Database.Create();
            }
        }
    }
}
