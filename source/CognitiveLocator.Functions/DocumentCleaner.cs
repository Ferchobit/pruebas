namespace CognitiveLocator.Functions
{
    public static class DocumentCleaner
    {
        //[FunctionName("DocumentCleaner")]
        //public static void Run(
        //    [CosmosDBTrigger("CognitiveLocator", "Person", ConnectionStringSetting = "PersonTrigger_ConnectionString")]IReadOnlyList<Document> documents,
        //   // [QueueTrigger("myqueue-items", Connection = "PersonTrigger_ConnectionString")] string myQueueItem,
        //    [DocumentDB("CognitiveLocator", "Person", SqlQuery = "SELECT * FROM Person p where p._pending_to_be_deleted=true", ConnectionStringSetting = "PersonTrigger_ConnectionString")] out dynamic document,
        //    TraceWriter log)
        //{
        //    document = new { Text = "", id = Guid.NewGuid() };
        //}
    }
}