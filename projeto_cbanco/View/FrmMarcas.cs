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
    public partial class FrmMarcas : Form
    {
        Marcas m;
        public FrmMarcas()
        {
            InitializeComponent();
        }
        
        void limpaControles()
        {
            txtCodigo.Clear();
            txtmarca.Clear();
            
            txtPesquisa.Clear();
        }

        void carregarGrid(string pesquisa)
        {
            m = new Marcas()

            {
                marca = pesquisa
            };
            dgvMarcas.DataSource = m.Consultar();

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtmarca.Text == String.Empty) return;

            m = new Marcas()
            {
                marca = txtmarca.Text
                
            };
            m.Incluir();

            limpaControles();
            carregarGrid("");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == String.Empty) return;

            m = new Marcas()
            {
                id = int.Parse(txtCodigo.Text),
                marca = txtmarca.Text
                
            };
            m.Alterar();

            limpaControles();
            carregarGrid("");
        }

        private void btnLixo_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "") return;

            if (MessageBox.Show("Deseja excluir a marca?", "Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                m = new Marcas()
                {
                    id = int.Parse(txtCodigo.Text)
                };
                m.Excluir();

                limpaControles();
                carregarGrid("");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisa.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void dgvMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMarcas.RowCount > 0)
            {
                txtCodigo.Text = dgvMarcas.CurrentRow.Cells["id"].Value.ToString();
                txtmarca.Text = dgvMarcas.CurrentRow.Cells["marca"].Value.ToString();
                
            }
        }
    }
}
