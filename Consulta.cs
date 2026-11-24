public class Consulta
{
    public string Especialidade { get; set; }
    public decimal Preco { get; set; }

    public Consulta(string especialidade, decimal preco)
    {
        Especialidade = especialidade;
        Preco = preco;
    }
}
