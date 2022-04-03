namespace AssignmentC4.Repositories.Interface;

public interface GenericInterface<T>
{
    IQueryable<T> GetAll();
    Task AddAsync(T entity);
    Task Update(T entity);
    Task Delete(T entity);
}