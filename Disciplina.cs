using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edka.Sa05
{
    internal class Disciplina
    {
        public string Disciplinas { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }

        //Polimorfismo
        //Override
        public override string ToString() => $"{Disciplinas,-20}- - - - - {Inicio,9} -{Termino: dd/mm/yyyy}";
    }
}
