using G_NET_23_AdV01.Question12;
using G_NET_23_AdV01.Question20;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;

namespace G_NET_23_AdV01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question01
            //Q1: What is a generic class? Why use generics?
            //A generic class uses type parameters that are replaced with actual types
            //when you create an instance.The type parameter T acts as a placeholder.
            //We use genarics because: (Type Safety - Performance - Code Reuse).

            #endregion

            #region Question02
            //Q2: Write a generic class Container<T> with Add and Get methods.
            //Container<int> container01 = new(3);
            //container01.Add(1);
            //container01.Add(2);
            //container01.Add(3);
            //Console.WriteLine(container01.Get(2));

            #endregion

            #region Question03
            ////Q3:What are multiple type parameters? Write Pair<TKey, TValue>. 
            ////instead of pass one type to classes we can pass multiple type paramaters.
            //Pair<int, string> point = new(1, "One");
            //Console.WriteLine(point);


            #endregion

            #region Question04
            ////Q4: What is a generic method? Write Swap<T> method.
            ////Generic method declares its own type parameter(s). It can exist in 
            ////both generic and non-generic classes.The compiler often infers the type argument.
            //int number1 = 10, number2 = 20;
            //Console.WriteLine($"Before swapping: Number1 = {number1}, Number2 = {number2}");
            //Utility.Swap(ref number1, ref number2);
            //Console.WriteLine($"After swapping: Number1 = {number1}, Number2 = {number2}");
            #endregion

            #region Question05
            ////Q5: Write a generic method FindMax<T> that finds maximum value 
            //int[] items = { 1, 2, 3, 100, 50, 124, -23 };
            //Console.WriteLine(Utility.FindMax(items));
            #endregion

            #region Question06
            //Q6: What is a generic interface? Write IRepository<T>.  
            //generic interfaces define contracts with type parameters.
            //Classes implementing them specify the actual types.


            #endregion

            #region Question07
            ////Q7: What is the 'struct' constraint? Write an example.
            ////where T : struct -> T must be a value type.
            //var intItem = new MyNullable<int>(10);
            //var doubleItem = new MyNullable<double>(10.5);
            ////var stringItem = new MyNullable<string>("Moahmed"); //Exception
            #endregion

            #region Question08
            ////Q8: What is the 'class' constraint? Write an example.
            ////where T : class -> T must be a reference type.

            //var cache01 = new Cache<string>();
            //cache01.Set("Mohamed");

            ////var cache02 = new Cache<int>(); //error int is struct
            #endregion

            #region Question09
            ////Q9: What is the 'new()' constraint? Write an example.
            ////where T : new () requires T to have a public parameterless constructor
            //var factory = new Factory<UserTest>();
            //factory.CreateMany(5);

            #endregion

            #region Question10
            //Q10:  What is the interface constraint? Write an example. 
            //where T : IInterface requires T to implement a specific interface.

            #endregion

            #region Question11
            ////Q11: What is the base class constraint? Write an example.
            ////where T : BaseClass T must inherit from BaseClass.

            //var printer = new Printer<Student>();
            //printer.Print(new Student { Name = "Mohamed" });
            #endregion

            #region Question12
            ////Q12: How do you apply multiple constraints? Write an example.
            ////You can combine multiple constraints for a single type parameter,
            ////and have different constraints for different type parameters.

            //EntityManager<User> manager = new EntityManager<User>();
            //User user = manager.CreateAndSave();

            //user.Name = "Mohamed";

            //Console.WriteLine("User Created:");
            //Console.WriteLine($"ID: {user.Id}");
            //Console.WriteLine($"Name: {user.Name}");

            //Console.WriteLine("----------------------");

            //Mapper<User, UserDto> mapper = new Mapper<User, UserDto>();
            //UserDto dto = mapper.Map(user);

            //dto.Name = user.Name;

            //Console.WriteLine("Mapped DTO:");
            //Console.WriteLine($"Name: {dto.Name}");

            #endregion

            #region Question13
            //Q13: What does the 'default' keyword do in generics?
            //default(T) or default returns the default value for type T: null
            //for reference types, 0/false for value types
            #endregion

            #region Question14
            ////Q14: Write a SafeList<T> that returns default when the index is invalid.

            //SafeList<int> safeList = new();
            //safeList.Add(5);
            //safeList.Add(8);
            //Console.WriteLine($"  Index 1: {safeList.GetAt(1)}");
            //Console.WriteLine($"  Index 10: {safeList.GetAt(10)} (returns default)");
            #endregion

            #region Question15
            //Q15: What is covariance? Explain the 'out' keyword.
            //Covariance allows you to use a more derived type than originally specified.
            //Marked with out keyword.T can only appear in output positions.
            #endregion

            #region Question16
            //Q16: What is contravariance? Explain the 'in' keyword. 
            //Contravariance allows you to use a less derived type than originally
            //specified. Marked with in keyword.T can only appear in input positions.
            #endregion

            #region Question17
            //Q17: What is the difference between covariance and contravariance?
            //Aspect	    Covariance (out)	    Contravariance (in)
            //Direction	    Derived → Base	        Base → Derived
            //T Position	Output only (return)	Input only (parameter)
            //Example	    IEnumerable<out T>	    Action<in T>
            //Think of as	Producer of T	        Consumer of T
            #endregion

            #region Question18
            //Q18: How do static members work in generic types?
            //Each closed generic type has its own copy of static fields.
            #endregion

            #region Question19
            ////Q19: How can you inherit from a generic class?
            ////There are three patterns:
            ////1 - Inherit and Pass Type Parameter
            //public class Repository<T> { /* base */ }

            //// Derived class is also generic
            //public class CachedRepository<T> : Repository<T> { }

            ////2 - Inherit with Concrete Type
            //// Derived class specifies the type
            //public class UserRepository : Repository<User> { }

            ////3 - Add New Type Parameter
            //// Derived class adds more type parameters
            //public class KeyedRepository<TKey, TEntity> : Repository<TEntity> { }
            #endregion

            #region Question20
            ////Q20: Complete Exercise - Create a generic
            ////Cache<TKey, TValue>with Add, Get, Remove, Contains, and expiration support. 

            //clsCache<string, string> cache = new();
            //cache.Add("Mohamed", "Ramadan", TimeSpan.FromSeconds(5));
            //cache.Add("Ramy", "Ramadan", TimeSpan.FromSeconds(10));
            //Console.WriteLine(cache.Contains("Ramy"));
            //Console.WriteLine(cache.Get("Mohamed"));
            //Console.WriteLine(cache.Remove("Ramy"));
            //Console.WriteLine(cache.Contains("Ramy"));

            #endregion
        }
    }
}
