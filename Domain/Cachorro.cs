using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Cachorro : Animal
    {
        public string Nome { get; set; }
        //public string Especie { get; set; }

        public Cachorro(string nome, string especie, string somEmite) : base(especie, somEmite)
        {
            Nome = nome;
        }
        public override string Mover(string especie)
        {
            return base.Mover(especie);
        }

        public override string FazerSom(string somEmite)
        {
            return base.FazerSom(somEmite);
        }
    }
}
