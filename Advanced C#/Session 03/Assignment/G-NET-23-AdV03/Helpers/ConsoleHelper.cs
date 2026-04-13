namespace G_NET_23_AdV03.Helpers
{
    internal static class ConsoleHelper
    {
        public static void PrintList<T>(string listName, List<T> items)
        {
            Console.WriteLine($"{listName} : [{string.Join(", ", items)}]");

        }

        public static void PrintSortedList<TKey, TValue>(string listName, SortedList<TKey, TValue> items)
        {
            Console.WriteLine($"{listName}:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintHashSet<T>(string setName, HashSet<T> items)
        {
            Console.WriteLine($"{setName} : [{string.Join(", ", items)}]");

        }
        public static void PrintQueue<T>(string queueName, Queue<T> items)
        {
            Console.WriteLine($"{queueName} : [{string.Join(", ", items)}]");

        }
        public static void PrintStack<T>(string stackName, Stack<T> items)
        {
            Console.WriteLine($"{stackName} : [{string.Join(", ", items)}]");

        }
        public static void PrintArray<T>(string arrayName, T[] items)
        {
            Console.WriteLine($"{arrayName} : [{string.Join(", ", items)}]");

        }
        public static void PrintSpan<T>(string name, Span<T> span)
        {
            Console.Write($"{name} : [");
            foreach (var item in span)
                Console.Write($"{item}, ");
            Console.WriteLine("]");
        }
        public static void PrintCollection<T>(string colName, IEnumerable<T> items)
        {
            Console.WriteLine($"{colName} : [{string.Join(", ", items)}]");

        }
    }
}
