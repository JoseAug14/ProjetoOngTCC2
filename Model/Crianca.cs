using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTcc2.Model
{
    public class Crianca
    {
        public string nomecrianca { get; set; }
        public DateTime datanasccrianca { get; set; }
        public string tamanho { get; set; }
        public string serie { get; set; }
        public int frequencia { get; set; }
        public int media { get; set; }
        public string nomeescola { get; set; }
        public string telefoneescola { get; set; }
        public int idResponsavel { get; set; }
        public int idEscola { get; set; }

    }
}
