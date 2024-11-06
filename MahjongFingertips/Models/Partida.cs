namespace MahjongFingertips.Models
{
    public class Partida
    {
        public int Id { get; set; }
        public Jogador? Jogador1 { get; set; }  // Declarado como nullable
        public Jogador? Jogador2 { get; set; }
        public Jogador? Vencedor { get; set; }
    }
}
