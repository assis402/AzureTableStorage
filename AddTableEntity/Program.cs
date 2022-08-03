using Azure.Data.Tables;

var connectionString = "DefaultEndpointsProtocol=https;AccountName=storageaccassis204;AccountKey=nupkX1VHcPNXvPBgzNRWOAA4m18tSSAAWy8c33PAxxgx5WAShWg7C/2xXb3xfLqy/Fe4jL3C/aVu+ASt0vXqxg==;EndpointSuffix=core.windows.net";
var tableName = "Orders";

AddEntity("01", "Mobile", 100);
AddEntity("02", "Laptop", 100);
AddEntity("03", "Desktop", 70);
AddEntity("04", "Laptop", 200);

void AddEntity(string orderId, string category, int quantity)
{
    var tableClient = new TableClient(connectionString, tableName);
    var tableEntity = new TableEntity(category, orderId)
    {
        { "quantity", quantity }
    };

    tableClient.AddEntity(tableEntity);
    Console.WriteLine("Added Entity with order Id {0}", orderId);
}