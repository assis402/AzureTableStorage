using Azure;
using Azure.Data.Tables;
using UpdateTableEntity;

var connectionString = "DefaultEndpointsProtocol=https;AccountName=storageaccassis204;AccountKey=nupkX1VHcPNXvPBgzNRWOAA4m18tSSAAWy8c33PAxxgx5WAShWg7C/2xXb3xfLqy/Fe4jL3C/aVu+ASt0vXqxg==;EndpointSuffix=core.windows.net";
var tableName = "Orders";

UdateEntity("Mobile", "01");

void UdateEntity(string category, string orderId)
{
    var tableClient = new TableClient(connectionString, tableName);

    var entity = tableClient.GetEntity<Order>(category, orderId);

    entity.Value.Quantity = 20;

    tableClient.UpdateEntity<Order>(entity, ETag.All, TableUpdateMode.Replace);

    Console.WriteLine("The Entity is updated");
}