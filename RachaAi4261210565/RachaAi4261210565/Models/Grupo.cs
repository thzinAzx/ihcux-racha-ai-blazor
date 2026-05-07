namespace RachaAi4261210565.Models;

public class Grupo
{
    public string Nome { get; set; } = string.Empty;
    public string Categoria { get; set; } = string.Empty;
    public decimal ValorPendente { get; set; }
    public bool NoVermelho { get; set; }
}