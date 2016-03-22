using Sistema_de_Vendas.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Vendas.MODEL
{
    class PedidoDAO : genericoDAO<Pedido>
    {
        SqlConnection sqlConn = null;
        private string strConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo_ThinkPad\Documents\Visual Studio 2015\Projects\CRUD_basico\CRUD_basico\sisDB\dbPrincipal.mdf;Integrated Security = True; Connect Timeout = 30";
        private string _Sql = string.Empty;

       

        public void inserir(Pedido e)
        {
            try
            {
                sqlConn = new SqlConnection(strConn);
                //DOUGLAS : Adicionar Insert correspondente.
                string _sql = "Insert into Agenda values()";
                //MessageBox.Show(sql);
                SqlCommand sc;
                sc = new SqlCommand(_sql, sqlConn);
                sc.CommandType = CommandType.Text;
                sc.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void alterar(Pedido e)
        {
            try
            {
                sqlConn = new SqlConnection(strConn);
                //DOUGLAS : Adicionar Insert correspondente.
                string _sql = "UPDATE SET WHERE";
                //MessageBox.Show(sql);
                SqlCommand sc;
                sc = new SqlCommand(_sql, sqlConn);
                sc.CommandType = CommandType.Text;
                sc.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void remover(Pedido e)
        {
            try
            {
                sqlConn = new SqlConnection(strConn);
                //DOUGLAS : Adicionar Insert correspondente.
                string _sql = "DELETE * FROM WHERE =";
                //MessageBox.Show(sql);
                SqlCommand sc;
                sc = new SqlCommand(_sql, sqlConn);
                sc.CommandType = CommandType.Text;
                sc.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public List<Pedido> listar
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //public List<Pedido> listar
        //{
        //    get
        //    //{
        //    //    try
        //    //    {
        //    //        string sql = "select * from Agenda";
        //    //        SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
        //    //        DataSet dtset = new DataSet();
        //    //        sda.Fill(dtset, "Agenda");
        //    //        DataTable dt = dtset.Tables["Agenda"];
        //    //        gdvNomes.SetDataBinding(dtset, "Agenda");

        //    //        foreach (DataRow dtRow in dt.Rows)
        //    //        {
        //    //            LstDetalhes.Items.Add(dtRow["nome"].ToString());
        //    //        }
        //    //    }
        //    //    catch (Exception ex)
        //    //    {
        //    //        MessageBox.Show(ex.ToString());
        //    //    }
        //    //}
        //}
    }
}
