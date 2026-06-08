using EventHub;

// Entry point - demonstrates the DbContext is wired correctly
using var context = new AppDbContext();

Console.WriteLine("EventHub EF Core - DbContext ready.");
Console.WriteLine("Run: dotnet ef migrations add InitialCreate");
Console.WriteLine("Then: dotnet ef database update");
