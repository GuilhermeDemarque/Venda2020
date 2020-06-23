namespace VENDAS
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Panel();
            this.PainelFilhos = new System.Windows.Forms.Panel();
            this.iconeMinimizar = new System.Windows.Forms.PictureBox();
            this.iconeRestaurar = new System.Windows.Forms.PictureBox();
            this.iconeMaximizar = new System.Windows.Forms.PictureBox();
            this.iconeFechar = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.btnRelProduto = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSobre = new System.Windows.Forms.Button();
            this.MenuVertical.SuspendLayout();
            this.Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(67)))), ((int)(((byte)(141)))));
            this.MenuVertical.Controls.Add(this.btnSobre);
            this.MenuVertical.Controls.Add(this.btnRelProduto);
            this.MenuVertical.Controls.Add(this.btnRelatorio);
            this.MenuVertical.Controls.Add(this.btnCompra);
            this.MenuVertical.Controls.Add(this.btnFornecedores);
            this.MenuVertical.Controls.Add(this.btnProdutos);
            this.MenuVertical.Controls.Add(this.btnClientes);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 650);
            this.MenuVertical.TabIndex = 9;
            // 
            // Titulo
            // 
            this.Titulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Titulo.Controls.Add(this.iconeMinimizar);
            this.Titulo.Controls.Add(this.iconeRestaurar);
            this.Titulo.Controls.Add(this.iconeMaximizar);
            this.Titulo.Controls.Add(this.iconeFechar);
            this.Titulo.Controls.Add(this.btnMenu);
            this.Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titulo.Location = new System.Drawing.Point(250, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(950, 50);
            this.Titulo.TabIndex = 10;
            this.Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titulo_MouseDown);
            // 
            // PainelFilhos
            // 
            this.PainelFilhos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PainelFilhos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PainelFilhos.Location = new System.Drawing.Point(250, 50);
            this.PainelFilhos.Name = "PainelFilhos";
            this.PainelFilhos.Size = new System.Drawing.Size(950, 600);
            this.PainelFilhos.TabIndex = 11;
            // 
            // iconeMinimizar
            // 
            this.iconeMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconeMinimizar.Image = global::VENDAS.Properties.Resources.minus;
            this.iconeMinimizar.Location = new System.Drawing.Point(855, 12);
            this.iconeMinimizar.Name = "iconeMinimizar";
            this.iconeMinimizar.Size = new System.Drawing.Size(25, 25);
            this.iconeMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconeMinimizar.TabIndex = 3;
            this.iconeMinimizar.TabStop = false;
            this.iconeMinimizar.Click += new System.EventHandler(this.iconeMinimizar_Click);
            // 
            // iconeRestaurar
            // 
            this.iconeRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconeRestaurar.Image = global::VENDAS.Properties.Resources.seo_and_web;
            this.iconeRestaurar.Location = new System.Drawing.Point(886, 13);
            this.iconeRestaurar.Name = "iconeRestaurar";
            this.iconeRestaurar.Size = new System.Drawing.Size(25, 25);
            this.iconeRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconeRestaurar.TabIndex = 2;
            this.iconeRestaurar.TabStop = false;
            this.iconeRestaurar.Visible = false;
            this.iconeRestaurar.Click += new System.EventHandler(this.iconeRestaurar_Click);
            // 
            // iconeMaximizar
            // 
            this.iconeMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconeMaximizar.Image = global::VENDAS.Properties.Resources.rectangle;
            this.iconeMaximizar.Location = new System.Drawing.Point(886, 13);
            this.iconeMaximizar.Name = "iconeMaximizar";
            this.iconeMaximizar.Size = new System.Drawing.Size(25, 25);
            this.iconeMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconeMaximizar.TabIndex = 1;
            this.iconeMaximizar.TabStop = false;
            this.iconeMaximizar.Click += new System.EventHandler(this.iconeMaximizar_Click);
            // 
            // iconeFechar
            // 
            this.iconeFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconeFechar.Image = global::VENDAS.Properties.Resources.logout;
            this.iconeFechar.Location = new System.Drawing.Point(917, 13);
            this.iconeFechar.Name = "iconeFechar";
            this.iconeFechar.Size = new System.Drawing.Size(25, 25);
            this.iconeFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconeFechar.TabIndex = 0;
            this.iconeFechar.TabStop = false;
            this.iconeFechar.Click += new System.EventHandler(this.iconeFechar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Image = global::VENDAS.Properties.Resources.menu;
            this.btnMenu.Location = new System.Drawing.Point(6, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(35, 35);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnRelProduto
            // 
            this.btnRelProduto.FlatAppearance.BorderSize = 0;
            this.btnRelProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRelProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelProduto.Font = new System.Drawing.Font("Garamond", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelProduto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRelProduto.Image = global::VENDAS.Properties.Resources.paper__1_;
            this.btnRelProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelProduto.Location = new System.Drawing.Point(0, 339);
            this.btnRelProduto.Name = "btnRelProduto";
            this.btnRelProduto.Size = new System.Drawing.Size(250, 40);
            this.btnRelProduto.TabIndex = 6;
            this.btnRelProduto.Text = "&Relatorio Prod";
            this.btnRelProduto.UseVisualStyleBackColor = true;
            this.btnRelProduto.Click += new System.EventHandler(this.btnRelProduto_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRelatorio.Image = global::VENDAS.Properties.Resources.paper__1_;
            this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio.Location = new System.Drawing.Point(3, 293);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(250, 40);
            this.btnRelatorio.TabIndex = 5;
            this.btnRelatorio.Text = "&Relatorio Cli";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.FlatAppearance.BorderSize = 0;
            this.btnCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompra.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompra.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCompra.Image = global::VENDAS.Properties.Resources.supermarket;
            this.btnCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompra.Location = new System.Drawing.Point(3, 242);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(250, 45);
            this.btnCompra.TabIndex = 4;
            this.btnCompra.Text = "&Compra";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click_1);
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.FlatAppearance.BorderSize = 0;
            this.btnFornecedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedores.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedores.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFornecedores.Image = global::VENDAS.Properties.Resources.icons8_usuário_masculino_26;
            this.btnFornecedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFornecedores.Location = new System.Drawing.Point(3, 191);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(250, 45);
            this.btnFornecedores.TabIndex = 3;
            this.btnFornecedores.Text = "&Fornecedores";
            this.btnFornecedores.UseVisualStyleBackColor = true;
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProdutos.Image = global::VENDAS.Properties.Resources.icons8_caixa_24;
            this.btnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.Location = new System.Drawing.Point(3, 158);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(250, 40);
            this.btnProdutos.TabIndex = 2;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click_1);
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClientes.Image = global::VENDAS.Properties.Resources.icons8_usuário_masculino_26;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 112);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(250, 40);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VENDAS.Properties.Resources.internet;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSobre
            // 
            this.btnSobre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSobre.FlatAppearance.BorderSize = 0;
            this.btnSobre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSobre.Location = new System.Drawing.Point(0, 607);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(250, 40);
            this.btnSobre.TabIndex = 7;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.PainelFilhos);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.MenuVertical);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.MenuVertical.ResumeLayout(false);
            this.Titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconeMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel Titulo;
        private System.Windows.Forms.Panel PainelFilhos;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox iconeFechar;
        private System.Windows.Forms.PictureBox iconeMinimizar;
        private System.Windows.Forms.PictureBox iconeRestaurar;
        private System.Windows.Forms.PictureBox iconeMaximizar;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Button btnFornecedores;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnRelProduto;
        private System.Windows.Forms.Button btnSobre;
    }
}