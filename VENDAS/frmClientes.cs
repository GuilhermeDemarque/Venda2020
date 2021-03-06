﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VENDAS
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            dtGrvClientes.DataSource = "";
            dtGrvClientes.DataSource = dalCli.Select();
            gpbPesquisa.Visible = false;
        }

        

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Clientes cliente = new CAMADAS.MODEL.Clientes();
            cliente.nome = txtNome.Text;
            cliente.cpf = txtCpf.Text;
            cliente.celular = txtCelular.Text;
            cliente.municipio = txtMunicipio.Text;
            cliente.endereco = txtEndereco.Text;
            cliente.cep = txtCep.Text;

            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            dalCli.Insert(cliente);

            dtGrvClientes.DataSource = "";
            dtGrvClientes.DataSource = dalCli.Select();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Clientes cliente = new CAMADAS.MODEL.Clientes();
            cliente.codigo = Convert.ToInt32(txtCodigo.Text);
            cliente.nome = txtNome.Text;
            cliente.cpf = txtCpf.Text;
            cliente.celular = txtCelular.Text;
            cliente.municipio = txtMunicipio.Text;
            cliente.endereco = txtEndereco.Text;
            cliente.cep = txtCep.Text;

            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            dalCli.Update(cliente);

            dtGrvClientes.DataSource = "";
            dtGrvClientes.DataSource = dalCli.Select();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(txtCodigo.Text);
            
            
            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            dalCli.Delete(idCliente);

            dtGrvClientes.DataSource = "";
            dtGrvClientes.DataSource = dalCli.Select();
        }
        private void limpaControles()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtCelular.Text = "";//string.Empty
            txtCpf.Text = string.Empty; //""
            txtMunicipio.Text = "";
            txtEndereco.Text = "";
            txtCep.Text = "";
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaControles();
        }

        private void txtNome_TextChanged(object sender , EventArgs e)
        {

        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            gpbPesquisa.Visible = !gpbPesquisa.Visible;
        }

        private void rdbTodo_CheckedChanged(object sender, EventArgs e)
        {
            lblFiltro.Visible = false;
            txtFiltro.Visible = false;
            btnFiltrar.Visible = false;

            CAMADAS.BLL.Clientes bllClientes = new CAMADAS.BLL.Clientes();
            dtGrvClientes.DataSource = "";
            dtGrvClientes.DataSource = bllClientes.Select();
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            lblFiltro.Text = "Informe o Codigo do Cliente";
            lblFiltro.Visible = true;
            txtFiltro.Visible = true;
            btnFiltrar.Visible = true;
            txtFiltro.Focus();
        }

        private void rbdNome_CheckedChanged(object sender, EventArgs e)
        {
            lblFiltro.Text = "Informe o Nome do Cliente";
            lblFiltro.Visible = true;
            txtFiltro.Visible = true;
            btnFiltrar.Visible = true;
            txtFiltro.Focus();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<CAMADAS.MODEL.Clientes> lstClientes = new List<CAMADAS.MODEL.Clientes>();
            CAMADAS.DAL.Clientes dalClientes = new CAMADAS.DAL.Clientes();

            if (rdbCodigo.Checked)
            {
                int codigo = Convert.ToInt32(txtFiltro.Text);
                lstClientes = dalClientes.SelectByCodigo(codigo);
            }
            else if (rbdNome.Checked)
                lstClientes = dalClientes.SelectByNome(txtFiltro.Text);

            dtGrvClientes.DataSource = "";
            dtGrvClientes.DataSource = lstClientes;
        }
    }

}
