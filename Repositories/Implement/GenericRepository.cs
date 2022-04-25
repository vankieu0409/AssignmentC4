using AssignmentC4.DbContext;
using AssignmentC4.Repositories.Interface;

namespace AssignmentC4.Repositories.Implement;

public class GenericRepository<T> : GenericInterface<T> where T : class
{
    private readonly ApplicationDbContext _context;

    public GenericRepository(ApplicationDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }
    public IEnumerable<T> GetAll()
    {
        return _context.Set<T>();
    }

    public async Task AddAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        try
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            throw new ApplicationException(e.Message);
        }

    }

    public async Task DeleteAsync(T entity)
    {
        try
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            throw new ApplicationException(e.Message);
        }

    }
}