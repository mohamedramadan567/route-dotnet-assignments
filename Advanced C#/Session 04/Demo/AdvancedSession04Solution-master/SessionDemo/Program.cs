namespace SessionDemo
{
    internal class Program
    {

        static async Task Main(string[] args)
        {
            #region Part 01 

            #region Problem with Synchronous Code

            //SyncDataService syncService = new();
            //Stopwatch sw = Stopwatch.StartNew();

            //Console.WriteLine("Executing 3 operations synchronously:");
            //string result1 = syncService.FetchDataFromDatabase(); // blocks 2s
            //string result2 = syncService.FetchDataFromApi(); // blocks 1.5s
            //string result3 = syncService.ProcessData(result1);  // blocks 1s


            //sw.Stop();
            //Console.WriteLine($"Total time: {sw.ElapsedMilliseconds}ms "); // 2000 + 1500 + 1000
            //                                                               // Thread is blocked (can't do other work)
            //                                                               // UI freezes in desktop apps


            #endregion

            #region The Solution: async/await

            //AsyncDataService asyncService = new();
            //sw.Restart();

            //Console.WriteLine("Executing operations asynchronously:");
            //string asyncResult01 = await asyncService.FetchDataFromDatabaseAsync();
            //string asyncResult02 = await asyncService.FetchDataFromApiAsync();
            //string asyncResult03 = await asyncService.ProcessDataAsync(asyncResult01);

            //sw.Stop();
            //Console.WriteLine($"Total time: {sw.ElapsedMilliseconds}ms");
            //// Thread was FREE to do other work while waiting
            //// this is async but NOT parallel. 
            #endregion

            #endregion

            #region Part 02 - Task

            #region Task in .NET
            //TaskExamples taskExamples = new();

            //Console.WriteLine("Task (no return value):");
            //await taskExamples.DoWorkAsync();

            //Console.WriteLine("Task<int> (returns int):");
            //int sum = await taskExamples.CalculateAsync(5, 3);
            //Console.WriteLine($"CalculateAsync(5, 3) = {sum}");

            //Console.WriteLine("ValueTask<string>");
            //Stopwatch sw = Stopwatch.StartNew();
            //string cached = await taskExamples.GetCachedValueAsync(100);
            //Console.WriteLine($"GetCachedValueAsync(cached) = {cached}");
            //sw.Stop();
            //Console.WriteLine($"Total time: {sw.ElapsedMilliseconds}ms");

            //sw.Restart();

            //cached = await taskExamples.GetCachedValueAsync(10);
            //Console.WriteLine($"GetCachedValueAsync(cached) = {cached}");
            //sw.Stop();
            //Console.WriteLine($"Total time: {sw.ElapsedMilliseconds}ms");

            #endregion

            #region Task States
            //Task<int> firstTask = Task.Run(async () =>
            //{
            //    await Task.Delay(100);
            //    return 42;
            //});

            //Console.WriteLine($"Task Status: {firstTask.Status}");
            //await firstTask;
            //Console.WriteLine($"Task Status: {firstTask.Status}");
            //Console.WriteLine($"IsCompleted: {firstTask.IsCompleted}");
            //Console.WriteLine($"IsCompletedSuccessfully: {firstTask.IsCompletedSuccessfully}");
            //Console.WriteLine($"Result: {firstTask.Result}");
            #endregion

            #endregion

            #region Part 03 - Async and await

            //Console.WriteLine($"[{Environment.CurrentManagedThreadId}] Before await");
            //string greeting = await GetGreetingAsync("World");
            //Console.WriteLine($"[{Environment.CurrentManagedThreadId}] After await");
            //Console.WriteLine($"Result: {greeting}");


            //Console.WriteLine($"[{Environment.CurrentManagedThreadId}] Before await");
            //Task greeting02 = GetGreetingAsync("World"); // Task started but we didn't wait!
            //Console.WriteLine($"[{Environment.CurrentManagedThreadId}] After await");
            //Console.WriteLine($"Result: {greeting02}");
            //Console.WriteLine($"Task.IsCompleted: {greeting02.IsCompleted}");



            #endregion

            #region Part 04 Task Advanced Patterns

            #region Task.WhenAll - Parallel Execution
            //AsyncDataService asyncService = new();
            //Stopwatch sw = Stopwatch.StartNew();

            //Console.WriteLine("Executing operations asynchronously:");
            //Console.WriteLine("Sequential execution (one after another):");

            //string asyncResult01 = await asyncService.FetchDataFromDatabaseAsync();
            //string asyncResult02 = await asyncService.FetchDataFromApiAsync();
            //string asyncResult03 = await asyncService.ProcessDataAsync(asyncResult01);

            //sw.Stop();
            //Console.WriteLine($"Sequential Total time: {sw.ElapsedMilliseconds}ms");
            //Console.WriteLine("Results:");
            //Console.WriteLine(asyncResult01);
            //Console.WriteLine(asyncResult02);
            //Console.WriteLine(asyncResult03);

            //// Thread was FREE to do other work while waiting
            //// this is async but NOT parallel. 


            //sw.Restart();

            //Console.WriteLine("Parallel execution with Task.WhenAll:");

            //Task<string> task01 = asyncService.FetchDataFromDatabaseAsync();
            //Task<string> task02 = asyncService.FetchDataFromApiAsync();
            //Task<string> task03 = asyncService.ProcessDataAsync(asyncResult01);

            //string[] results = await Task.WhenAll(task01, task02, task03);
            //Console.WriteLine($"Parallel time: {sw.ElapsedMilliseconds}ms");
            //Console.WriteLine("Results:");
            //Console.WriteLine(results[0]);
            //Console.WriteLine(results[1]);
            //Console.WriteLine(results[2]);
            #endregion

            #region Task.WhenAny - First to Complete

            //AsyncDataService asyncService = new();

            //Task<string> server1 = asyncService.DownloadImageAsync("server1.com", 1500);
            //Task<string> server2 = asyncService.DownloadImageAsync("server2.com", 800);
            //Task<string> server3 = asyncService.DownloadImageAsync("server3.com", 1200);

            //Task<string> winner = await Task.WhenAny(server1, server2, server3);
            //Console.WriteLine($"Winner: {await winner}");

            //Console.WriteLine("Timeout pattern:");
            //Task<string> slowTask = asyncService.DownloadImageAsync("slow.com", 5000);
            //Task timeoutTask = Task.Delay(1000);

            //Task completedTask = await Task.WhenAny(slowTask, timeoutTask);

            //if (completedTask == timeoutTask)
            //{
            //    Console.WriteLine("Operation timed out!");
            //}
            //else
            //{
            //    Console.WriteLine($"Completed: {await slowTask}");
            //}

            #endregion

            #region Exception Handling in Async

            //try
            //{
            //    await ThrowingMethodAsync();
            //}
            //catch (InvalidOperationException ex)
            //{
            //    Console.WriteLine($"Caught: {ex.Message}");
            //}

            ////Checking Task.Exception directly
            //Task faultedTask = ThrowingMethodAsync();
            //try
            //{
            //    await faultedTask;
            //}
            //catch
            //{
            //    Console.WriteLine($"Task.IsFaulted: {faultedTask.IsFaulted}");
            //    Console.WriteLine($"Exception: {faultedTask.Exception?.InnerException?.Message}");
            //}

            #endregion

            #region WhenAll Exception Handling

            //Task task1 = Task.Run(() => throw new InvalidOperationException("Error 1"));
            //Task task2 = Task.Run(() => throw new ArgumentException("Error 2"));
            //Task task3 = Task.Delay(100);

            //Task allTasks = Task.WhenAll(task1, task2, task3);

            //try
            //{
            //    await allTasks;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Caught: {ex.GetType().Name} - {ex.Message}");
            //    Console.WriteLine("All exceptions from Task.Exception:");
            //    if (allTasks.Exception != null)
            //    {
            //        foreach (var inner in allTasks.Exception.InnerExceptions)
            //        {
            //            Console.WriteLine($"{inner.GetType().Name}: {inner.Message}");
            //        }
            //    }
            //}
            #endregion

            #endregion

            #region Part 05 CancellationToken

            //DownloadService downloadService = new();

            //Console.WriteLine("Example 1: Manual cancellation after 1 second");
            //using (CancellationTokenSource cts = new())
            //{
            //    Task downloadTask = downloadService.DownloadFileAsync("large_file.zip", cts.Token);

            //    await Task.Delay(1100);
            //    cts.Cancel();

            //    try
            //    {
            //        await downloadTask;
            //    }
            //    catch (OperationCanceledException)
            //    {
            //        Console.WriteLine("  Download was cancelled!");
            //    }
            //}

            //Console.WriteLine("Example 2: Timeout using CancellationTokenSource");
            //string timeoutResult = await downloadService.DownloadWithTimeoutAsync("slow_file.zip", 1500);
            //Console.WriteLine($"  Result: {timeoutResult}");

            #endregion

        }
        static async Task ThrowingMethodAsync()
        {
            await Task.Delay(100);
            throw new InvalidOperationException("Something went wrong!");
        }
        static async Task<string> GetGreetingAsync(string name)
        {
            await Task.Delay(100);
            return $"Hello, {name}!";
        }
    }
}
