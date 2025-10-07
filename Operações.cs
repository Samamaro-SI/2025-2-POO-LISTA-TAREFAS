public class Operacoes
{
    private string connectionString = "";
    public int Criar(Tarefa tarefa)
    {
        using(var conexao - new MySqlConection(connectionstring))
        {
            conexao.Open();
            string sql = @"INSERT INTO tarefa (nome, descricao, dataCriacao, status, dataExecucao)
                        VALUES (@nome, @descrição, @dataCriacao, @status, @dataExecucao);
                        SELECT LAST_INSERT_ID();";
            using (var cmd = new MySqlComand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@nome", tarefa.Nome);
                cmd.Parameters.AddWithValue("@descricao", tarefa.Descricao);
                cmd.Parameters.AddWithValue("@dataCriacao", tarefa.DataCriacao);
                cmd.Parameters.AddWithValue("@status", tarefa.Status);
                cmd.Parameters.AddWithValue("@dataExecucao", tarefa.DataExecucao);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }            

        }
        
    }

    public Tarefa Buscar (int id)    
    {
        return null;
    }
    public List<Terefa> Listar()
    {
        return Array.Empty<Tarefa>();
    }
    public void Alterar(Tarefa tarefa)
    {

    }
    public void Excluir(int id)
    {

    }
   
    
}