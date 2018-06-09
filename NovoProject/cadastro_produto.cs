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
    public partial class cadastro_produto : Form
    {
        Control control = new Control();
        DataTable table;
        DataTable tableCombo;
        public cadastro_produto()
        {
            InitializeComponent();

        }
        private void feed()
        {
            tableCombo = control.feedCombo();
            comboBox1.DataSource = tableCombo;
            comboBox1.DisplayMember = tableCombo.Columns[1].ColumnName;
            comboBox1.ValueMember = "codMarca";
        }
        public void reloadGrid()
        {
            table = control.selectProd();
            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "Descrição";
            dataGridView1.Columns[1].HeaderText = "Preço";
            dataGridView1.Columns[2].HeaderText = "Marca";
        }

        private void cadastro_produto_Load(object sender, EventArgs e)
        {
            control.selectProduto();
            feed();
            reloadGrid();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            control.insertProduto(textBox1.Text,Convert.ToDecimal(textBox2.Text),Convert.ToInt32(tableCombo.Rows[comboBox1.SelectedIndex][0].ToString()));
            dataGridView1.DataSource = control.selectProd();
        }
    }
}
