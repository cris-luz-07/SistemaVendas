using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Vendas.MODEL
{
    class Permissao
    {
        int permissaoID = 0;
        int usuarioID = 0;
        bool atribuirPermissao = false;
        bool cadastrarProdutos = false;
        bool alterarPrecos = false;
        bool criarUsuario = false;

        public Permissao(int usuarioID, bool atribuirPermissao, bool cadastrarProdutos, bool alterarPrecos, bool criarUsuario)
        {
            this.usuarioID = usuarioID;
            this.atribuirPermissao = atribuirPermissao;
            this.cadastrarProdutos = cadastrarProdutos;
            this.alterarPrecos = alterarPrecos;
            this.criarUsuario = criarUsuario;
        }



        public int PermissaoID
        {
            get
            {
                return permissaoID;
            }

        }

        public int UsuarioID
        {
            get
            {
                return usuarioID;
            }

        }

        public bool AtribuirPermissao
        {
            get
            {
                return atribuirPermissao;
            }

            set
            {
                atribuirPermissao = value;
            }
        }

        public bool CadastrarProdutos
        {
            get
            {
                return cadastrarProdutos;
            }

            set
            {
                cadastrarProdutos = value;
            }
        }

        public bool AlterarPrecos
        {
            get
            {
                return alterarPrecos;
            }

            set
            {
                alterarPrecos = value;
            }
        }

        public bool CriarUsuario
        {
            get
            {
                return criarUsuario;
            }

            set
            {
                criarUsuario = value;
            }
        }


    }
}
