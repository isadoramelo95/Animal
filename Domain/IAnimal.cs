namespace Domain
{
    public interface IAnimal
    {
        public string Especie { get; set; }
        public int QuantidadeDePatas { get; set; }
        public int Idade { get; set; }
        public string SomEmite { get; set; }
        public string PeriodoDoDia { get; set; }

        string Mover(string especie);
        string FazerSom(string somEmite);
        string Dormir(string dormir, string nome);
        string AlimentarAnimal(string alimentacao, string nome);

    }
}