using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace NovoProject
{
    class Control
    {
        private SqlConnection conex;
        public Control()
        {
            //String Gabriel//conex = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\ExercicioDB.mdf;Integrated Security=True;Connect Timeout=30");
            /*String Kami*/
            conex = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pichau\Documents\ExercicioDB.mdf;Integrated Security=True;Connect Timeout=30");

        }
        public DataTable selectMarca()
        {
            SqlDataAdapter adptor = new SqlDataAdapter("select * from marca ", conex);
            DataTable table = new DataTable();
            adptor.Fill(table);

            return table;
        }
        public void insertMarca(string nome)
        {
            SqlCommand add = new SqlCommand();
            add.Connection = conex;
            add.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            add.CommandText = "insert into marca values(@nome)";
            conex.Open();
            add.ExecuteNonQuery();
            conex.Close();
        }
        public DataTable selectLoja()
        {
            SqlDataAdapter adptor = new SqlDataAdapter("select * from Loja ",conex);
            DataTable table = new DataTable();
            adptor.Fill(table);
            return table;
        }
        public void insertLoja(string nome,string cidade)
        {
            SqlCommand add = new SqlCommand();
            add.Connection = conex;
            add.Parameters.Add("@cidade", SqlDbType.VarChar).Value = cidade;
            add.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            add.CommandText = "insert into Loja values(@nome,@cidade)";
            conex.Open();
            add.ExecuteNonQuery();
            conex.Close();
        }
        public DataTable selectProduto()
        {
            SqlDataAdapter adptor = new SqlDataAdapter("select descricao,preco,nome from produto as prod join marca as marc on prod.codMarca = marc.codMarca ", conex);
            DataTable table = new DataTable();
            adptor.Fill(table);
            return table;
        }
        public void insertProduto(string descriçao,decimal preço,int marca)
        {
            SqlCommand add = new SqlCommand();
            add.Connection = conex;
            add.Parameters.Add("@descriçao", SqlDbType.VarChar).Value = descriçao;
            add.Parameters.Add("@preco", SqlDbType.Decimal).Value = preço;
            add.Parameters.Add("@marca", SqlDbType.Int).Value = marca; 
            add.CommandText = "insert into produto values(@descriçao,@preco,@marca)";
            conex.Open();
            add.ExecuteNonQuery();
            conex.Close();
        }
        public DataTable feedCombo()
        {
            SqlDataAdapter adptor = new SqlDataAdapter("select * from marca", conex);
            DataTable table = new DataTable();
            adptor.Fill(table);
            return table;
        }
        public DataTable selectProd()
        {
            SqlDataAdapter adptor = new SqlDataAdapter("select descricao,preco,nome from produto as prod join marca as marc on prod.codMarca = marc.codMarca", conex);
            DataTable table = new DataTable();
            adptor.Fill(table);
            return table;
        }

        public DataTable updateLoja(string New, string cidade, string nome)
        {
            SqlCommand att = new SqlCommand();
            att.Connection = conex;
            att.Parameters.Add("@new", SqlDbType.VarChar).Value = New;
            att.Parameters.Add("@cidade", SqlDbType.VarChar).Value = cidade;
            att.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            att.CommandText = "update Loja set nome = @new, cidade = @cidade where nome = @nome";

            conex.Open();
            att.ExecuteNonQuery();
            conex.Close();

            SqlDataAdapter adptor = new SqlDataAdapter("select * from Loja", conex);
            DataTable table = new DataTable();
            adptor.Fill(table);

            return table;
        }

    }
}
//batata

