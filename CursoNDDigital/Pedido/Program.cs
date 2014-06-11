using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Pedido
{
    class Program
    {
        private static void Main(string[] args)
        {
            //INICIA CONEXÃO
            var sqlConection = ConectandoComBanco();

            //REALIZA COMANDOS
            C_AdicionaProduto(sqlConection); //CREATE DATA
            R_ListaTodosProdutos(sqlConection); //READ DATA
            U_AtualizaProduto(sqlConection); // UPDATE DATA
            D_ExcluiProduto(sqlConection); //DELETE DATA

            //FECHA CONEXÃO
            FechaConexao(sqlConection);
        }

        private static void C_AdicionaProduto(SqlConnection sqlConection)
        {
            string nome = Console.ReadLine();
            string unidade = Console.ReadLine();
            double valor = Convert.ToDouble(Console.ReadLine());
            string nvalor = valor.ToString().Replace(',','.');

         
            //Listando todos o intens na tabela produto
            string sql = String.Format(@"INSERT INTO Produto (Nome, Unidade, Valor) VALUES('{0}','{1}',{2:.##})", nome,
                unidade, nvalor);
            SqlCommand insert = new SqlCommand(sql, sqlConection);

            try
            {
                int i = insert.ExecuteNonQuery();
                if (i > 0)
                {
                    Console.WriteLine("Cadastro inserido com sucesso!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.ToString()); // Irá mostrar para nós a exceção
            }
        }

        private static void R_ListaTodosProdutos(SqlConnection sqlConection)
        {
            //Listando todos o intens na tabela produto
            SqlCommand select = new SqlCommand("SELECT * FROM Produto", sqlConection);
            SqlDataReader dataReader = @select.ExecuteReader();

            while (dataReader.Read())
            {
                Console.WriteLine(dataReader["Nome"]);
            }
        }

        private static void U_AtualizaProduto(SqlConnection sqlConection)
        {
            //Executa a consulta e não retorna nenhuma coleção. Usado para instruções DELETE e UPDATE onde retorna o número de registros afetados.
            SqlCommand update = new SqlCommand("Update Produto set Nome = 'Melancia' WHERE Id=2", sqlConection);

            try
            {
                int j = update.ExecuteNonQuery();
                if (j > 0)
                {
                    Console.WriteLine("Cadastro atualizado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.ToString()); // Irá mostrar para nós a exceção
            }
        }

        private static void D_ExcluiProduto(SqlConnection sqlConection)
        {
            //Executa a consulta e não retorna nenhuma coleção. Usado para instruções DELETE e UPDATE onde retorna o número de registros afetados.
            SqlCommand delete = new SqlCommand("DELETE FROM Produto WHERE Id=1", sqlConection);
            delete.ExecuteNonQuery();
        }

        private static void FechaConexao(SqlConnection sqlConection)
        {
            //Fecha a conexão
            sqlConection.Close();
        }

        private static SqlConnection ConectandoComBanco()
        {
            //Define uma string de conexão com o banco de dados CursoNDD.mdf
            string connectionString =
                @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Thiago\Source\Repos\CursoNDDigital\CursoNDDigital\UNIDADE XII\Banco\CursoDB.mdf;Integrated Security=True";

            //Cria um novo objeto SqlConnection object usando a string de conexão
            SqlConnection sqlConn = new SqlConnection(connectionString);

            //Abre a conexão
            sqlConn.Open();
            return sqlConn;
        }
    }
}
