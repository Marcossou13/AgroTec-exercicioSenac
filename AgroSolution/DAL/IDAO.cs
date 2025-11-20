interface IDAO <T>
{
    public List<T> ObterTodos();
    public T ObterPorId(int id);
    public void Adicionar(T objeto);
    public void Remover(T objeto);
    public void Editar(T objeto);
}