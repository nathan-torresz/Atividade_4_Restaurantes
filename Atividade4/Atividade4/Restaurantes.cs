using System;
using System.Collections.Generic;
using System.Text;

namespace Atv_4_Restaurantes
{
    class Restaurantes
    {

        private string _nome;
        private List<Lanches> _lanches;
        public string Nome { get => _nome; private set => _nome = value; }
        public List<Lanches> Lanches { get => _lanches; set => _lanches = value; }

        public Restaurantes(string nome)
        {
            Nome = nome;
        }

        public void addLanche(Lanches lanche)
        {
            this.Lanches.Add(lanche);
        }
        public void removeLan(Lanches lanche)
        {
            this.Lanches.Remove(lanche);
        }

    }
}
