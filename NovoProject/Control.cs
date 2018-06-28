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
            //String Gabriel//  conex = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\ExercicioDB.mdf;Integrated Security=True;Connect Timeout=30");
            //String Kami//
            conex = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gabri\Downloads\ExercicioDB.mdf;Integrated Security=True;Connect Timeout=30");
            //conex = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pichau\Documents\ExercicioDB.mdf;Integrated Security=True;Connect Timeout=30");

        }

        

        //marca
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
        public void updateMarca(int cod, string nome)
        {
            SqlCommand att = new SqlCommand();
            att.Connection = conex;
            att.Parameters.Add("@cod", SqlDbType.Int).Value = cod;
            att.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            att.CommandText = "update marca set nome = @nome where codMarca = @cod";

            conex.Open();
            att.ExecuteNonQuery();
            conex.Close();

            selectMarca();
        }
        public void delete_marca(int cod)
        {
            SqlCommand add1 = new SqlCommand();
            add1.Connection = conex;
            add1.Parameters.Add("@cod", SqlDbType.Int).Value = cod;
            add1.CommandText = "delete from marca where codMarca = @cod";
            conex.Open();
            add1.ExecuteNonQuery();
            conex.Close();
        }


        //loja
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
        public DataTable updateLoja(int cod, string New, string cidade, string nome)
        {
            SqlCommand att = new SqlCommand();
            att.Connection = conex;
            att.Parameters.Add("@cod", SqlDbType.Int).Value = cod;
            att.Parameters.Add("@new", SqlDbType.VarChar).Value = New;
            att.Parameters.Add("@cidade", SqlDbType.VarChar).Value = cidade;
            att.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
            att.CommandText = "update Loja set nome = @new, cidade = @cidade where codLoja = @cod";

            conex.Open();
            att.ExecuteNonQuery();
            conex.Close();

            SqlDataAdapter adptor = new SqlDataAdapter("select * from Loja", conex);
            DataTable table = new DataTable();
            adptor.Fill(table);

            return table;
        }
        public void deleta_loja(int key)
        {
            SqlCommand add = new SqlCommand();
            add.Connection = conex;
            add.Parameters.Add("@key", SqlDbType.Int).Value = key;
            add.CommandText = "delete from Loja where codLoja = @key";
            conex.Open();
            add.ExecuteNonQuery();
            conex.Close();
        }


        //produto
        public DataTable selectProduto()
        {
            SqlDataAdapter adptor = new SqlDataAdapter("select descricao,preco,nome,prod.codProduto,prod.codMarca from produto as prod join marca as marc on prod.codMarca = marc.codMarca ", conex);
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
        public void updateProduto(int codigo, string nome, decimal preco, int marca)
        {
            SqlCommand att = new SqlCommand();
            att.Connection = conex;
            att.Parameters.Add("@codigo", SqlDbType.Int).Value =codigo;
            att.Parameters.Add("@descricao", SqlDbType.VarChar).Value = nome;
            att.Parameters.Add("@preco", SqlDbType.Decimal).Value = preco;
            att.Parameters.Add("@marca", SqlDbType.Int).Value = marca;

            att.CommandText = "update produto set descricao = @descricao, preco = @preco, codMarca = @marca where codProduto = @codigo";

            conex.Open();
            att.ExecuteNonQuery();
            conex.Close();

        }
        public void delete_prod(int chave)
        {
            SqlCommand add = new SqlCommand();
            add.Connection = conex;
            add.Parameters.Add("@chave", SqlDbType.Int).Value = chave;
            add.CommandText = "delete from produto where codProduto = @chave";
            conex.Open();
            add.ExecuteNonQuery();
            conex.Close();
        }



        //universal
        public DataTable feedCombo()
        {
            SqlDataAdapter adptor = new SqlDataAdapter("select * from marca", conex);
            DataTable table = new DataTable();
            adptor.Fill(table);
            return table;
        }
       

        

    }
}
//batata

