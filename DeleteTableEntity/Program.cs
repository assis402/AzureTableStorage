using Azure.Data.Tables;

var connectionString = "DefaultEndpointsProtocol=https;AccountName=storageaccassis204;AccountKey=nupkX1VHcPNXvPBgzNRWOAA4m18tSSAAWy8c33PAxxgx5WAShWg7C/2xXb3xfLqy/Fe4jL3C/aVu+ASt0vXqxg==;EndpointSuffix=core.windows.net";
var tableName = "Orders";

DeleteEntity("Laptop", "02");

void DeleteEntity(string category, string orderId)
{
    var tableClient = new TableClient(connectionString, tableName);
    tableClient.DeleteEntity(category, orderId);

    Console.WriteLine("The Entity is deleted");
}