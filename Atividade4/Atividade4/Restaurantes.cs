using System;
using System.Collections.Generic;
using System.Text;

namespace Atv_4_Restaurantes
{
    class Restaurantes
    {

        public string Nome;
        public List<Lanches> lanches;

        public void addLanche(Lanches lanche)
        {
            this.lanches.Add(lanche);
        }
        public void removeLan(Lanches lanche)
        {
            this.lanches.Remove(lanche);
        }

    }
}
