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
    
    public partial class delete_produto : Form
    {
        Control control = new Control();
        public delete_produto()
        {
            InitializeComponent();
        }

        private void delete_produto_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = control.selectProduto();
            listBox1.DisplayMember = "descricao";
            listBox1.ValueMember = "codProduto";

           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {


                control.delete_prod(Int32.Parse(listBox1.SelectedValue.ToString()));
                listBox1.DataSource = control.selectProduto();
            }
            else
            {
                MessageBox.Show("Opa Fião");
            }
        }
    }
}
