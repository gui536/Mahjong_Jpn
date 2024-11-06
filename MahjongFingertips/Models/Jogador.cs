namespace MahjongFingertips.Models
{
    public class Jogador
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;  // Inicializado com valor padrão
        public int Pontuacao { get; set; }
    }
}
