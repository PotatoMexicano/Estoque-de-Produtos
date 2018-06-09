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
    public partial class atualiza_loja : Form
    {
        Control control = new Control();
        public atualiza_loja()
        {
            InitializeComponent();
        }

        private void atualiza_loja_Load(object sender, EventArgs e)
        {
            gridAttLoja.DataSource = control.selectLoja();
            gridAttLoja.Columns[0].Visible = false;
            gridAttLoja.Columns[1].HeaderText = "Nome";
            gridAttLoja.Columns[2].HeaderText = "Cidade";
            gridAttLoja.ReadOnly = true;
        }

        private void gridAttLoja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                textBox1.Text = gridAttLoja.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox2.Text = gridAttLoja.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridAttLoja.DataSource = control.updateLoja(textBox1.Text, textBox2.Text, gridAttLoja.SelectedCells[0].Value.ToString());
            gridAttLoja.Columns[0].Visible = false;
            gridAttLoja.Columns[1].HeaderText = "Nome";
            gridAttLoja.Columns[2].HeaderText = "Cidade";
            gridAttLoja.ReadOnly = true;
        }
    }
}
