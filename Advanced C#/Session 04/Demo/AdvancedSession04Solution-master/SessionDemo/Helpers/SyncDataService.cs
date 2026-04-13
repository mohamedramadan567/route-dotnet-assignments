namespace SessionDemo.Helpers
{
    public class SyncDataService
    {
        public string FetchDataFromDatabase()
        {
            Console.WriteLine($"[{Environment.CurrentManagedThreadId}] Fetching from database...");
            Thread.Sleep(2000);
            return "Database result";
        }

        public string FetchDataFromApi()
        {
            Console.WriteLine($"[{Environment.CurrentManagedThreadId}] Fetching from API...");
            Thread.Sleep(1500);
            return "API result";
        }

        public string ProcessData(string data)
        {
            Console.WriteLine($"[{Environment.CurrentManagedThreadId}] Processing data...");
            Thread.Sleep(1000);
            return $"Processed: {data}";
        }
    }
}
