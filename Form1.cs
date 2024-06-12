using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caixa_de_produtos
{
    public partial class Form1 : Form
    {
        
        frmCadProdutos frm = new frmCadProdutos();


        public Form1()
        {
            InitializeComponent();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm.Show();
            
        }

       
     
    }
}
