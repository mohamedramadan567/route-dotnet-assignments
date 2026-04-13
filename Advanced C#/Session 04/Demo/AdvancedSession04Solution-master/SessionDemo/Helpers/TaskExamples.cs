namespace SessionDemo.Helpers
{
    internal class TaskExamples
    {
        public Task DoWorkAsync()
        {
            return Task.Delay(1000);
        }

        public Task<int> CalculateAsync(int x, int y)
        {
            return Task.FromResult(x + y);
        }

        static readonly Dictionary<int, string> _students = new()
        {
            [100] = "Ahmed",
            [200] = "Omar",
            [300] = "Salma"
        };
        public ValueTask<string> GetCachedValueAsync(int code, bool useCache = true)
        {
            if (useCache)
            {
                if (_students.TryGetValue(code, out string? name))
                    return new ValueTask<string>(name); // no allocation!
            }

            return new ValueTask<string>(FetchFromSourceAsync());
        }

        private async Task<string> FetchFromSourceAsync()
        {
            await Task.Delay(100);
            return "Name From Source";
        }
    }
}
