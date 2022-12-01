using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
public class CustomerOrder
{
    [BsonId]
     [BsonRepresentation(BsonType.ObjectId)]
    public string? ID{get;set;}
    public long Customer_ID{get;set;}
    public long Order_ID{get;set;}
    public DateTime Added_On{get;set;}
    public string Added_By{get;set;}
    public string Added_By_IP{get;set;}
}