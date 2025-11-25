
class MaquinaDAO : IDAO<Maquina>
{
    private AgroSolutionContext context = new AgroSolutionContext();
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
        Maquina maquina = null;
        maquina = context.Maquinas.FirstOrDefault(x => x.Id == id);
        return maquina;
    }

    public List<Maquina> ObterTodos()
    {
        return context.Maquinas.ToList();
    }

    public void Remover(Maquina objeto)
    {
        context.Maquinas.Remove(objeto);
        context.SaveChanges();
    }
}