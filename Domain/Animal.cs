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
        public string PeriodoDoDia { get; set; }

        public string Alimentacao { get; set; }

        public Animal( string especie, string somEmite, string horaDeDormir, string alimentacao)
        {
            Especie = especie;
            SomEmite = somEmite;
            PeriodoDoDia = horaDeDormir;
            Alimentacao = alimentacao;
        }

        public virtual string Mover(string especie)
        {
            if (especie == "cachorro")
            {
                return $"O {especie} está correndo.";
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

        public virtual string Dormir(string horaDeDormir, string nome)
        {
            if (horaDeDormir == "noite")
            {
                return $"Está de {horaDeDormir}, o {nome} está dormindo.";
            }
            else
                return "Acordado";
        }

        public virtual string AlimentarAnimal(string alimentacao, string nome)
        {
            if (!string.IsNullOrEmpty(alimentacao))
            {
                return $"O {nome} está sendo alimentado com {alimentacao} neste momento.";
            }
            else
                return "Não tem nenhum animal sendo alimentado.";
        }
    }
}
