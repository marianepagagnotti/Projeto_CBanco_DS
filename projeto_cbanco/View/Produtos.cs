using projeto_cbanco.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_cbanco.View
{
    public partial class FrmProduto : Form
    {
        Marcas m;
        Categorias c;
        Produto p;
        public FrmProduto()
        {
            InitializeComponent();
        }

        void limpaControles()
        {
            txtID.Clear();
            txtDescricao.Clear();
            cboCategoria.SelectedIndex = -1;
            cboMarca.SelectedIndex = -1;
            txtVenda.Clear();
            txtEstoque.Clear();
            picFoto.ImageLocation = "";
            
        }

        void carregarGrid(string pesquisa)
        {
            p = new Produto()

            {
                descricao = pesquisa
            };
            dgvProdutos.DataSource = p.Consultar();

        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {

            if (txtDescricao.Text == "") return;

            p = new Produto()
            {
                descricao = txtDescricao.Text,
                idCategoria = (int)cboCategoria.SelectedValue,
                idMarca = (int)cboMarca.SelectedValue,
                estoque = double.Parse(txtEstoque.Text),
                foto = picFoto.ImageLocation,
                
            };

            p.Incluir();

            limpaControles();
            carregarGrid("");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;

            p = new Produto()
            {
                id = int.Parse(txtID.Text),
                descricao = txtDescricao.Text,
                idCategoria = (int)cboCategoria.SelectedValue,
                idMarca = (int)cboMarca.SelectedValue,
                estoque = double.Parse(txtEstoque.Text),
                valorVenda = double.Parse(txtVenda.Text),
                foto = picFoto.ImageLocation,
                
            };
            p.Alterar();

            limpaControles();
            carregarGrid("");
        }

        private void btnLixo_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;

            if (MessageBox.Show("Deseja excluir o produto?", "Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                p = new Produto()
                {
                    id = int.Parse(txtID.Text)
                };
                p.Excluir();

                limpaControles();
                carregarGrid("");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisa.Text);
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProdutos.RowCount > 0)
            {
                txtID.Text = dgvProdutos.CurrentRow.Cells["id"].Value.ToString();
                txtDescricao.Text = dgvProdutos.CurrentRow.Cells["nome"].Value.ToString();
                cboCategoria.Text = dgvProdutos.CurrentRow.Cells["categoria"].Value.ToString();
                cboMarca.Text = dgvProdutos.CurrentRow.Cells["marca"].Value.ToString();
                txtVenda.Text = dgvProdutos.CurrentRow.Cells["valorVenda"].Value.ToString();
                txtEstoque.Text = dgvProdutos.CurrentRow.Cells["estoque"].Value.ToString();
                picFoto.ImageLocation = dgvProdutos.CurrentRow.Cells["foto"].Value.ToString();
            }
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            ofdArquivo.InitialDirectory = "D:/fotos/produtos/";
            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();
            picFoto.ImageLocation = ofdArquivo.FileName;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
