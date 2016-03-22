using System;

namespace Sistema_de_Vendas.MODEL
{
    class Produto
    {
        private int produtoID = 0;
        private int codigo = 0;
        private DateTime validade;
        private Double preco = 0;

        public Produto(int codigo , DateTime validade , Double preco)
        {
            this.codigo = codigo;
            this.validade = validade;
            this.preco = preco;
        }

        public int Codigo { get; set; }
        public DateTime Validade { get; set; }
        public Double Preco { get; set; }

    }
}
