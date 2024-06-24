using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Models
{
    public class Professor : Cliente
    {
        public string Email { get; set; }


        public override string ToString()
        {
            return $"{Name}, {NIF}, {Saldo}€,{Email}";
        }
    }

}
