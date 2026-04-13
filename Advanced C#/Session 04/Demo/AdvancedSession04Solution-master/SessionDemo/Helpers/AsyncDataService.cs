namespace SessionDemo.Helpers._02_AsyncSolution
{
    public class AsyncDataService
    {
        public async Task<string> FetchDataFromDatabaseAsync()
        {
            Console.WriteLine($"    [{Environment.CurrentManagedThreadId}] Starting database fetch...");
            await Task.Delay(2000);
            Console.WriteLine($"    [{Environment.CurrentManagedThreadId}] Database fetch complete.");
            return "Database result";
        }

        public async Task<string> FetchDataFromApiAsync()
        {
            Console.WriteLine($"    [{Environment.CurrentManagedThreadId}] Starting API fetch...");
            await Task.Delay(1500);
            Console.WriteLine($"    [{Environment.CurrentManagedThreadId}] API fetch complete.");
            return "API result";
        }

        public async Task<string> ProcessDataAsync(string data)
        {
            Console.WriteLine($"    [{Environment.CurrentManagedThreadId}] Starting data processing...");
            await Task.Delay(1000);
            Console.WriteLine($"    [{Environment.CurrentManagedThreadId}] Processing complete.");
            return $"Processed: {data}";
        }
        public async Task<string> DownloadImageAsync(string url, int delayMs)
        {
            Console.WriteLine($"[{Environment.CurrentManagedThreadId}] Downloading from {url}...");
            await Task.Delay(delayMs);
            return $"Image from {url}";
        }
    }
}
