using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Animal : IAnimal
    {
        public string Especie { get; set; }
        public int QuantidadeDePatas { get; set; }
        public int Idade { get; set; }
        public string SomEmite { get; set; }

        public Animal(string especie, string somEmite)
        {
            Especie = especie;
            SomEmite = somEmite;
        }

        public virtual string Mover(string especie)
        {
            if (especie == "cachorro")
            {
                return "O cachorro está correndo.";
            }
            else
             return "Outro animal que não tem permissão";
        }

        public virtual string FazerSom(string somEmite)
        {
            if (somEmite == "latido")
            {
                return "O cachorro latindo.";
            }
            else
                return "Esse animal que não tem permissão";
        }
    }
}
