using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace projeto_cbanco.Model
{
    public class Categorias
    {
        public int id { get; set; }

        public string categoria { get; set; }
        public void Incluir()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Comando = new MySqlCommand("INSERT INTO categorias (categoria) VALUES (@categoria)", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@categoria", categoria);

                

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

                Banco.Comando = new MySqlCommand("UPDATE categorias SET categoria=@categoria WHERE id=@id", Banco.Conexao);


                Banco.Comando.Parameters.AddWithValue("@id", id);

                Banco.Comando.Parameters.AddWithValue("@categoria", categoria);

                

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

                Banco.Comando = new MySqlCommand("DELETE FROM categorias WHERE id=@id", Banco.Conexao);


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

                Banco.Comando = new MySqlCommand("SELECT * FROM categorias WHERE categoria LIKE @categoria" + " order by categoria", Banco.Conexao);


                Banco.Comando.Parameters.AddWithValue("@categoria", categoria + "%");


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
