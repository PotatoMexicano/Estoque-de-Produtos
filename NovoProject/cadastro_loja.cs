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
    public partial class cadastro_loja : Form
    {
        Control control = new Control(); 
        public cadastro_loja()
        {
            InitializeComponent();
        }

        private void cadastro_loja_Load(object sender, EventArgs e)
        {

            gridAddLoja.DataSource = control.selectLoja();
            gridAddLoja.Columns[0].Visible = false;
            gridAddLoja.Columns[1].HeaderText = "Nome";
            gridAddLoja.Columns[1].HeaderText = "Cidade";
            gridAddLoja.ReadOnly = true; 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            control.insertLoja(textBox1.Text,textBox2.Text);
             control.selectLoja();
            gridAddLoja.DataSource = control.selectLoja();
        }
    }
}
