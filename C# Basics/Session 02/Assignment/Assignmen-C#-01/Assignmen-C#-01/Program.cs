using System.Buffers.Text;
using System.Net.NetworkInformation;

namespace Assignmen_C__01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question 1: Regions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 2: REGIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the purpose of #region and #endregion directives in C#? 
            //    How do they help in code organization?
            //
            //
            // A: making large code files easier to navigate and maintain. In Organization it's 
            //    used to organize and group code into collapsible sections.
            // ══════════════════════════════════════════════════════════════════════

            //Nested Region Example

            //#region Data Access Layer

            //#region Read Operations
            //  public User GetById(int id) { }
            //  public List<User> GetAll() { }
            //#endregion

            //#region Write Operations
            //public void Add(User user) { }
            //#endregion

            //#endregion

        #endregion

        #region Question 2: Variable Declaration - Explicit vs Implicit
        // ══════════════════════════════════════════════════════════════════════
        // QUESTION 3: VARIABLE DECLARATION - EXPLICIT VS IMPLICIT
        // ══════════════════════════════════════════════════════════════════════
        //
        // Q: What is the difference between explicit and implicit variable 
        //    declaration in C#? Provide examples of both.
        //
        // A: explicit -> Developer define variable type
        //    Implicit -> Compiler define variable type based on variable's value
        // ══════════════════════════════════════════════════════════════════════



        // EXPLICIT DECLARATION 
        //int x = 5;

        // IMPLICIT DECLARATION 
        //var str = "Mohamed"; //string
        #endregion

        #region Question 3: Constants
        // ══════════════════════════════════════════════════════════════════════
        // QUESTION 4: CONSTANTS
        // ══════════════════════════════════════════════════════════════════════
        //
        // Q: Write the syntax for declaring a constant in C#. Why would you use 
        //    a constant instead of a regular variable?
        //
        // A: We use constants to ensure that a variable's value cannot be changed after it has been declared and initialized
        // ══════════════════════════════════════════════════════════════════════



        // Constant examples
        //const int UserCount = 10;

        #endregion

        #region Question 4: Class-level vs Method-level Scope
        // ══════════════════════════════════════════════════════════════════════
        // QUESTION 4: CLASS-LEVEL VS METHOD-LEVEL SCOPE
        // ══════════════════════════════════════════════════════════════════════
        //
        // Q: Explain the difference between class-level scope and method-level 
        //    scope with examples.
        //
        // A: Class-level scope - accessible anywhere in class.
        //    Method-level scope - accwssible in method only. 
        //    NOTE: Class Scope can be access with method scope but method scope can't be accessed with class scope.
        // ══════════════════════════════════════════════════════════════════════

        //Example:
        //class MyClass
        //{
        //    private int mohamed = 1;  // Class scope 

        //    public void MyMethod(int param)  // param: Method scope
        //    {
        //        int ramadan = 2;         // Method scope

        //    }
        //}

        #endregion

        #region Question 5: Block-level Scope
        // ══════════════════════════════════════════════════════════════════════
        // QUESTION 5: BLOCK-LEVEL SCOPE
        // ══════════════════════════════════════════════════════════════════════
        //
        // Q: What is block-level scope? Give an example showing a variable that 
        //    is only accessible within a specific block.
        //
        // A: Block level: variable declartion in (if, for, while, etc.) and can't access outside this block.
        // ══════════════════════════════════════════════════════════════════════

        //Example
        //class MyClass
        //{
        //    private int _classLevel = 1;  // Class scope - accessible anywhere in class

        //    public void MyMethod(int param)  // param: Method scope
        //    {
        //        int methodLevel = 2;         // Method scope

        //        if (true)
        //        {
        //            int blockLevel = 3;     // Block scope - only here!
        //        }
        //    }
        //}

        #endregion

        #region Question 6: Variable Lifetime - Local vs Static
        // ══════════════════════════════════════════════════════════════════════
        // QUESTION 6: VARIABLE LIFETIME - LOCAL VS STATIC
        // ══════════════════════════════════════════════════════════════════════
        //
        // Q: What is variable lifetime? Explain the lifetime of local variables 
        //    vs static variables.
        // A: Lifetime is how long a variable exists in memory — from creation to destruction.
        //    Local -> lives until method ends
        //    static -> lives for entire app livetime
        // ══════════════════════════════════════════════════════════════════════


        #endregion

        #region Question 7: Garbage Collector
        // ══════════════════════════════════════════════════════════════════════
        // QUESTION 7: GARBAGE COLLECTOR
        // ══════════════════════════════════════════════════════════════════════
        //
        // Q: What is the Garbage Collector in C#? How does it affect the 
        //    lifetime of objects?
        // A: Garbage Collector automatically removes objects from Heap when no references point to them
        // ══════════════════════════════════════════════════════════════════════


        #endregion

        #region Question 8: Variable Shadowing
        // ══════════════════════════════════════════════════════════════════════
        // QUESTION 8: VARIABLE SHADOWING
        // ══════════════════════════════════════════════════════════════════════
        //
        // Q: What is variable shadowing in C#? Does C# allow shadowing in 
        //    nested blocks within the same method?
        // A: Shadowing occurs when a variable declared in an inner scope has the same name as one in an outer scope,
        //    temporarily "hiding" the outer variable.
        // -> C# don't allow shadowing in nested blocks within the same method.
        // ══════════════════════════════════════════════════════════════════════

        #endregion

        #region Question 9: C# Naming Rules
        // ══════════════════════════════════════════════════════════════════════
        // QUESTION 9: C# NAMING RULES
        // ══════════════════════════════════════════════════════════════════════
        //
        // Q: List five rules that must be followed when naming variables in C#.
        //
        // A: - Names must start with a letter or _ (underscore).
        //    - Names never start with digits.
        //    - Can contain letters, digits, and underscores (no spaces).
        //    - Can't contain special letter execpt underscore.
        //    - Avoid keywords (or use @ when necessary).
        // ══════════════════════════════════════════════════════════════════════

        #endregion

        #region Question 10: Naming Conventions
        // ══════════════════════════════════════════════════════════════════════
        // QUESTION 10: NAMING CONVENTIONS
        // ══════════════════════════════════════════════════════════════════════
        //
        // Q: What naming conventions are recommended for: (a) local variables, 
        //    (b) class names, (c) constants?
        // A: (a) camelCase     (b), (c) PascalCase
        // ══════════════════════════════════════════════════════════════════════
        #endregion

        #region Question 11: Error Types
        // ══════════════════════════════════════════════════════════════════════
        // QUESTION 11: ERROR TYPES
        // ══════════════════════════════════════════════════════════════════════
        //
        // Q: Compare and contrast syntax errors, runtime errors, and logical 
        //    errors. Provide an example of each.
        // 
        //  syntax errors  -> Program will not run until fixed.  ex: int n = "Mo";
        //  runtime errors -> Program will run but error will happen while program is running. ex: When devided by zero
        //  logical errors -> Program runs but wrong result 
        // ══════════════════════════════════════════════════════════════════════

        #endregion

        #region Question 12: Exception Handling Importance
        // ══════════════════════════════════════════════════════════════════════
        // QUESTION 12: EXCEPTION HANDLING IMPORTANCE
        // ══════════════════════════════════════════════════════════════════════
        //
        // Q: Why is exception handling important in C#? What would happen if 
        //    you don't handle exceptions?
        //
        // A: Because exception handling prevents crashes and allows controlled recovery.
        //    without handling app will crash.
        // ══════════════════════════════════════════════════════════════════════


        #endregion

        #region Question 13: try-catch-finally
        // ══════════════════════════════════════════════════════════════════════
        // QUESTION 13: TRY-CATCH-FINALLY
        // ══════════════════════════════════════════════════════════════════════
        //
        // Q: Write a code example demonstrating try-catch-finally. Explain when 
        //    the finally block executes.
        //

        //example
        //  try
        //  {
        //      int x = int.Parse("abc");  // Will throw FormatException
        //          Console.WriteLine(x);        // Won't run
        //  }
        //  catch (FormatException ex)
        //  {
        //      Console.WriteLine("Invalid format: " + ex.Message);
        //  }
        //  finally
        //  {
        //      Console.WriteLine("Cleanup done!");  // Always runs
        //  }
        // ══════════════════════════════════════════════════════════════════════

        #endregion

        #region Question 14: Common Built-in Exceptions
        // ══════════════════════════════════════════════════════════════════════
        // QUESTION 14: COMMON BUILT-IN EXCEPTIONS
        // ══════════════════════════════════════════════════════════════════════
        //
        // Q: List and explain five common built-in exceptions in C# with 
        //    scenarios when each would occur.
        //
        // 1 - FormatExceptionInvalid: string format when parsing.
        // 2 - DivideByZeroException: Dividing an integer by zero.
        // 3 - IndexOutOfRangeException: Accessing invalid array index.
        // 4 - NullReferenceException: Using a member on null object.
        // 5 - ArgumentException: Invalid argument value.
        // ══════════════════════════════════════════════════════════════════════
        #endregion

        #region Question 15: Multiple catch Blocks
        // ══════════════════════════════════════════════════════════════════════
        // QUESTION 15: MULTIPLE CATCH BLOCKS
        // ══════════════════════════════════════════════════════════════════════
        //
        // Q: Why is the order of catch blocks important when handling multiple 
        //    exceptions? Write code showing correct ordering.
        //
        // A: Because if you write the least specific at the top this will execute first and ignore other,
        //    
        //    catch (FormatException) { }
        //    catch (ArgumentException) { }
        //    catch (Exception) { } // Last!
        // ══════════════════════════════════════════════════════════════════════

        #endregion

        #region Question 16: throw Keyword
        // ══════════════════════════════════════════════════════════════════════
        // QUESTION 16: THROW KEYWORD
        // ══════════════════════════════════════════════════════════════════════
        //
        // Q: What is the difference between 'throw' and 'throw ex' when 
        //    re-throwing an exception? Which one preserves the stack trace?
        //
        // A: throw; Keeps original location.
        //    throw ex; loses original location.
        //
        //    throw preserves the stack trace
        // ══════════════════════════════════════════════════════════════════════
        #endregion

        #region Question 17: Stack and Heap Memory
        // ══════════════════════════════════════════════════════════════════════
        // QUESTION 17: STACK AND HEAP MEMORY
        // ══════════════════════════════════════════════════════════════════════
        //
        // Q: Explain the differences between Stack and Heap memory in C#. 
        //    What types of data are stored in each?
        //
        // -> Stack: Memory is allocated and released automatically using LIFO, and stores method calls and local variables.
        // -> Heap : Memory is managed by the Garbage Collector, stores objects created using new.
        // ══════════════════════════════════════════════════════════════════════


        #endregion

        #region Question 18: Value Types vs Reference Types
        // ══════════════════════════════════════════════════════════════════════
        // QUESTION 18: VALUE TYPES VS REFERENCE TYPES
        // ══════════════════════════════════════════════════════════════════════
        //
        // Q: Write a code example showing how value types and reference types 
        //    behave differently when assigned to another variable.
        //
        // Value type: 
        //  int a = 10;
        //  int c = a;  // b gets a COPY of 10
        // Reference type:
        //  int[] a = { 1, 2, 3 };
        //  int[] b = a;  // b points to SAME array
        // ══════════════════════════════════════════════════════════════════════

        #endregion

        #region Question 19: Object in C#
        // ══════════════════════════════════════════════════════════════════════
        // QUESTION 19: OBJECT IN C#
        // ══════════════════════════════════════════════════════════════════════
        //
        // Q: Why is 'object' considered the base type of all types in C#? 
        //    What methods does every type inherit from System.Object?
        // A: object is the base type from which all other types are derived.
        //    It is the root type of the C# type hierarchy, and every type, whether primitive (like int, float) or complex (like string, class),
        //    is eventually derived from object.
        //
        //    Common Members of object
        //    ToString() – string representation
        //    Equals() – value comparison
        //    GetHashCode() – hash-based collections
        //    GetType() – runtime type information
        // ══════════════════════════════════════════════════════════════════════

        #endregion
    }
}
}
