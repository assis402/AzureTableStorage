using Azure.Data.Tables;

var connectionString = "DefaultEndpointsProtocol=https;AccountName=storageaccassis204;AccountKey=nupkX1VHcPNXvPBgzNRWOAA4m18tSSAAWy8c33PAxxgx5WAShWg7C/2xXb3xfLqy/Fe4jL3C/aVu+ASt0vXqxg==;EndpointSuffix=core.windows.net";
var tableName = "Orders";

QueryEntity("Laptop");

void QueryEntity(string category)
{
    var tableClient = new TableClient(connectionString, tableName);
    var entities = tableClient.Query<TableEntity>(entity => entity.PartitionKey == category);

    foreach (var entity in entities)
    {
        Console.WriteLine("Order Id {0}", entity.RowKey);
        Console.WriteLine("Quantity is {0}", entity.GetInt32("quantity"));
    }
}