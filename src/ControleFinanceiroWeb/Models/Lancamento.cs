namespace ControleFinanceiroWeb.Models;

public class Lancamento
{
    public int Id { get; set; }
    public DateTime DataLancamento { get; set; } = DateTime.Today;
    public string Tipo { get; set; } = "ENTRADA";
    public string Categoria { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public decimal Valor { get; set; }
    public string? Natureza { get; set; }
    public string? FonteRecurso { get; set; }
}
