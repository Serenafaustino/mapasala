using Model.Entidades;
using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace mapasala.DAO
{
    public class ProfessorDAO
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public ProfessorDAO()
        {
            Conexao = new SqlConnection(LinhaConexao); 
        }
        public void Inserir(ProfessoresEntidade professor)
        {
            Conexao.Open();
            string query = "Insert into Professores(Nome, Apelido) values(@nome, @apelido)";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@nome", professor.Nome);
            SqlParameter parametro2 = new SqlParameter("@apelido", professor.Apelido);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }

        public DataTable ObterProfessores()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "SELECT Id, Nome, Apelido FROM Professores Order by Id desc";
            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlDataReader Leitura = comando.ExecuteReader();
            foreach(var atributos in typeof(ProfessoresEntidade).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }
            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    ProfessoresEntidade Professor = new ProfessoresEntidade();
                    Professor.Id = Convert.ToInt32(Leitura[0]);
                    Professor.Nome = Leitura[1].ToString();
                    Professor.Apelido = Leitura[2].ToString();
                    dt.Rows.Add(Professor.Linha());
                }
            }

            return dt;
        }
    }
}
