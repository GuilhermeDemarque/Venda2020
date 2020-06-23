using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace VENDAS
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd ,int wmsg,int wparam , int lparam );


        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes frmCli = new frmClientes();
            frmCli.MdiParent = this;
            frmCli.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FormProduto frmProd = new FormProduto();
            frmProd.MdiParent = this;
            frmProd.Show();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            FormCompra frmCompra = new FormCompra();
            frmCompra.MdiParent = this;
            frmCompra.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 250;
        }

        private void iconeFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconeMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconeRestaurar.Visible = true;
            iconeMaximizar.Visible = false;
        }

        private void iconeRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconeRestaurar.Visible = false;
            iconeMaximizar.Visible = true;
        }

        private void iconeMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        private void abrirForm(object formFilho)
        {
            if (this.PainelFilhos.Controls.Count > 0)
                this.PainelFilhos.Controls.RemoveAt(0);
            Form ff = formFilho as Form;
            ff.TopLevel = false;
            ff.Dock = DockStyle.Fill;
                this.PainelFilhos.Controls.Add(ff);
            this.PainelFilhos.Tag = ff;
            ff.Show();
        }
        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            abrirForm(new frmClientes());
        }

        private void btnProdutos_Click_1(object sender, EventArgs e)
        {
            abrirForm(new FormProduto());
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            abrirForm(new FormFornecedor());
        }

        private void btnCompra_Click_1(object sender, EventArgs e)
        {
            abrirForm(new FormCompra());
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            RELATORIOS.RelGerais.relClientes();
        }

        private void btnRelProduto_Click(object sender, EventArgs e)
        {
            RELATORIOS.RelProdutos.relProdutos();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            abrirForm(new FormSobre());
        }
    }
}

