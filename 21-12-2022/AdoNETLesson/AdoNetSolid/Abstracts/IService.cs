namespace AdoNetSolid.Abstracts
{
    public interface IService<T>
    {
        void Create(T model);
        void Update(int id);
        void Delete(int id);
        List<T> GetAll();
        T GetById(int id);
    }
}
