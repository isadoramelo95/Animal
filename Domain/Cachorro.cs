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

        public Cachorro(string nome, string especie, string somEmite, string horaDeDormir, string alimentacao) : base(especie, somEmite, horaDeDormir, alimentacao)
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

        public override string Dormir(string horaDeDormir, string nome)
        {
            return base.Dormir(horaDeDormir, nome);
        }

        public override string AlimentarAnimal(string alimentacao, string nome)
        {
            return base.AlimentarAnimal(alimentacao, nome);
        }
    }
}
