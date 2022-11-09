using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto_cbanco.Model;

namespace projeto_cbanco.View
{
    public partial class FrmCategorias : Form
    {
        Categorias c;
        public FrmCategorias()
        {
            InitializeComponent();
        }
        void limpaControles()
        {
            textID.Clear();
            txtCategoria.Clear();
            
            txtPesquisa.Clear();
        }

        void carregarGrid(string pesquisa)
        {
            c = new Categorias()

            {
                categoria = pesquisa
            };
            dgvCategorias.DataSource = c.Consultar();

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text == String.Empty) return;

            c = new Categorias()
            {
                categoria = txtCategoria.Text
                
            };
            c.Incluir();

            limpaControles();
            carregarGrid("");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (textID.Text == String.Empty) return;

            c = new Categorias()
            {
                id = int.Parse(textID.Text),
                categoria = txtCategoria.Text
                
            };
            c.Alterar();

            limpaControles();
            carregarGrid("");
        }

        private void btnLixo_Click(object sender, EventArgs e)
        {
            if (textID.Text == "") return;

            if (MessageBox.Show("Deseja excluir a categoria?", "Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c = new Categorias()
                {
                    id = int.Parse(textID.Text)
                };
                c.Excluir();

                limpaControles();
                carregarGrid("");
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisa.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategorias.RowCount > 0)
            {
                textID.Text = dgvCategorias.CurrentRow.Cells["id"].Value.ToString();
                txtCategoria.Text = dgvCategorias.CurrentRow.Cells["categoria"].Value.ToString();
                
            }
        }
    }
}
