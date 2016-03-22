using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Vendas.DAO
{
    interface genericoDAO <E>
    {
        void inserir(E e);

        void remover(E e);

        void alterar(E e);

        List<E> listar { get; }
    }
}
