namespace AssignmentC4.Repositories.Interface;

public interface GenericInterface<T>
{
    IEnumerable<T> GetAll();
    Task AddAsync(T entity);
    Task Update(T entity);
    Task Delete(T entity);
}