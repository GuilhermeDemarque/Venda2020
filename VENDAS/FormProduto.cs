using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VENDAS
{
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            CAMADAS.DAL.Produtos bllProdutos = new CAMADAS.DAL.Produtos();
            dtGridProduto.DataSource = "";
            dtGridProduto.DataSource = bllProdutos.Select(); ;
            gpbPesquisa.Visible = false;
        }
        private void limpaControles()
        {
            txtCodProd.Text = string.Empty;
            txtNomeProduto.Text = string.Empty;
            txtQuantidade.Text = "";
            txtPrecoCusto.Text = "";
            txtPrecoVenda.Text = "";

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Produtos bllProduto = new CAMADAS.BLL.Produtos();
            CAMADAS.MODEL.Produtos produto = new CAMADAS.MODEL.Produtos();
            produto.nomeproduto = txtNomeProduto.Text;
            produto.quantidade = Convert.ToInt32(txtQuantidade.Text);
            produto.precocusto = Convert.ToSingle(txtPrecoCusto.Text);
            produto.precovenda = Convert.ToSingle(txtPrecoVenda.Text);


            bllProduto.Insert(produto);

            limpaControles();

            dtGridProduto.DataSource = "";
            dtGridProduto.DataSource = bllProduto.Select();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            CAMADAS.MODEL.Produtos produto = new CAMADAS.MODEL.Produtos();
            produto.codproduto = Convert.ToInt32(txtCodProd.Text);
            produto.nomeproduto = txtNomeProduto.Text;
            produto.quantidade = Convert.ToInt32(txtQuantidade.Text);
            produto.precocusto = Convert.ToSingle(txtPrecoCusto.Text);
            produto.precovenda = Convert.ToSingle(txtPrecoVenda.Text);

            CAMADAS.DAL.Produtos bllProduto = new CAMADAS.DAL.Produtos();
            bllProduto.Update(produto);

            limpaControles();

            dtGridProduto.DataSource = "";
            dtGridProduto.DataSource = bllProduto.Select();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int codigoProduto = Convert.ToInt32(txtCodProd.Text);

            CAMADAS.DAL.Produtos dalpro = new CAMADAS.DAL.Produtos();
            dalpro.Delete(codigoProduto);

            dtGridProduto.DataSource = "";
            dtGridProduto.DataSource = dalpro.Select();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            gpbPesquisa.Visible = !gpbPesquisa.Visible;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblFiltro.Visible = false;
            txtFiltro.Visible = false;
            btnFiltrar.Visible = false;
            
            CAMADAS.BLL.Produtos bllProdutos = new CAMADAS.BLL.Produtos();
            dtGridProduto.DataSource = "";
            dtGridProduto.DataSource = bllProdutos.Select();
        }

        private void gpbPesquisa_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            lblFiltro.Text = "Informe o Codigo do Produto";
            lblFiltro.Visible = true;
            txtFiltro.Visible = true;
            btnFiltrar.Visible = true;
            txtFiltro.Focus();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            lblFiltro.Text = "Informe o Nome do Produto";
            lblFiltro.Visible = true;
            txtFiltro.Visible = true;
            btnFiltrar.Visible = true;
            txtFiltro.Focus();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<CAMADAS.MODEL.Produtos> lstProdutos = new List<CAMADAS.MODEL.Produtos>();
            CAMADAS.BLL.Produtos bllProdutos = new CAMADAS.BLL.Produtos();

            if (rdbCodigo.Checked)
            {
                int codproduto = Convert.ToInt32(txtFiltro.Text);
                lstProdutos = bllProdutos.SelectByCodigo(codproduto);
            }
            else if (rdbNome.Checked)
                lstProdutos = bllProdutos.SelectByNome(txtFiltro.Text);

            dtGridProduto.DataSource = "";
            dtGridProduto.DataSource = lstProdutos;

        }
    }
}
