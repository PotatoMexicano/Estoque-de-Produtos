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
    public partial class pesquisa_loja_produto : Form
    {
        Control control = new Control();
        private DataTable table;
        private DataTable table2;
        public pesquisa_loja_produto()
        {
            InitializeComponent();
            selectLoja();
        }

        public void selectLoja()
        {
            table = control.selectLoja();
            listBox1.DataSource = table;
            listBox1.DisplayMember = table.Columns[1].ColumnName;
            listBox1.ValueMember = table.Columns[0].ColumnName;
        }
        public void select_Dados_Loja_prod()
        {
            table2 = control.select_loja_prod(listBox1.SelectedValue.ToString());
            dataGridView1.DataSource = table2;
        }
    }
}
