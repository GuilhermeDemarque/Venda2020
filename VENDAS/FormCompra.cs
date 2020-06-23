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
    public partial class FormCompra : Form
    {
        public FormCompra()
        {
            InitializeComponent();
        }

        private void FormCompra_Load(object sender, EventArgs e)
        {
            CAMADAS.BLL.Fornecedor bllFor = new CAMADAS.BLL.Fornecedor();
            cmbFornecedor.DisplayMember = "nome";
            cmbFornecedor.ValueMember = "codigo";
            cmbFornecedor.DataSource = bllFor.Select();
            CAMADAS.DAL.Produtos bllProd = new CAMADAS.DAL.Produtos();
            cmbProduto.DisplayMember = "nomeproduto";
            cmbProduto.ValueMember = "codproduto";
            cmbProduto.DataSource = bllProd.Select();
            CAMADAS.BLL.Compra bllCompra = new CAMADAS.BLL.Compra();
            dataGridViewCompra.DataSource = "";
            dataGridViewCompra.DataSource = bllCompra.Select();

           
            habilitaControles(false);


           

        }
        void limpaCampos()
        {
            lblCod.Text = "-1";
            txtFornecedor.Text = "";
            txtProduto.Text = "";

        }

        private void habilitaControles(bool status)
        {
            txtFornecedor.Enabled = status;
            cmbFornecedor.Enabled = status;

            txtProduto.Enabled = status;
            cmbProduto.Enabled = status;

            btnCompra.Enabled = !status;
            btnEditar.Enabled = !status;



        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            limpaCampos();
            habilitaControles(true);
            cmbFornecedor.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitaControles(false);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            habilitaControles(false);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmbFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtFornecedor.Text = cmbFornecedor.SelectedValue.ToString();
            }
            finally
            {

            }
        }

        private void txtFornecedor_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtFornecedor.Text != "")
                    cmbFornecedor.SelectedValue = Convert.ToInt32(txtFornecedor.Text);
            }
            catch
            {
                MessageBox.Show("Fornecedor Invalido");
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Compra compra = new CAMADAS.MODEL.Compra();
            compra.codcompra = Convert.ToInt32(lblCod.Text);
            compra.codigo = Convert.ToInt32(txtFornecedor.Text);
            compra.fornecedor = cmbFornecedor.Text;
            compra.nomeproduto = cmbProduto.Text;


            CAMADAS.BLL.Compra bllCom = new CAMADAS.BLL.Compra();
            if (lblCod.Text == "-1")
                bllCom.Insert(compra);
            else bllCom.Update(compra);


            

            dataGridViewCompra.DataSource = "";
            dataGridViewCompra.DataSource = bllCom.Select();

            habilitaControles(false);

        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtProduto.Text = cmbProduto.SelectedValue.ToString();
            }
            finally
            {

            }
        }

        private void txtProduto_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtProduto.Text != "")
                    cmbProduto.SelectedValue = Convert.ToInt32(txtProduto.Text);
            }
            catch
            {
                MessageBox.Show("Produto Invalido");
            }
        }
    }
}
