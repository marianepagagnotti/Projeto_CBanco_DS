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
    internal class Marcas
    {
        public int id { get; set; }

        public string marca { get; set; }

        

        public void Incluir()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Comando = new MySqlCommand("INSERT INTO marcas (marca) VALUES (@marca)", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@marca", marca);

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

                Banco.Comando = new MySqlCommand("UPDATE marcas SET marca=@marca WHERE id=@id", Banco.Conexao);


                Banco.Comando.Parameters.AddWithValue("@id", id);

                Banco.Comando.Parameters.AddWithValue("@marca", marca);

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

                Banco.Comando = new MySqlCommand("DELETE FROM marcas WHERE id=@id", Banco.Conexao);


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

                Banco.Comando = new MySqlCommand("SELECT * FROM marcas WHERE marca LIKE @marca" + " order by marca", Banco.Conexao);


                Banco.Comando.Parameters.AddWithValue("@marca", marca + "%");


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
