using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace MongoDB.Services;

public class CustomerOrdersService
{
    private readonly IMongoCollection<CustomerOrder> _booksCollection;

    public CustomerOrdersService(
        IOptions<DbOptions> dbOptions)
    {
        var mongoClient = new MongoClient(
            dbOptions.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            dbOptions.Value.DatabaseName);

        _booksCollection = mongoDatabase.GetCollection<CustomerOrder>(
            dbOptions.Value.CustomerOrdersCollectionName);
    }
    public async Task<List<CustomerOrder>> GetAsync() =>
        await _booksCollection.Find(_ => true).ToListAsync();

    public async Task<CustomerOrder?> GetAsync(string id) =>
        await _booksCollection.Find(x => x.ID == id).FirstOrDefaultAsync();

    public async Task CreateAsync(CustomerOrder obj) =>
        await _booksCollection.InsertOneAsync(obj);

    public async Task UpdateAsync(string id, CustomerOrder updatedBook) =>
        await _booksCollection.ReplaceOneAsync(x => x.ID == id, updatedBook);

    public async Task RemoveAsync(string id) =>
        await _booksCollection.DeleteOneAsync(x => x.ID == id);
}