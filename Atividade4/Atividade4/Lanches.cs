using System;
using System.Collections.Generic;
using System.Text;

namespace Atv_4_Restaurantes
{
    class Lanches
    {
        private string _nome;
        private string _descricao;
        private float _preco;

        public string nome { get => _nome; set => _nome = value; }
        public string descricao { get => _descricao; set => _descricao = value; }
        public float preco { get => _preco; set => _preco = value; }
    }
}
