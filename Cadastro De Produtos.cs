using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caixa_de_produtos
{
    public partial class frmCadProdutos : Form
    {
        string Produto, Preco, Categori;
        public List<Produto> Produt = new List<Produto>();
      
        public frmCadProdutos()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto novoproduto = new Produto(int.Parse(txtPreco.Text));

           lblVResult.Text = "R$ " + novoproduto.CalculoTotal().ToString("F2",CultureInfo.InvariantCulture);

            Produto = txtProduto.Text;
            Preco = txtPreco.Text;
            Categori = cbCatergoria.Text;
            lvProdutos.Items.Add(new ListViewItem(new String[] { Produto, Preco, Categori }));

        }

        private void frmCadProdutos_Load(object sender, EventArgs e)
        {

        }
    }
}
