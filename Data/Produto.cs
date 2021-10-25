using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITeste.Data
{
    public class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string modelo { get; set; }
        public string descricao { get; set; }
        public char tamanho { get; set; }
        public int quantidade { get; set; }

    }
}
