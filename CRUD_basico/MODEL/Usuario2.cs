using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Vendas.MODEL
{
    
        class Usuario
    {
        private int usuarioId = 0;
        private String email = string.Empty;
        private String senha = string.Empty;
        private Permissao permissao;
        private int i = 0;

        public Usuario(String email, String senha)
        {
            this.email = email;
            this.senha = senha;
        }

        public String Email { get; set; }
        public String Senha { get; set; }


    }
}
