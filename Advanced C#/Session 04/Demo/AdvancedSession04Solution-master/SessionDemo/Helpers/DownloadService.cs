namespace SessionDemo.Helpers
{
    public class DownloadService
    {
        public async Task<string> DownloadFileAsync(string fileName, CancellationToken cancellationToken = default)
        {
            Console.WriteLine($"Starting download: {fileName}");

            for (int i = 0; i <= 100; i += 20)
            {
                cancellationToken.ThrowIfCancellationRequested();

                Console.WriteLine($"    Downloading {fileName}: {i}%");
                await Task.Delay(500, cancellationToken);
            }

            return $"{fileName} downloaded successfully";
        }

        public async Task<string> DownloadWithTimeoutAsync(string fileName, int timeoutMs)
        {
            using var cts = new CancellationTokenSource(timeoutMs);

            try
            {
                return await DownloadFileAsync(fileName, cts.Token);
            }
            catch (OperationCanceledException)
            {
                return $"{fileName} download timed out after {timeoutMs}ms";
            }
        }

    }
}
