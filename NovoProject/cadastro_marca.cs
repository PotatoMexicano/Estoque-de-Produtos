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
    public partial class cadastro_marca : Form
    {
        Control control = new Control();

        public cadastro_marca()
        {
            InitializeComponent();
        }

        private void cadastro_marca_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = control.selectMarca();
            dataGridView1.Columns[0].HeaderText = "Marca";
            dataGridView1.ReadOnly = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            control.insertMarca(textBox1.Text);
            dataGridView1.DataSource = control.selectMarca();
        }
    }
}
//mudei algumas coisas

