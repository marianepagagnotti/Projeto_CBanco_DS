using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_cbanco.Model
{
    public class Produto
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public int idCategoria { get; set; }
        public int idMarca { get; set; }
        public double estoque { get; set; }
        public double valorVenda { get; set; }
        public string foto { get; set; }


        public void Incluir()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Comando = new MySqlCommand("INSERT INTO produtos (descricao, idCategoria, idMarca, estoque, valorVenda, foto) " +
                    "VALUES (@descricao, @idCategoria, @idMarca, @estoque, @valorVenda, @foto)", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@descricao", descricao);
                Banco.Comando.Parameters.AddWithValue("@idCategoria", idCategoria);
                Banco.Comando.Parameters.AddWithValue("@idMarca", idMarca);
                Banco.Comando.Parameters.AddWithValue("@estoque", estoque);
                Banco.Comando.Parameters.AddWithValue("@valorVenda", valorVenda);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);
                


                Banco.Comando.ExecuteNonQuery();

                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Alterar()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Comando = new MySqlCommand("UPDATE produtos SET (descricao = @descricao, idCategoria = @idCategoria, idMarca = @idMarca ," +
                    " estoque = @estoque, valorVenda = @valorVenda , foto = @foto WHERE id = @id ", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@descricao", descricao);
                Banco.Comando.Parameters.AddWithValue("@idCategoria", idCategoria);
                Banco.Comando.Parameters.AddWithValue("@idMarca", idMarca);
                Banco.Comando.Parameters.AddWithValue("@estoque", estoque);
                Banco.Comando.Parameters.AddWithValue("@valorVenda", valorVenda);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);
                Banco.Comando.Parameters.AddWithValue("@id", id);


                Banco.Comando.ExecuteNonQuery();

                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Excluir()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Comando = new MySqlCommand("DELETE FROM produtos WHERE id=@id", Banco.Conexao);


                Banco.Comando.Parameters.AddWithValue("@id", id);


                Banco.Comando.ExecuteNonQuery();

                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable Consultar()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Comando = new MySqlCommand("SELECT p.*, m.marca, c.categoria FROM " +
                    "Produtos p inner join Marcas m on (m.id = p.idMarca)" +
                    " inner join Categorias c on (c.id = c.idCategoria)" +
                    "where p.descricao like @descricao order by p.descricao", Banco.Conexao);


                Banco.Comando.Parameters.AddWithValue("@descricao", descricao + "%");


                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.datTabela = new DataTable();
                Banco.Adaptador.Fill(Banco.datTabela);
                Banco.FecharConexao();
                return Banco.datTabela;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }
        }

    }
}
