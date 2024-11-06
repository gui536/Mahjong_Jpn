using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahjongFingertips.Models
{
    //Classe para representar uma peça.
    public class Peca
    {
        public int Id { get; set; }
        //Se ela é do jogador 1 ou do 2
        public int Type { get; set; }
        //Qual o tipo de imagem dela (A qual coluna ela pertence)
        public int Column { get; set; }
        public string Image { get; set; }
        public bool IsFlipped { get; set; }
    }
}
