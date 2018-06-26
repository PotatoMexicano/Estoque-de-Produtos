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
    public partial class atualiza_marca : Form
    {
        Control control = new Control();
        DataTable table;
        public atualiza_marca()
        {
            InitializeComponent();
        }

        private void atualiza_marca_Load(object sender, EventArgs e)
        {
            table = control.selectMarca();
            listBox1.DataSource = table;
            listBox1.ValueMember = table.Columns[0].ColumnName;
            listBox1.DisplayMember = table.Columns[1].ColumnName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            control.updateMarca(Convert.ToInt32(listBox1.SelectedValue.ToString()), textBox1.Text);
            table = control.selectMarca();
            listBox1.DataSource = table;
            listBox1.ValueMember = table.Columns[0].ColumnName;
            listBox1.DisplayMember = table.Columns[1].ColumnName;

            textBox1.Text = "";
            MessageBox.Show("Dados atualizados!");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = table.Rows[listBox1.SelectedIndex][1].ToString();
        }
    }
}
