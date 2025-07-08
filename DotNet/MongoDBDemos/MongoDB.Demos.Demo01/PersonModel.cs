using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDB.Demos.Demo01
{
    public class PersonModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("gender")]
        public string Gender { get; set; }

        [BsonElement("name")]
        public Name Name { get; set; }

        [BsonElement("location")]
        public Location Location { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("login")]
        public Login Login { get; set; }

        [BsonElement("dob")]
        public DateInfo Dob { get; set; }

        [BsonElement("registered")]
        public DateInfo Registered { get; set; }

        [BsonElement("phone")]
        public string Phone { get; set; }

        [BsonElement("cell")]
        public string Cell { get; set; }

        [BsonElement("id")]
        public IdInfo IdInfo { get; set; }

        [BsonElement("picture")]
        public Picture Picture { get; set; }

        [BsonElement("nat")]
        public string Nationality { get; set; }

        public override string ToString() =>
            System.Text.Json.JsonSerializer.Serialize(this);

    }

    public class Name
    {
        [BsonElement("title")]
        public string Title { get; set; }

        [BsonElement("first")]
        public string First { get; set; }

        [BsonElement("last")]
        public string Last { get; set; }

        public override string ToString() =>
            System.Text.Json.JsonSerializer.Serialize(this);
    }

    
    public class Location
    {
        [BsonElement("street")]
        public string Street { get; set; }

        [BsonElement("city")]
        public string City { get; set; }

        [BsonElement("state")]
        public string State { get; set; }

        [BsonElement("postcode")]
        public int Postcode { get; set; }

        [BsonElement("coordinates")]
        public Coordinates Coordinates { get; set; }

        [BsonElement("timezone")]
        public Timezone Timezone { get; set; }

        public override string ToString() =>
            System.Text.Json.JsonSerializer.Serialize(this);
    }

    public class Coordinates
    {
        [BsonElement("latitude")]
        public string Latitude { get; set; }

        [BsonElement("longitude")]
        public string Longitude { get; set; }

        public override string ToString() =>
            System.Text.Json.JsonSerializer.Serialize(this);
    }

    public class Timezone
    {
        [BsonElement("offset")]
        public string? Offset { get; set; }

        [BsonElement("description")]
        public string? Description { get; set; }

        public override string ToString() =>
            System.Text.Json.JsonSerializer.Serialize(this);
    }

    public class Login
    {
        [BsonElement("uuid")]
        public string? Uuid { get; set; }

        [BsonElement("username")]
        public string? Username { get; set; }

        [BsonElement("password")]
        public string? Password { get; set; }

        [BsonElement("salt")]
        public string? Salt { get; set; }

        [BsonElement("md5")]
        public string? Md5 { get; set; }

        [BsonElement("sha1")]
        public string? Sha1 { get; set; }

        [BsonElement("sha256")]
        public string? Sha256 { get; set; }

        public override string ToString() =>
            System.Text.Json.JsonSerializer.Serialize(this);
    }

    public class DateInfo
    {
        [BsonElement("date")]
        public DateTime Date { get; set; }

        [BsonElement("age")]
        public int Age { get; set; }

        public override string ToString() =>
            System.Text.Json.JsonSerializer.Serialize(this);
    }

    public class IdInfo
    {
        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("value")]
        public string? Value { get; set; }  // can be null

        public override string ToString() =>
            System.Text.Json.JsonSerializer.Serialize(this);
    }

    public class Picture
    {
        [BsonElement("large")]
        public string? Large { get; set; }

        [BsonElement("medium")]
        public string? Medium { get; set; }

        [BsonElement("thumbnail")]
        public string? Thumbnail { get; set; }

        public override string ToString() =>
            System.Text.Json.JsonSerializer.Serialize(this);
    }


}
