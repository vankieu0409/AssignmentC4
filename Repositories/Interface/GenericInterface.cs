namespace AssignmentC4.Repositories.Interface;

public interface GenericInterface<T>
{
    IEnumerable<T> GetAll();
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}