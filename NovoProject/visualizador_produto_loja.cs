using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovoProject
{
    public partial class visualizador_produto_loja : Form
    {
        Control control = new Control();
        private DataTable table1;
        private DataTable table2;

        public visualizador_produto_loja()
        {
            InitializeComponent();
            
        }

        public void selectLoja()
        {
            table1 = control.selectLoja();
            listBox1.DataSource = table1;
            listBox1.ValueMember = table1.Columns[0].ColumnName;
            listBox1.DisplayMember = table1.Columns[1].ColumnName;
            
        }
        public void select_Dados_Loja_Produto()
        {
            table2 = control.select_produto_loja(table1.Rows[listBox1.SelectedIndex][0].ToString());
            dataGridView1.DataSource = table2;
            dataGridView1.Columns[0].HeaderText = "Produto";
            dataGridView1.Columns[1].HeaderText = "Código";
            dataGridView1.Columns[2].HeaderText = "Estoque";
            dataGridView1.Columns[3].HeaderText = "Loja";
            dataGridView1.Columns[4].HeaderText = "Cidade";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            select_Dados_Loja_Produto();
           
        }

        private void visualizador_produto_loja_Load(object sender, EventArgs e)
        {
            selectLoja();
        }
    }
}
