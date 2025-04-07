using Domain;
using SQLite;

namespace Infrastructure;
public class IncomingRepository
{
    private readonly SQLiteAsyncConnection _database;

    public IncomingRepository(string dbPath)
    {
        _database = new SQLiteAsyncConnection(dbPath);
        _database.CreateTableAsync<Incoming>().Wait();
    }

    public Task<List<Incoming>> GetListAsync()
    {
        return _database.Table<Incoming>().ToListAsync();
    }

    public Task<int> AddAsync(Incoming item)
    {
        return _database.InsertAsync(item);
    }

    public Task<int> DeleteAsync(Incoming Incoming)
    {
        return _database.DeleteAsync(Incoming);
    }
}
