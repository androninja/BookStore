namespace BookStore.Services
{
    public interface IBaseRepository<T>
    {
        T Create(T entity);
        T Update(T entity);
        T Delete(int? id);
        T Get(int? id);

        //want to show the number of books avaialble in our library
        List<T> GetAll();
    }
}
