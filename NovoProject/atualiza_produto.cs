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
    public partial class atualiza_produto : Form
    {

        Control control = new Control();
        private DataTable table;
        private DataTable tableCombo;
        public atualiza_produto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void atualizar()
        {
            textBox1.Text = table.Rows[listBox1.SelectedIndex][3].ToString();
            textBox1.Enabled = false;
            textBox2.Text = table.Rows[listBox1.SelectedIndex][0].ToString();
            textBox3.Text = table.Rows[listBox1.SelectedIndex][1].ToString();

            comboBox1.SelectedValue = Convert.ToInt32(table.Rows[listBox1.SelectedIndex][4]);
        }
        public void select() //pronto
        {
            table = control.selectProduto();
            listBox1.DataSource = table;
            listBox1.DisplayMember = table.Columns[0].ColumnName;
            listBox1.ValueMember = table.Columns[3].ColumnName;

            comboBox1.DataSource = table;
            comboBox1.DisplayMember = table.Columns[2].ColumnName;
            comboBox1.ValueMember = table.Columns[3].ColumnName;

        }

        public void fillCombo()
        {
            tableCombo = control.selectMarca();
            comboBox1.DataSource = tableCombo;
            comboBox1.DisplayMember = tableCombo.Columns[1].ColumnName;
            comboBox1.ValueMember = tableCombo.Columns[0].ColumnName;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void atualiza_produto_Load(object sender, EventArgs e)
        {
            select();
            fillCombo();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            atualizar();
        }
    }
}