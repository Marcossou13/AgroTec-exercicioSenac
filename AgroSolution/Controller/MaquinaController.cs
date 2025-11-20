
class MaquinaController : IController<Maquina>
{
    private MaquinaDAO dao;
    public void Adicionar(Maquina objeto)
    {
        dao.Adicionar(objeto);
    }

    public void Editar(Maquina objeto)
    {
        dao.Editar(objeto);
    }

    public Maquina ObterPorId(int id)
    {
        return dao.ObterPorId(id);
    }

    public List<Maquina> ObterTodos()
    {
        return dao.ObterTodos();
    }

    public void Remover(Maquina objeto)
    {
        dao.Remover(objeto);
    }
}