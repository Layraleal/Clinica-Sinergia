public static class Ordenacao
{
    public static void Ordenar(List<Consulta> lista, bool crescente)
    {
        for (int i = 0; i < lista.Count - 1; i++)
        {
            int posicao = i;
            for (int j = i + 1; j < lista.Count; j++)
            {
                if (crescente ? lista[j].Preco < lista[posicao].Preco
                             : lista[j].Preco > lista[posicao].Preco)
                    posicao = j;
            }

            Consulta auxiliar = lista[i];
            lista[i] = lista[posicao];
            lista[posicao] = auxiliar;
        }
    }
}
