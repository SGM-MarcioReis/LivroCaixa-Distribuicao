namespace ControleFinanceiroWeb.Models;

public class Entidade
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string NomeFantasia { get; set; } = string.Empty;
    public string CNPJ { get; set; } = string.Empty;
    public string Presidente { get; set; } = string.Empty;
    public string Tesoureiro { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Cidade { get; set; } = string.Empty;
}
