﻿using Azure;
using Azure.Data.Tables;

namespace UpdateTableEntity
{
    public class Order : ITableEntity
    {
        public string OrderId { get; set; }
        public string Category { get; set; }

        public int Quantity { get; set; }
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }
    }
}
