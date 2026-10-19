using System.IO;
using Microsoft.Data.Sqlite;

namespace ControleFinanceiroWeb.Data;

public static class ConexaoDB
{
    private static readonly string PastaBanco = Path.Combine(Directory.GetCurrentDirectory(), "App_Data");
    private static readonly string CaminhoBanco = Path.Combine(PastaBanco, "ControleFinanceiro.db");

    public static string ConnectionString => $"Data Source={CaminhoBanco};";

    public static void InicializarBanco()
    {
        if (!Directory.Exists(PastaBanco))
        {
            Directory.CreateDirectory(PastaBanco);
        }

        using var conn = new SqliteConnection(ConnectionString);
        conn.Open();

        string sqlLancamentos = @"
            CREATE TABLE IF NOT EXISTS Lancamentos (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                DataLancamento TEXT NOT NULL,
                Tipo TEXT NOT NULL CHECK(Tipo IN ('ENTRADA','SAÍDA')),
                Categoria TEXT NOT NULL,
                Descricao TEXT NOT NULL,
                Valor NUMERIC NOT NULL CHECK(Valor > 0),
                Natureza TEXT,
                FonteRecurso TEXT
            );";

        using (var cmd = new SqliteCommand(sqlLancamentos, conn))
        {
            cmd.ExecuteNonQuery();
        }

        string sqlEntidade = @"
            CREATE TABLE IF NOT EXISTS Entidade (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Nome TEXT NOT NULL,
                NomeFantasia TEXT,
                CNPJ TEXT,
                Presidente TEXT,
                Tesoureiro TEXT,
                Telefone TEXT,
                Email TEXT,
                Cidade TEXT
            );";

        using (var cmd = new SqliteCommand(sqlEntidade, conn))
        {
            cmd.ExecuteNonQuery();
        }
    }
}
