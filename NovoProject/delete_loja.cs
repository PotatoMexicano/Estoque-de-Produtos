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
    public partial class delete_loja : Form
    {
        Control control = new Control();
        public delete_loja()
        {
            InitializeComponent();
        }

        private void delete_loja_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = control.selectLoja();
            listBox1.ValueMember = "codLoja";
            listBox1.DisplayMember = "nome";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true){
                control.deleta_loja(Int32.Parse(listBox1.SelectedValue.ToString()));
                control.selectLoja();
            }
            else
            {
                MessageBox.Show("Confirme a operação");
            }
        }
    }
}
