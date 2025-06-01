namespace MauiAppHotel.Models
{
    public class Cliente
    {
        public string Nome { get; set; }

        private int _idade;
        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Idade não pode ser negativa.");
                _idade = value;
            }
        }

        public string Telefone { get; set; }
        public string Rg { get; set; }
    }
}
