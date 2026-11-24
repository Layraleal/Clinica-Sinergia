public static class Selecao
{
    public static Consulta? Selecionar(List<Consulta> lista, bool maisBarata)
    {
        if (lista.Count == 0) return null;

        Consulta escolhida = lista[0];
        foreach (Consulta consulta in lista)
        {
            if (maisBarata ? consulta.Preco < escolhida.Preco
                          : consulta.Preco > escolhida.Preco)
                escolhida = consulta;
        }
        return escolhida;
    }
}
