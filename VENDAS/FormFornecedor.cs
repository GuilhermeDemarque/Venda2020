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
    public partial class FormFornecedor : Form
    {
        public FormFornecedor()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormFornecedor_Load(object sender, EventArgs e)
        {
            CAMADAS.DAL.Fornecedores dalFor = new CAMADAS.DAL.Fornecedores();
            dtGridFornecedor.DataSource = "";
            dtGridFornecedor.DataSource = dalFor.Select();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Fornecedores fornecedor = new CAMADAS.MODEL.Fornecedores();
            fornecedor.nome = txtNome.Text;
            fornecedor.cnpj = txtCnpj.Text;
            fornecedor.telefone = txtTelefone.Text;

            CAMADAS.DAL.Fornecedores dalFor = new CAMADAS.DAL.Fornecedores();
            dalFor.Insert(fornecedor);

            dtGridFornecedor.DataSource = "";
            dtGridFornecedor.DataSource = dalFor.Select();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Fornecedores fornecedor = new CAMADAS.MODEL.Fornecedores();
            fornecedor.codigo = Convert.ToInt32(txtCodigo.Text);
            fornecedor.nome = txtNome.Text;
            fornecedor.cnpj = txtCnpj.Text;
            fornecedor.telefone = txtTelefone.Text;

            CAMADAS.DAL.Fornecedores dalFor = new CAMADAS.DAL.Fornecedores();
            dalFor.Update(fornecedor);

            dtGridFornecedor.DataSource = "";
            dtGridFornecedor.DataSource = dalFor.Select();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int idFornecedor = Convert.ToInt32(txtCodigo.Text);

            CAMADAS.DAL.Fornecedores dalFor = new CAMADAS.DAL.Fornecedores();
            dalFor.Delete(idFornecedor);

            dtGridFornecedor.DataSource = "";
            dtGridFornecedor.DataSource = dalFor.Select();


        }

        private void limpacontroles()
        {
            txtCodigo.Text = "";
            txtCnpj.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpacontroles();
        }
    }
}
