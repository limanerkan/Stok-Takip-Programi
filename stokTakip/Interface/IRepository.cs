using System.Data;


namespace dernekProje.Interface
{
    public interface IRepository<T> where T : class
    {
        void Add(T something);
        void Delete(int id);
        DataSet ListAll();
        void Update(T something, int id);
    }
}
