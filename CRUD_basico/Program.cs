using Sistema_de_Vendas;
using Sistema_de_Vendas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_basico
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin frmLogin = new frmLogin();

            frmLogin.ShowDialog();
           
            if (frmLogin.logado)
            {
                Application.Run(new frmCaixa());
                                
            }

            Usuario usuario = new Usuario("usuario","usuario");

            MessageBox.Show(usuario.Email + " " + usuario.Senha);

            usuario.Email = "usuario3";
            usuario.Senha = "usuario3";

            MessageBox.Show(usuario.Email+" "+usuario.Senha );

        }
    }
}
