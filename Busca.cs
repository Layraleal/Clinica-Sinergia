public static class Busca
{
    public static Consulta? Buscar(List<Consulta> lista, string especialidade)
    {
        foreach (Consulta consulta in lista)
        {
            if (consulta.Especialidade.Equals(especialidade, StringComparison.OrdinalIgnoreCase))
                return consulta;
        }
        return null;
    }
}
