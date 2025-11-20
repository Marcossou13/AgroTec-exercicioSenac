
class MaquinaDAO : IDAO<Maquina>
{
    private AgroSolutionContext context;
    public void Adicionar(Maquina objeto)
    {
        context.Maquinas.Add(objeto);
        context.SaveChanges();
    }

    public void Editar(Maquina objeto)
    {
        context.Maquinas.Update(objeto);
        context.SaveChanges();
    }

    public Maquina ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public List<Maquina> ObterTodos()
    {
        throw new NotImplementedException();
    }

    public void Remover(Maquina objeto)
    {
        throw new NotImplementedException();
    }
}