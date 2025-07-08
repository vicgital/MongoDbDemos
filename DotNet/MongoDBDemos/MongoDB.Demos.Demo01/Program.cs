using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Demos.Demo01;


var dbUserName = Environment.GetEnvironmentVariable("MONGODB_USERNAME");
var dbPassword = Environment.GetEnvironmentVariable("MONGODB_PASSWORD");
string username = Uri.EscapeDataString($"{dbUserName}");
string password = Uri.EscapeDataString($"{dbPassword}");

string connectionUri = $"mongodb+srv://{username}:{password}@vicgitalmongodbcluster.jsgjkh4.mongodb.net/?retryWrites=true&w=majority&appName=MongoDB.Demos.Demo01";
var settings = MongoClientSettings.FromConnectionString(connectionUri);

// Create a new client and connect to the server
var client = new MongoClient(settings);
try
{
    var result = await client.ListDatabaseNamesAsync();
    Console.WriteLine("List Databases:");
    await result.ForEachAsync((database) => 
    {
        Console.WriteLine($"{database}");
    });


    var analyticsDatabase = client.GetDatabase("analytics");
    Console.WriteLine("List Collections in analytics databse/...:");
    var collctionNames = await analyticsDatabase.ListCollectionNamesAsync();
    await collctionNames.ForEachAsync((collection) => 
    {
        Console.WriteLine($"{collection}");
    });

    Console.WriteLine("\n\n\n");

    // Get a list of persons.
    var filter = Builders<BsonDocument>.Filter.Eq("gender", "female");

    var personsCollection = analyticsDatabase.GetCollection<BsonDocument>("persons");
    
    var personsCursor = await personsCollection.FindAsync<BsonDocument>(filter);
    var person = personsCursor.FirstOrDefault();

    Console.WriteLine(person.ToJson());







}
catch (Exception ex)
{
    Console.WriteLine(ex);
}