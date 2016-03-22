using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Vendas.MODEL
{
    class Pedido
    {
        int pedidoID = 0 ;
        int usuarioID = 0 ;
        DateTime data;
        Decimal totalPedido = 0;
        enum status {pendente,concluido}
        List<itensPedido> listaPedido ;

        public Pedido(int usuarioID, DateTime data , Decimal totalPedido, Enum status)
        {
            this.usuarioID = usuarioID;
            this.data = data;
            this.totalPedido = totalPedido;
            //this.Status = estado
        }

        public int PedidoID
        {
            get
            {
                return pedidoID;
            }

            set
            {
                pedidoID = value;
            }
        }

        public int UsuarioID
        {
            get
            {
                return usuarioID;
            }

            set
            {
                usuarioID = value;
            }
        }

        public DateTime Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public Decimal TotalPedido
        {
            get
            {
                return totalPedido;
            }

            set
            {
                totalPedido = value;
            }
        }

        internal List<itensPedido> ListaPedido
        {
            get
            {
                return listaPedido;
            }

            set
            {
                listaPedido = value;
            }
        }
    }
}
