using DevIO.IntroducaoEfCore.App.ValueObjects;

namespace DevIO.IntroducaoEfCore.App.Domain;

public class Produto
{
    public int Id { get; set; }
    public string CodigoBarras { get; set; }
    public string Descricao { get; set; }
    public decimal Valor { get; set; }
    public TipoProduto TipoProduto { get; set; }
    public bool Ativo { get; set; }
}