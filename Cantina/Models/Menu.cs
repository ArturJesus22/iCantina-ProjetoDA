using System;
using System.ComponentModel;
using System.Linq;

namespace iCantina.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public decimal PrecoEstudante { get; set; }
        public decimal PrecoProfessor { get; set; }
        public BindingList<Prato> Pratos { get; set; }
        public BindingList<Extra> Extras { get; set; }

        public Menu()
        {
            Pratos = new BindingList<Prato>();
            Extras = new BindingList<Extra>();
        }



        public override string ToString()
        {
            string pratos = string.Join(", ", Pratos.Select(p => p.Descricao));
            string extras = string.Join(", ", Extras.Select(e => e.Descricao));

            return $"Data e Hora: {DataHora:dd/MM/yyyy HH:mm:ss}, " +
                   $"Preço Estudante: {PrecoEstudante:C2}, " +
                   $"Preço Professor: {PrecoProfessor:C2}, " +
                   $"Pratos: {pratos}, " +
                   $"Extras: {extras}";
        }

    }
}
