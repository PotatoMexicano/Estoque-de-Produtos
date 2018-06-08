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
        //comment legal
        private SqlConnection conex;
        public Control()
        {
            conex = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\ExercicioDB.mdf;Integrated Security=True;Connect Timeout=30");

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

    }
}
