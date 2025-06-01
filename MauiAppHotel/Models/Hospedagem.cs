namespace MauiAppHotel.Models
{
    public class Hospedagem
    {
        public Cliente Cliente { get; set; }
        public Quarto QuartoSelecionado { get; set; }
        public int QntAdultos { get; set; }
        public int QntCriancas { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }

        public int Estadia => (DataCheckOut - DataCheckIn).Days;

        public double ValorTotal
        {
            get
            {
                double valorAdulto = QuartoSelecionado?.ValorDiariaAdulto ?? 0;
                double valorCrianca = QuartoSelecionado?.ValorDiariaCrianca ?? 0;

                return ((valorAdulto * QntAdultos) + (valorCrianca * QntCriancas)) * Estadia;
            }
        }
    }
}
