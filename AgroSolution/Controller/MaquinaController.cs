
public class MaquinaController : IController<Maquina>
{
    private MaquinaDAO Dao = new MaquinaDAO();
    public void Adicionar(Maquina objeto)
    {
        Dao.Adicionar(objeto);
    }

    public void Editar(Maquina objeto)
    {
        Dao.Editar(objeto);
    }

    public Maquina ObterPorId(int id)
    {
        return Dao.ObterPorId(id);
    }

    public List<Maquina> ObterTodos()
    {
        List<Maquina> maquinas = Dao.ObterTodos();
        return maquinas;
    }

    public void Remover(Maquina objeto)
    {
        Dao.Remover(objeto);
    }
}