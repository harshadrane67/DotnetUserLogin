using MongoDB.Driver;
using Microsoft.Extensions.Configuration;
using SocialMedia.Core.Entities;

namespace SocialMedia.Data;

public class MongoDBContext
{
    private readonly IMongoDatabase _database;
    public MongoDBContext(IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("MongoDB");
        var client = new MongoClient(connectionString);
        _database = client.GetDatabase("Project-X");
    }

    public IMongoCollection<User> UserCollection => _database.GetCollection<User>("User");

}