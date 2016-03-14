using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_de_Vendas
{
    public partial class frmLogin : Form
    {
        SqlConnection sqlConn = null;
        private string strConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo_ThinkPad\Documents\Visual Studio 2015\Projects\CRUD_basico\CRUD_basico\sisDB\dbPrincipal.mdf;Integrated Security = True; Connect Timeout = 30";
        private string _Sql = string.Empty;

        public frmLogin()
        {
            InitializeComponent();
        }

        public void logar()
        {
            sqlConn = new SqlConnection(strConn);
            string usuario, senha;

            try
            {
                usuario = txtUsuario.Text;
                senha = txtSenha.Text;

                _Sql = "SELECT COUNT(UsuarioID) FROM tblUsuario WHERE (usuario = @Usuario AND senha = @Senha)";

                SqlCommand cmd = new SqlCommand(_Sql, sqlConn);

                cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = usuario;
                cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = senha;

                sqlConn.Open();

                int v = (int)cmd.ExecuteScalar();

                if(v > 0)
                {
                    MessageBox.Show("Logado com Sucesso");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro+" no Banco");
                throw;
            }
        }
    }
}
