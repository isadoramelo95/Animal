namespace Domain
{
    public class Animal
    {
        public int Id { get; set; }
        public string Especie { get; set; }
        public int Idade { get; set; } 
        public string SomEmite { get; set; }
        public string PeriodoDoDia { get; set; } = string.Empty;
        public string Nome { get; set; }
        public string Raca { get; set; }
        public string Alimentacao { get; set; } = string.Empty;

        public virtual string EmitirSom() => "";

    }
}
