using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Vendas.MODEL
{
    class itensPedido
    {
        int itensPedidoID = 0;
        int produtoID = 0;
        int codigoProduto = 0;
        int quantidadeItem = 0;
        Double precoProduto = 0;

        public itensPedido(int produtoID, int codigoProduto, int quantidadeItem, double precoProduto)
        {
            this.produtoID = produtoID;
            this.codigoProduto = codigoProduto;
            this.quantidadeItem = quantidadeItem;
            this.precoProduto = precoProduto;
        }

        public int ItensPedidoID
        {
            get
            {
                return itensPedidoID;
            }

            
        }

        public int ProdutoID
        {
            get
            {
                return produtoID;
            }

            set
            {
                produtoID = value;
            }
        }

        public int CodigoProduto
        {
            get
            {
                return codigoProduto;
            }

            set
            {
                codigoProduto = value;
            }
        }

        public int QuantidadeItem
        {
            get
            {
                return quantidadeItem;
            }

            set
            {
                quantidadeItem = value;
            }
        }

        public double PrecoProduto
        {
            get
            {
                return precoProduto;
            }

            set
            {
                precoProduto = value;
            }
        }


    }
}
